DROP PROCEDURE sp_dtr_empl
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- EXEC sp_dtr_empl '2022','05','1'
-- =============================================
CREATE PROCEDURE sp_dtr_empl
	@p_period_from		DATE
   ,@p_period_to		DATE
   ,@p_employee_id		VARCHAR(20)
AS
BEGIN

--	DECLARE @v_exist VARCHAR(1) = ISNULL((SELECT TOP 1 '1' FROM dtr_empl_tbl WHERE employee_id = @p_employee_id AND YEAR(dtr_date) = @p_dtr_year AND MONTH(dtr_date) = @p_dtr_month),'0')
--	IF @v_exist = '0' OR @p_employee_id = ''
--	BEGIN
		--DECLARE @p_period_from		DATE		= '2023-5-01'
		--DECLARE @p_period_to		DATE		= '2023-05-09'
		--DECLARE @p_employee_id		VARCHAR(20) = '2'
		-- ***********************************
		-- ******* REGULAR SCHEDULE **********
		-- ***********************************
		DELETE dtr_tbl WHERE employee_id =  @p_employee_id AND dtr_date BETWEEN @p_period_from AND @p_period_to
		
		INSERT INTO dtr_tbl
		SELECT 
		 A.Id AS employee_id
		,A.employee_name_oth_format
		,B.dtr_date
		,B.dtr_date_day
		,ISNULL(C.time_in_am,'')	AS time_in_am
		,ISNULL(C.time_out_am,'')	AS time_out_am
		,ISNULL(C.time_in_pm,'')	AS time_in_pm
		,ISNULL(C.time_out_pm,'')	AS time_out_pm
		,CASE
			WHEN ISNULL(C.dtr_date,'') = '' -- No entry for this day
		 THEN 0
		 ELSE  IIF(ISNULL(C.time_in_am,'') > CONVERT(time,'08:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' 08:00'), CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_in_am,''))),0) 
			  +IIF(ISNULL(C.time_in_pm,'') > CONVERT(time,'13:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' 13:00'), CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_in_pm,''))),0)
			  +IIF(ISNULL(C.time_in_am,'') = '' AND C.time_out_am = '',240,0) 
		 END AS late_time_min
		,CASE
			WHEN ISNULL(C.dtr_date,'') = '' -- No entry for this day
		 THEN 0
		 ELSE  IIF(ISNULL(C.time_out_am,'') < CONVERT(time,'12:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_out_am,'')), CONCAT(ISNULL(C.dtr_date,''),' 12:00')),0) 
			  +IIF(ISNULL(C.time_out_pm,'') < CONVERT(time,'17:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_out_pm,'')), CONCAT(ISNULL(C.dtr_date,''),' 17:00')),0) 
			  +IIF(ISNULL(C.time_in_pm,'') = '' AND ISNULL(C.time_out_pm,'') = '',240,0) 
		  END AS under_time_min
		,IIF(ISNULL(C.time_out_pm,'') > CONVERT(time,'17:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' 17:00'), CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_out_pm,''))),0) AS ot_min
		,0  AS is_absent
		,0  AS is_leave
		,0  AS is_holiday
		,'' AS remarks_details
		FROM vw_employee_tbl A
		INNER JOIN dbo.fn_calendar_days_1(@p_period_from,@p_period_to) B
		ON B.dtr_date = B.dtr_date
		LEFT JOIN dtr_conso_tbl C
		ON C.dtr_date = B.dtr_date
		AND C.employee_id = A.Id
		WHERE (@p_employee_id = '' OR A.Id = @p_employee_id)
		--ORDER BY B.dtr_date

		SELECT 'Successfully Generated' AS message_descr
		-- ***********************************
		-- ******* REGULAR SCHEDULE **********
		-- ***********************************
	--END
	--ELSE
	--BEGIN
	--	SELECT 'No Inserted' AS message_descr
	--END

END
GO
