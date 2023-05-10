DROP PROCEDURE sp_dtr_empl
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- EXEC sp_dtr_empl '2022','05',''
-- =============================================
CREATE PROCEDURE sp_dtr_empl
	@p_dtr_year			VARCHAR(04)
   ,@p_dtr_month		VARCHAR(02)
   ,@p_employee_id		VARCHAR(20)
AS
BEGIN

	DECLARE @v_exist VARCHAR(1) = ISNULL((SELECT TOP 1 '1' FROM dtr_empl_tbl WHERE employee_id = @p_employee_id AND YEAR(dtr_date) = @p_dtr_year AND MONTH(dtr_date) = @p_dtr_month),'0')
	IF @v_exist = '0' OR @p_employee_id = ''
	BEGIN
		-- ***********************************
		-- ******* REGULAR SCHEDULE **********
		-- ***********************************
		--INSERT INTO dtr_empl_tbl
		SELECT 
		 MN.employee_id
		,MN.dtr_date
		,MN.time_in_am
		,MN.time_out_am
		,MN.time_in_pm
		,MN.time_out_pm
		,IIF(MN.time_out_am < CONVERT(time,'12:00'),DATEDIFF(minute, CONCAT(dtr_date,' ',MN.time_out_am), CONCAT(dtr_date,' 12:00')),0) +
		 IIF(MN.time_out_pm < CONVERT(time,'17:00'),DATEDIFF(minute, CONCAT(dtr_date,' ',MN.time_out_pm), CONCAT(dtr_date,' 17:00')),0) +
		 IIF(MN.time_in_pm = '' AND MN.time_out_pm = '',240,0) AS under_time_min
		,'' AS under_time_descr
		,IIF(MN.time_in_am > CONVERT(time,'08:00'),DATEDIFF(minute, CONCAT(dtr_date,' 08:00'), CONCAT(dtr_date,' ',MN.time_in_am)),0) + 
		 IIF(MN.time_in_pm > CONVERT(time,'13:00'),DATEDIFF(minute, CONCAT(dtr_date,' 13:00'), CONCAT(dtr_date,' ',MN.time_in_pm)),0) +
		 IIF(MN.time_in_am = '' AND MN.time_out_am = '',240,0)
		  AS late_time_min
		,'' AS late_time_descr
		,IIF(MN.time_out_pm > CONVERT(time,'17:00'),DATEDIFF(minute, CONCAT(dtr_date,' 17:00'), CONCAT(dtr_date,' ',MN.time_out_pm)),0) AS ot_min
		,'' AS ot_descr
		,'' AS remarks_details
		,0  AS is_leave
		,0  AS is_holiday
		,0  AS is_ob

		FROM dtr_conso_tbl MN

		 WHERE  YEAR(MN.dtr_date)  = @p_dtr_year
		 AND   MONTH(MN.dtr_date)  = @p_dtr_month
		 AND   (@p_employee_id = '' OR MN.employee_id = @p_employee_id)
		 --AND   (ISNULL(MN.time_in_am,'') <> '' OR ISNULL(MN.time_out_am,'') <> '' OR ISNULL(MN.time_in_pm,'') <> '' OR ISNULL(MN.time_out_pm,'') <> '')
		 --AND   (ISNULL(MN.time_in_am,'') <> '' AND ISNULL(MN.time_out_am,'') <> '' AND ISNULL(MN.time_in_pm,'') <> '' AND ISNULL(MN.time_out_pm,'') <> '')

		-- ***********************************
		-- ******* REGULAR SCHEDULE **********
		-- ***********************************
	END
	ELSE
	BEGIN
		SELECT 'No Inserted' AS message_descr
	END

END
GO
