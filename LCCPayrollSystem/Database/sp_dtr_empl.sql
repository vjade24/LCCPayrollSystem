--DROP PROCEDURE sp_dtr_empl
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- EXEC sp_dtr_empl '2022','05','1'
---- =============================================
--CREATE PROCEDURE sp_dtr_empl
--	@p_dtr_year			VARCHAR(04)
--   ,@p_dtr_month		VARCHAR(02)
--   ,@p_employee_id		VARCHAR(20)
--AS
--BEGIN

--	DECLARE @v_exist VARCHAR(1) = ISNULL((SELECT TOP 1 '1' FROM dtr_empl_tbl WHERE employee_id = @p_employee_id AND YEAR(dtr_date) = @p_dtr_year AND MONTH(dtr_date) = @p_dtr_month),'0')
--	IF @v_exist = '0' OR @p_employee_id = ''
--	BEGIN
		DECLARE @p_dtr_year			VARCHAR(04) = '2022'
		DECLARE @p_dtr_month		VARCHAR(02) = '05'
		DECLARE @p_employee_id		VARCHAR(20) = '1'
		-- ***********************************
		-- ******* REGULAR SCHEDULE **********
		-- ***********************************
		--INSERT INTO dtr_empl_tbl
		SELECT 
		 B.dtr_date
		,B.dtr_date_day
		,A.Id AS employee_id
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
		--,'' AS late_time_descr
		,CASE
			WHEN ISNULL(C.dtr_date,'') = '' -- No entry for this day
		 THEN 0
		 ELSE  IIF(ISNULL(C.time_out_am,'') < CONVERT(time,'12:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_out_am,'')), CONCAT(ISNULL(C.dtr_date,''),' 12:00')),0) 
			  +IIF(ISNULL(C.time_out_pm,'') < CONVERT(time,'17:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_out_pm,'')), CONCAT(ISNULL(C.dtr_date,''),' 17:00')),0) 
			  +IIF(ISNULL(C.time_in_pm,'') = '' AND ISNULL(C.time_out_pm,'') = '',240,0) 
		  END AS under_time_min
		--,'' AS under_time_descr
		,IIF(ISNULL(C.time_out_pm,'') > CONVERT(time,'17:00'),DATEDIFF(minute, CONCAT(ISNULL(C.dtr_date,''),' 17:00'), CONCAT(ISNULL(C.dtr_date,''),' ',ISNULL(C.time_out_pm,''))),0) AS ot_min
		--,'' AS ot_descr
		,'' AS remarks_details
		,0  AS is_absent
		,0  AS is_leave
		,0  AS is_holiday
		,0  AS is_ob
		FROM employee_tbl A
		INNER JOIN dbo.fn_calendar_days(@p_dtr_year,@p_dtr_month) B
		ON B.dtr_date = B.dtr_date
		LEFT JOIN dtr_conso_tbl C
		ON C.dtr_date = B.dtr_date
		AND C.employee_id = A.Id
		WHERE (@p_employee_id = '' OR A.Id = @p_employee_id)
		ORDER BY B.dtr_date
		-- ***********************************
		-- ******* REGULAR SCHEDULE **********
		-- ***********************************
--	END
--	ELSE
--	BEGIN
--		SELECT 'No Inserted' AS message_descr
--	END

--END
--GO
