DROP PROCEDURE sp_dtr_conso_generation
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- EXEC sp_dtr_conso_generation '2022','05',''
-- =============================================
CREATE PROCEDURE sp_dtr_conso_generation
	@p_dtr_year			VARCHAR(04)
   ,@p_dtr_month		VARCHAR(02)
   ,@p_generated_by		VARCHAR(20)
AS
BEGIN
	-- *****************************************
	-- ********* INSERT TO TABLE ***************
	-- *****************************************
	INSERT INTO dtr_conso_tbl
	SELECT 
	 A.employee_id
	,CONVERT(date,bio_datetime) AS bio_date
	,ISNULL((SELECT MIN(CONVERT(time,AM_IN.bio_datetime)) 
				FROM  dtr_upload_tbl AM_IN
				WHERE AM_IN.employee_id				 = A.employee_id
				AND   CONVERT(date,AM_IN.bio_datetime) = CONVERT(date,A.bio_datetime)
				AND   CONVERT(time,bio_datetime) BETWEEN CONVERT(time,'00:00') AND CONVERT(time,'10:30')
				),'') AS time_in_am

	,ISNULL((SELECT MAX(CONVERT(time,AM_OUT.bio_datetime)) 
				FROM  dtr_upload_tbl AM_OUT
				WHERE AM_OUT.employee_id				 = A.employee_id
				AND   CONVERT(date,AM_OUT.bio_datetime) = CONVERT(date,A.bio_datetime)
				AND   CONVERT(time,bio_datetime) BETWEEN CONVERT(time,'10:31') AND CONVERT(time,'12:30')
				),'') AS time_out_am

	,ISNULL((SELECT MIN(CONVERT(time,PM_IN.bio_datetime)) 
				FROM  dtr_upload_tbl PM_IN
				WHERE PM_IN.employee_id				 = A.employee_id
				AND   CONVERT(date,PM_IN.bio_datetime) = CONVERT(date,A.bio_datetime)
				AND   CONVERT(time,bio_datetime) BETWEEN CONVERT(time,'12:31') AND CONVERT(time,'15:30')
				),'') AS time_in_pm
		  
	,ISNULL((SELECT MAX(CONVERT(time,PM_OUT.bio_datetime)) 
				FROM  dtr_upload_tbl PM_OUT
				WHERE PM_OUT.employee_id				 = A.employee_id
				AND   CONVERT(date,PM_OUT.bio_datetime) = CONVERT(date,A.bio_datetime)
				AND   CONVERT(time,bio_datetime) BETWEEN CONVERT(time,'15:31') AND CONVERT(time,'23:59')
				),'') AS time_out_pm
    
	,@p_generated_by AS created_by
	,GETDATE()		 AS created_dttm
	,''			     AS updated_by
	,''			     AS updated_dttm

	FROM dtr_upload_tbl A

	LEFT JOIN dtr_conso_tbl B
	ON  B.employee_id = A.employee_id
	AND B.dtr_date   = CONVERT(date,bio_datetime)

	WHERE  YEAR(CONVERT(date,bio_datetime))  = @p_dtr_year
	AND   MONTH(CONVERT(date,bio_datetime))  = @p_dtr_month
	AND   ISNULL(B.id,'')					 = ''
	
	GROUP BY 
	 A.employee_id
	,CONVERT(date,bio_datetime)
	
END
GO
