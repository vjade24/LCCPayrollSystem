-- SELECT * FROM fn_calendar_days('2023','05')
DROP FUNCTION [dbo].[fn_calendar_days]
GO
CREATE FUNCTION [dbo].[fn_calendar_days] (
	@p_year			VARCHAR(04),
	@p_month		VARCHAR(02)
)
RETURNS @calendar_dates_tbl TABLE 
	(
		 dtr_date				DATE		NOT NULL
		,dtr_date_day			VARCHAR(03)	
	)
AS	
BEGIN
	DECLARE @v_dtr_date				DATE
	DECLARE @day_cnt				INT
	DECLARE @day_last				INT

	SET @v_dtr_date = CONVERT(DATE, CAST(@p_year AS VARCHAR(04)) + '-' + CAST(@p_month AS VARCHAR(02)) + '-01')
	SET @day_cnt    = 1
	SET @day_last   = DAY(EOMONTH(@v_dtr_date))
	WHILE @day_cnt <= @day_last
	BEGIN

		SET @v_dtr_date = CONVERT(DATE, CAST(@p_year AS VARCHAR(04)) + '-' + CAST(@p_month AS VARCHAR(02)) + '-' + CAST(@day_cnt AS VARCHAR(02)) )

		INSERT INTO @calendar_dates_tbl
		SELECT @v_dtr_date
			  ,UPPER(LEFT(DATENAME(dw,@v_dtr_date),3))	
	   SET @day_cnt = @day_cnt + 1;
	END
	RETURN

END