USE [SIGC_Ferreteria]
GO
/****** Object:  StoredProcedure [dbo].[SIGC_FER_SP_rManTabCateg]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_FER_SP_rManTabCateg]
	-- Add the parameters for the stored procedure here
	@psOpc nvarchar(1), 
	@piCat integer, 
	@piEmp integer, 
	@psDes nvarchar(200), 
	@psEst nvarchar(1) 
AS
DECLARE @liSec integer;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Insert statements for procedure here
	if @psOpc = 'A'
	   begin
	      select @liSec = isnull(MAX(CATEG_ID),0)+1 from SIGC_FER_CATEGORIA where EMP_ID = @piEmp
	      INSERT INTO SIGC_FER_CATEGORIA (CATEG_ID, EMP_ID, CATEG_DESC, CATEG_EST)
		  VALUES(@liSec, @piEmp, @psDes, @psEst)
	   end

	-- editfering with SELECT statements.
	if @psOpc = 'M'
	   begin
	      UPDATE SIGC_FER_CATEGORIA
		     set EMP_ID = @piEmp, 
			     CATEG_DESC = @psdes, 
				 CATEG_EST = @psEst
		   where CATEG_ID = @piCat
	   end

	-- delfering with SELECT statements.
	if @psOpc = 'E'
	   begin
	      UPDATE SIGC_FER_CATEGORIA
		     set CATEG_EST = @psEst
		   where CATEG_ID = @piCat
	   end
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_FER_SP_rManTabCli]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_FER_SP_rManTabCli]
	-- Add the parameters for the stored procedure here
	@psOpc nvarchar(1), 
	@piEmp integer, 
	@piCli integer, 
	@psTip nvarchar(1), 
	@psDoc nvarchar(30), 
	@psNom nvarchar(200), 
	@psDir nvarchar(200), 
	@psTel nvarchar(100), 
	@psEma nvarchar(100), 
	@psEst nvarchar(1) 
AS
DECLARE @liSec integer;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Insert statements for procedure here
	if @psOpc = 'A'
	   begin
	      select @liSec = isnull(MAX(CLI_ID),0)+1 from SIGC_FER_CLIENTES where EMP_ID = @piEmp
	      INSERT INTO SIGC_FER_CLIENTES (EMP_ID, CLI_ID, CLI_TIPO, CLI_NRODOC, CLI_NOMBRE, CLI_DIRECCION, CLI_TELEFONO, CLI_EMAIL, CLI_EST)
		  VALUES(@piEmp, @liSec, @psTip, @psDoc, @psNom, @psDir, @psTel, @psEma, @psEst)
	   end

	-- editfering with SELECT statements.
	if @psOpc = 'M'
	   begin
	      UPDATE SIGC_FER_CLIENTES
		     set EMP_ID = @piEmp, 
			     CLI_TIPO = @psTip, 
				 CLI_NRODOC = @psDoc, 
				 CLI_NOMBRE = @psNom, 
				 CLI_DIRECCION = @psDir, 
				 CLI_TELEFONO = @psTel, 
				 CLI_EMAIL = @psEma, 
				 CLI_EST = @psEst
		   where CLI_ID = @piCli
	   end

	-- delfering with SELECT statements.
	if @psOpc = 'E'
	   begin
	      UPDATE SIGC_FER_CLIENTES
		     set CLI_EST = @psEst
		   where CLI_ID = @piCli
	   end
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_FER_SP_rManTabProd]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_FER_SP_rManTabProd]
	-- Add the parameters for the stored procedure here
	@psOpc nvarchar(1), 
	@piPro integer, 
	@piEmp integer, 
	@piCat integer, 
	@piUni integer, 
	@psDes nvarchar(200), 
	@pnPre numeric(15,5), 
	@pnStk numeric(15,5), 
	@pnMin numeric(15,5), 
	@psEst nvarchar(1) 
AS
DECLARE @liSec integer;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Insert statements for procedure here
	if @psOpc = 'A'
	   begin
	      select @liSec = isnull(MAX(PROD_ID),0)+1 from SIGC_FER_PRODUCTO where EMP_ID = @piEmp
	      INSERT INTO SIGC_FER_PRODUCTO (PROD_ID, EMP_ID, CATEG_ID, UNIMED_ID, PROD_DESC, PROD_PRECIO, PROD_STOCK, PROD_STOCKMIN, PROD_EST)
		  VALUES(@liSec, @piEmp, @piCat, @piUni, @psDes, @pnPre, @pnStk, @pnMin, @psEst)
	   end

	-- editfering with SELECT statements.
	if @psOpc = 'M'
	   begin
	      UPDATE SIGC_FER_PRODUCTO
		     set EMP_ID = @piEmp, 
				 CATEG_ID = @piCat, 
				 UNIMED_ID = @piUni, 
				 PROD_DESC = @psDes, 
				 PROD_PRECIO = @pnPre, 
				 PROD_STOCK = @pnStk, 
				 PROD_STOCKMIN = @pnMin, 
				 PROD_EST = @psEst
		   where PROD_ID = @piPro
	   end

	-- delfering with SELECT statements.
	if @psOpc = 'E'
	   begin
	      UPDATE SIGC_FER_PRODUCTO
		     set PROD_EST = @psEst
		   where PROD_ID = @piPro
	   end
END

GO
/****** Object:  StoredProcedure [dbo].[SIGC_FER_SP_rManTabProv]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_FER_SP_rManTabProv]
	-- Add the parameters for the stored procedure here
	@psOpc nvarchar(1), 
	@piPro integer, 
	@piEmp integer, 
	@psDoc nvarchar(30), 
	@psNom nvarchar(200), 
	@psDir nvarchar(200), 
	@psTel nvarchar(100), 
	@psEma nvarchar(100), 
	@psEst nvarchar(1) 
AS
DECLARE @liSec integer;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Insert statements for procedure here
	if @psOpc = 'A'
	   begin
	      select @liSec = isnull(MAX(PROV_ID),0)+1 from SIGC_FER_PROVEEDOR where EMP_ID = @piEmp
	      INSERT INTO SIGC_FER_PROVEEDOR (PROV_ID, EMP_ID, PROV_NRODOC, PROV_RAZSOC, PROV_DIRECCION, PROV_TELEFONO, PROV_EMAIL, PROV_EST)
		  VALUES(@liSec, @piEmp, @psDoc, @psNom, @psDir, @psTel, @psEma, @psEst)
	   end

	-- editfering with SELECT statements.
	if @psOpc = 'M'
	   begin
	      UPDATE SIGC_FER_PROVEEDOR
		     set EMP_ID = @piEmp, 
				 PROV_NRODOC = @psDoc, 
				 PROV_RAZSOC = @psNom, 
				 PROV_DIRECCION = @psDir, 
				 PROV_TELEFONO = @psTel, 
				 PROV_EMAIL = @psEma, 
				 PROV_EST = @psEst
		   where PROV_ID = @piPro
	   end

	-- delfering with SELECT statements.
	if @psOpc = 'E'
	   begin
	      UPDATE SIGC_FER_PROVEEDOR
		     set PROV_EST = @psEst
		   where PROV_ID = @piPro
	   end
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_FER_SP_rManTabUniMed]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_FER_SP_rManTabUniMed]
	-- Add the parameters for the stored procedure here
	@psOpc nvarchar(1), 
	@piUni integer, 
	@piEmp integer, 
	@psDes nvarchar(30), 
	@psEst nvarchar(1) 
AS
DECLARE @liSec integer;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Insert statements for procedure here
	if @psOpc = 'A'
	   begin
	      select @liSec = isnull(MAX(UNIMED_ID),0)+1 from SIGC_FER_UNIMED where EMP_ID = @piEmp
	      INSERT INTO SIGC_FER_UNIMED (UNIMED_ID, EMP_ID, UNIMED_DESC, UNIMED_EST)
		  VALUES(@liSec, @piEmp, @psDes, @psEst)
	   end

	-- editfering with SELECT statements.
	if @psOpc = 'M'
	   begin
	      UPDATE SIGC_FER_UNIMED
		     set EMP_ID = @piEmp, 
			     UNIMED_DESC = @psdes, 
				 UNIMED_EST = @psEst
		   where UNIMED_ID = @piUni
	   end

	-- delfering with SELECT statements.
	if @psOpc = 'E'
	   begin
	      UPDATE SIGC_FER_UNIMED
		     set UNIMED_EST = @psEst
		   where UNIMED_ID = @piUni
	   end
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_FER_SP_rManVtasCab]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_FER_SP_rManVtasCab]
	-- Add the parameters for the stored procedure here
	@psOpc nvarchar(1), 
	@piCab integer, 
	@piEmp integer, 
	@piCli integer, 
	@piTipDoc integer, 
	@psSerDoc nvarchar(5), 
	@psNumDoc nvarchar(10), 
	@psFecEmi char(8), 
	@psFecEnt char(8), 
	@psFecAnu char(8), 
	@pnValVta numeric(15,5), 
	@pnValIgv numeric(15,5), 
	@pnValTot numeric(15,5), 
	@psEst nvarchar(1) 
AS
DECLARE @liSec integer;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Insert statements for procedure here
	if @psOpc = 'A'
	   begin
	      select @liSec = isnull(MAX(CLI_ID),0)+1 from SIGC_FER_VTASCAB where EMP_ID = @piEmp
	      INSERT INTO SIGC_FER_VTASCAB (VCAB_ID, EMP_ID, CLI_ID, TDOC_ID, VCAB_SER, VCAB_NUM, VCAB_FECEMI, VCAB_FECENT, VCAB_FECANU, VCAB_VALVTA, VCAB_VALIGV, VCAB_VALTOT, VCAB_EST)
		  VALUES(@liSec, @piEmp, @piCli, @piTipDoc, @piTipDoc, @psNumDoc, @psFecEmi, @psFecEnt, @psFecAnu, @pnValVta, @pnValIgv, @pnValTot, @psEst)
	   end

	-- editfering with SELECT statements.
	if @psOpc = 'M'
	   begin
	      UPDATE SIGC_FER_VTASCAB
		     set EMP_ID = @piEmp, 
			     CLI_ID = @piCli, 
				 TDOC_ID = @piTipDoc, 
				 VCAB_SER = @piTipDoc, 
				 VCAB_NUM = @psNumDoc, 
				 VCAB_FECEMI = @psFecEmi, 
				 VCAB_FECENT = @psFecEnt, 
				 VCAB_FECANU = @psFecAnu, 
				 VCAB_VALVTA = @pnValVta, 
				 VCAB_VALIGV = @pnValIgv, 
				 VCAB_VALTOT = @pnValTot, 
				 VCAB_EST = @psEst
		   where VCAB_ID = @piCab
	   end

	-- delfering with SELECT statements.
	if @psOpc = 'E'
	   begin
	      UPDATE SIGC_FER_VTASCAB
		     set VCAB_EST = @psEst
		   where VCAB_ID = @piCab
	   end
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_FER_SP_rManVtasDet]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_FER_SP_rManVtasDet]
	-- Add the parameters for the stored procedure here
	@psOpc nvarchar(1), 
	@piDet integer, 
	@piSec integer, 
	@piEmp integer, 
	@piPrd integer, 
	@piCab integer, 
	@pnPrecio numeric(15,5), 
	@pnCantid numeric(15,5), 
	@pnValVta numeric(15,5), 
	@pnValIgv numeric(15,5), 
	@pnValTot numeric(15,5), 
	@psEst nvarchar(1) 
AS
DECLARE @liSec integer;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	    -- Insert statements for procedure here
	if @psOpc = 'A'
	   begin
	      select @liSec = isnull(MAX(VDET_ID),0)+1 from SIGC_FER_VTASDET where EMP_ID = @piEmp
	      INSERT INTO SIGC_FER_VTASDET (VDET_ID, VDET_SEC, EMP_ID, PROD_ID, VCAB_ID, VDET_PRECIO, VDET_CAN, VDET_VALVTA, VDET_VALIGV, VDET_VALTOT, VDET_EST)
		  VALUES(@liSec, @piSec, @piEmp, @piPrd, @piCab, @pnPrecio, @pnCantid, @pnValVta, @pnValIgv, @pnValTot, @psEst)
	   end

	-- editfering with SELECT statements.
	if @psOpc = 'M'
	   begin
	      UPDATE SIGC_FER_VTASDET
		     set EMP_ID = @piEmp, 
			     PROD_ID = VCAB_ID, 
				 VDET_PRECIO = @pnPrecio, 
				 VDET_CAN = @pnCantid, 
				 VDET_VALVTA = @pnValVta, 
				 VDET_VALIGV = @pnValIgv, 
				 VDET_VALTOT = @pnValTot, 
				 VDET_EST = @psEst
		   where VDET_ID = @piCab AND VDET_SEC = @piSec
	   end

	-- delfering with SELECT statements.
	if @psOpc = 'E'
	   begin
	      UPDATE SIGC_FER_VTASDET
		     set VDET_EST = @psEst
		   where VDET_ID = @piCab AND VDET_SEC = @piSec
	   end
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarCateg]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarCateg]
	-- Add the parameters for the stored procedure here
	@piEmpr integer,
	@psOpc char(1) = 'L'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @psOpc = 'L'
	BEGIN
		SELECT CATEG_ID, EMP_ID, CATEG_DESC, CATEG_EST,
			   CATEG_DEST =  (CASE CATEG_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_CATEGORIA
		 WHERE emp_id = @piEmpr
    END

	IF @psOpc = 'C'
	BEGIN
		SELECT Código = CATEG_ID, Descripción = CATEG_DESC, 
			   Estado = (CASE CATEG_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_CATEGORIA
		 WHERE emp_id = @piEmpr
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarClientes]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarClientes]
	-- Add the parameters for the stored procedure here
	@piEmpr integer,
	@psOpc char(1)  = 'L',
	@psDoc char(12) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @psOpc = 'L'
	BEGIN
		SELECT EMP_ID, CLI_ID, CLI_TIPO, 
			   CLI_DTIP =  (CASE CLI_TIPO WHEN 'N' THEN 'Natural' WHEN 'J' THEN 'Juridica' ELSE 'Sin Tipo' END),  
			   CLI_NRODOC, CLI_NOMBRE, CLI_DIRECCION, CLI_TELEFONO, CLI_EMAIL, CLI_EST, 
			   CLI_DEST =  (CASE CLI_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_CLIENTES 
		 WHERE emp_id = @piEmpr
	END

	IF @psOpc = 'D'  -- Ayuda Busca un solo cliente por nrodoc
	BEGIN
		SELECT EMP_ID, CLI_ID, CLI_TIPO, 
			   CLI_DTIP =  (CASE CLI_TIPO WHEN 'N' THEN 'Natural' WHEN 'J' THEN 'Juridica' ELSE 'Sin Tipo' END),  
			   CLI_NRODOC, CLI_NOMBRE, CLI_DIRECCION, CLI_TELEFONO, CLI_EMAIL, CLI_EST, 
			   CLI_DEST =  (CASE CLI_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_CLIENTES 
		 WHERE emp_id = @piEmpr and CLI_NRODOC =  @psDoc
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarEmpresas]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarEmpresas]
	-- Add the parameters for the stored procedure here
	@psOpc char(1) = 'L'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @psOpc = 'L'
	BEGIN
		SELECT codigo=EMP_ID, descripcion=EMP_DESC, EMP_EST,
			   EMP_DEST = (CASE EMP_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_EMPRESA
    END

	IF @psOpc = 'C'
	BEGIN
		SELECT codigo=EMP_ID, descripcion=EMP_DESC, EMP_EST,
			   EMP_DEST = (CASE EMP_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_EMPRESA
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarProductos]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarProductos]
	-- Add the parameters for the stored procedure here
	@piEmpr integer,
	@psOpc  char(1)  = 'L',
	@piProd integer = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @psOpc = 'L'
	BEGIN
		SELECT P.PROD_ID, P.EMP_ID, P.CATEG_ID, C.CATEG_DESC, P.UNIMED_ID, U.UNIMED_DESC, P.PROD_DESC, P.PROD_PRECIO, P.PROD_STOCK, P.PROD_STOCKMIN, P.PROD_EST,
			   PROD_DEST =  (CASE P.PROD_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_PRODUCTO P
		  INNER JOIN SIGC_FER_CATEGORIA C on C.EMP_ID = P.EMP_ID and C.CATEG_ID = P.CATEG_ID
		  INNER JOIN SIGC_FER_UNIMED U on U.EMP_ID = P.EMP_ID and U.UNIMED_ID = P.UNIMED_ID
		 WHERE P.emp_id = @piEmpr
	END

	IF @psOpc = 'D'  -- Ayuda Busca un solo producto
	BEGIN
		SELECT P.PROD_ID, P.EMP_ID, P.CATEG_ID, C.CATEG_DESC, P.UNIMED_ID, U.UNIMED_DESC, P.PROD_DESC, P.PROD_PRECIO, P.PROD_STOCK, P.PROD_STOCKMIN, P.PROD_EST,
			   PROD_DEST =  (CASE P.PROD_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_PRODUCTO P
		  INNER JOIN SIGC_FER_CATEGORIA C on C.EMP_ID = P.EMP_ID and C.CATEG_ID = P.CATEG_ID
		  INNER JOIN SIGC_FER_UNIMED U on U.EMP_ID = P.EMP_ID and U.UNIMED_ID = P.UNIMED_ID
		 WHERE P.emp_id = @piEmpr  and P.PROD_ID = @piProd
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarProveedores]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarProveedores]
	-- Add the parameters for the stored procedure here
	@piEmpr integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT PROV_ID, EMP_ID, PROV_NRODOC, PROV_RAZSOC, PROV_DIRECCION, PROV_TELEFONO, PROV_EMAIL, PROV_EST,
	       PROV_DEST =  (CASE PROV_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
	  from SIGC_FER_PROVEEDOR
	 WHERE emp_id = @piEmpr
END

GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarUniMed]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarUniMed]
	-- Add the parameters for the stored procedure here
	@piEmpr integer,
	@psOpc char(1) = 'L'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @psOpc = 'L'
	BEGIN
		SELECT UNIMED_ID, EMP_ID, UNIMED_DESC, UNIMED_EST,
			   UNIMED_DEST = (CASE UNIMED_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_UNIMED
		 WHERE emp_id = @piEmpr
    END

	IF @psOpc = 'C' -- ComboBox
	BEGIN
		SELECT Código = UNIMED_ID, Descripción = UNIMED_DESC, 
			   Estado = (CASE UNIMED_EST WHEN 'A' THEN 'Activo' WHEN 'I' THEN 'Inactivo' ELSE 'Sin Estado' END)  
		  from SIGC_FER_UNIMED
		 WHERE emp_id = @piEmpr
    END
END

GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarVtasCab]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarVtasCab]
	-- Add the parameters for the stored procedure here
	@piEmpr integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT C.VCAB_ID, C.EMP_ID, C.TDOC_ID, T.TDOC_ABREV, C.VCAB_SER, C.VCAB_NUM, C.VCAB_FECEMI, C.VCAB_FECENT, C.VCAB_FECANU, C.CLI_ID, 
	       C.VCAB_VALVTA, C.VCAB_VALIGV, C.VCAB_VALTOT
      from SIGC_FER_VTASCAB C
      inner join SIGC_FER_TIPODOC T ON C.TDOC_ID= T.TDOC_ID
	 WHERE emp_id = @piEmpr
END
GO
/****** Object:  StoredProcedure [dbo].[SIGC_SP_FER_ListarVtasDet]    Script Date: 26/02/2018 8:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SIGC_SP_FER_ListarVtasDet]
	-- Add the parameters for the stored procedure here
	@piEmpr integer,
	@piCab integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select D.VDET_ID, D.VDET_SEC, D.VCAB_ID, D.EMP_ID, D.PROD_ID, P.PROD_DESC, D.VDET_PRECIO, 
	       D.VDET_CAN, D.VDET_VALVTA, D.VDET_VALIGV, D.VDET_VALTOT, D.VDET_VALEST
		from SIGC_FER_VTASDET D
		INNER JOIN SIGC_FER_PRODUCTO P ON D.EMP_ID = D.EMP_ID and D.PROD_ID = P.PROD_ID
		where D.EMP_ID = @piEmpr AND D.VCAB_ID = @piCab
END
GO
