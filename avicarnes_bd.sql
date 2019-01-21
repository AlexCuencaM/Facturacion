--------------------------------------------------------
-- Archivo creado  - domingo-enero-20-2019   
--------------------------------------------------------
--By Alex Cuenca Morán, Guayaquil Ecuador
--------------------------------------------------------
--  DDL for Table CLIENTE
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."CLIENTE" 
   (	"ID_CLIENTE" NUMBER, 
	"NOMBRE" VARCHAR2(100 BYTE), 
	"ESTADO" NUMBER, 
	"DIRECCION" VARCHAR2(100 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DATOS_EMPRESA
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."DATOS_EMPRESA" 
   (	"ID_DATOS_EMPRESA" NUMBER, 
	"TELEFONO" VARCHAR2(10 BYTE), 
	"ID_SUCURSAL" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DATOS_USUARIO
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."DATOS_USUARIO" 
   (	"ID_DATOS_USUARIO" NUMBER, 
	"TELEFONO" VARCHAR2(10 BYTE), 
	"ID_CLIENTE" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DETALLE_FACTURA
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."DETALLE_FACTURA" 
   (	"ID_DETALLE_FACTURA" NUMBER, 
	"ID_FACTURA" NUMBER, 
	"ID_PRODUCTO" NUMBER, 
	"CANTIDAD" NUMBER, 
	"PESO" NUMBER, 
	"PORCENTAJE_DESCUENTO" NUMBER, 
	"TOTAL" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table EMPRESA
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."EMPRESA" 
   (	"ID_EMPRESA" NUMBER, 
	"DESCRIPCION" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table ESTADO_ACTIVIDAD
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."ESTADO_ACTIVIDAD" 
   (	"ID_ESTADO" NUMBER, 
	"DESCRIPCION" VARCHAR2(15 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table FACTURA
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."FACTURA" 
   (	"ID_FACTURA" NUMBER, 
	"FECHA" DATE, 
	"ID_DATOS_USUARIO" NUMBER, 
	"ID_DATOS_EMPRESA" NUMBER, 
	"FORMA_PAGO" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table FORMA_PAGO
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."FORMA_PAGO" 
   (	"ID_FORMA_PAGO" NUMBER, 
	"DESCRIPCION" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table PRODUCTO
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."PRODUCTO" 
   (	"ID_PRODUCTO" NUMBER, 
	"DESCRIPCION" VARCHAR2(100 BYTE), 
	"PRECIO" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table SUCURSAL
--------------------------------------------------------

  CREATE TABLE "ADMINISTRADOR"."SUCURSAL" 
   (	"ID_SUCURSAL" NUMBER, 
	"ID_EMPRESA" NUMBER, 
	"DIRECCION" VARCHAR2(100 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into ADMINISTRADOR.CLIENTE
SET DEFINE OFF;
Insert into ADMINISTRADOR.CLIENTE (ID_CLIENTE,NOMBRE,ESTADO,DIRECCION) values ('1','ALEX','1','FLOR DE BASTION');
Insert into ADMINISTRADOR.CLIENTE (ID_CLIENTE,NOMBRE,ESTADO,DIRECCION) values ('2','MAX','1','FLOR DE BASTION');
Insert into ADMINISTRADOR.CLIENTE (ID_CLIENTE,NOMBRE,ESTADO,DIRECCION) values ('3','MARIA','1','WASMO');
Insert into ADMINISTRADOR.CLIENTE (ID_CLIENTE,NOMBRE,ESTADO,DIRECCION) values ('4','MARIA','1','WASMO');
Insert into ADMINISTRADOR.CLIENTE (ID_CLIENTE,NOMBRE,ESTADO,DIRECCION) values ('5','MARIA','1','WASMO NORTE');
REM INSERTING into ADMINISTRADOR.DATOS_EMPRESA
SET DEFINE OFF;
Insert into ADMINISTRADOR.DATOS_EMPRESA (ID_DATOS_EMPRESA,TELEFONO,ID_SUCURSAL) values ('1','0994896164','1');
Insert into ADMINISTRADOR.DATOS_EMPRESA (ID_DATOS_EMPRESA,TELEFONO,ID_SUCURSAL) values ('2','0984072583','1');
Insert into ADMINISTRADOR.DATOS_EMPRESA (ID_DATOS_EMPRESA,TELEFONO,ID_SUCURSAL) values ('3','0960175729','1');
REM INSERTING into ADMINISTRADOR.DATOS_USUARIO
SET DEFINE OFF;
Insert into ADMINISTRADOR.DATOS_USUARIO (ID_DATOS_USUARIO,TELEFONO,ID_CLIENTE) values ('1','0987463147','1');
Insert into ADMINISTRADOR.DATOS_USUARIO (ID_DATOS_USUARIO,TELEFONO,ID_CLIENTE) values ('2','0987990047','1');
REM INSERTING into ADMINISTRADOR.DETALLE_FACTURA
SET DEFINE OFF;
Insert into ADMINISTRADOR.DETALLE_FACTURA (ID_DETALLE_FACTURA,ID_FACTURA,ID_PRODUCTO,CANTIDAD,PESO,PORCENTAJE_DESCUENTO,TOTAL) values ('1',null,null,null,null,null,null);
Insert into ADMINISTRADOR.DETALLE_FACTURA (ID_DETALLE_FACTURA,ID_FACTURA,ID_PRODUCTO,CANTIDAD,PESO,PORCENTAJE_DESCUENTO,TOTAL) values ('2',null,null,null,null,null,null);
REM INSERTING into ADMINISTRADOR.EMPRESA
SET DEFINE OFF;
Insert into ADMINISTRADOR.EMPRESA (ID_EMPRESA,DESCRIPCION) values ('1','AVICARNES JOSDYLKEY');
REM INSERTING into ADMINISTRADOR.ESTADO_ACTIVIDAD
SET DEFINE OFF;
Insert into ADMINISTRADOR.ESTADO_ACTIVIDAD (ID_ESTADO,DESCRIPCION) values ('1','CONTADO');
REM INSERTING into ADMINISTRADOR.FACTURA
SET DEFINE OFF;
REM INSERTING into ADMINISTRADOR.FORMA_PAGO
SET DEFINE OFF;
REM INSERTING into ADMINISTRADOR.PRODUCTO
SET DEFINE OFF;
Insert into ADMINISTRADOR.PRODUCTO (ID_PRODUCTO,DESCRIPCION,PRECIO) values ('1','1/4 de POSHO XD','1,82');
Insert into ADMINISTRADOR.PRODUCTO (ID_PRODUCTO,DESCRIPCION,PRECIO) values ('2','MENUDENCIA DE POSHO','0,5');
REM INSERTING into ADMINISTRADOR.SUCURSAL
SET DEFINE OFF;
Insert into ADMINISTRADOR.SUCURSAL (ID_SUCURSAL,ID_EMPRESA,DIRECCION) values ('1','1','GUASMO SUR COOP. STAND FRUIT');
--------------------------------------------------------
--  DDL for Index DETALLE_FACTURA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."DETALLE_FACTURA_PK" ON "ADMINISTRADOR"."DETALLE_FACTURA" ("ID_DETALLE_FACTURA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SUCURSAL_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."SUCURSAL_PK" ON "ADMINISTRADOR"."SUCURSAL" ("ID_SUCURSAL") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index CLIENTE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."CLIENTE_PK" ON "ADMINISTRADOR"."CLIENTE" ("ID_CLIENTE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index FACTURA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."FACTURA_PK" ON "ADMINISTRADOR"."FACTURA" ("ID_FACTURA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index FORMA_PAGO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."FORMA_PAGO_PK" ON "ADMINISTRADOR"."FORMA_PAGO" ("ID_FORMA_PAGO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index ESTADO_ACTIVIDAD_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."ESTADO_ACTIVIDAD_PK" ON "ADMINISTRADOR"."ESTADO_ACTIVIDAD" ("ID_ESTADO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index DATOS_EMPRESA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."DATOS_EMPRESA_PK" ON "ADMINISTRADOR"."DATOS_EMPRESA" ("ID_DATOS_EMPRESA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index NOMBRE_CLIENTE_INDEX
--------------------------------------------------------

  CREATE INDEX "ADMINISTRADOR"."NOMBRE_CLIENTE_INDEX" ON "ADMINISTRADOR"."CLIENTE" ("NOMBRE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index EMPRESA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."EMPRESA_PK" ON "ADMINISTRADOR"."EMPRESA" ("ID_EMPRESA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index PRODUCTO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."PRODUCTO_PK" ON "ADMINISTRADOR"."PRODUCTO" ("ID_PRODUCTO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index DATOS_USUARIO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ADMINISTRADOR"."DATOS_USUARIO_PK" ON "ADMINISTRADOR"."DATOS_USUARIO" ("ID_DATOS_USUARIO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Package DATOS_EMPRESA_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE "ADMINISTRADOR"."DATOS_EMPRESA_PK" as
    function selectEmpresa return SYS_REFCURSOR;
    function selectTelefonoEmpresa return sys_refcursor;
end datos_empresa_pk;

/
--------------------------------------------------------
--  DDL for Package FACTURA_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE "ADMINISTRADOR"."FACTURA_PK" as
    function selectHeader return sys_refcursor;
    function sumar_detalle_facturas return number;
    procedure insert_detalle_facturas(pn_id_factura number, pn_id_producto number, 
                                    cantidad number, peso number, descuento number,pn_total number);
    function sacar_id_datos_usuario(pn_id_cliente number, pv_nombre_cliente varchar2) return number;
    procedure insertar_Factura(pn_id_factura number,pv_fecha varchar2, pn_id_cliente number, pv_nombre_cliente varchar2); 

end factura_pk;

/
--------------------------------------------------------
--  DDL for Package OPERACIONES_CLIENTE_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE "ADMINISTRADOR"."OPERACIONES_CLIENTE_PK" as
    function selectCliente(pn_id number DEFAULT 0, pv_nombre varchar2) return SYS_REFCURSOR;
    function selectTelefonoCliente(pn_id_cliente number DEFAULT 0, pv_nombre varchar2)return sys_refcursor;
end operaciones_cliente_pk;

/
--------------------------------------------------------
--  DDL for Package OPERACIONES_PRODUCTO_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE "ADMINISTRADOR"."OPERACIONES_PRODUCTO_PK" as
    function select_Producto(pn_id number Default 0) return sys_refcursor;
    function subtotal(pn_peso number default 1, pn_precio number default 0) return sys_refcursor;
    function total (pn_descuento number default 0, pn_subtotal number default 0) return sys_refcursor;
end operaciones_producto_pk;

/
--------------------------------------------------------
--  DDL for Package Body DATOS_EMPRESA_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE BODY "ADMINISTRADOR"."DATOS_EMPRESA_PK" as
    function selectEmpresa return sys_refcursor
    is 
    r_select sys_refcursor;
    begin
        open r_select for select e.descripcion, s.direccion
                            from sucursal S
                            inner join Empresa e on s.id_empresa = E.id_empresa
                            where s.id_sucursal = 1;
        return r_select;
   end selectEmpresa;

   function selectTelefonoEmpresa return sys_refcursor
   is
   r_select sys_refcursor;
   begin
    open r_select for select D.telefono as Telefono
                        from Datos_Empresa D
                        inner join Sucursal S on s.id_sucursal = d.id_sucursal
                        where d.id_sucursal = 1 and rownum <= 5;
    return r_select;
    end selectTelefonoEmpresa;

end datos_empresa_pk;

/
--------------------------------------------------------
--  DDL for Package Body FACTURA_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE BODY "ADMINISTRADOR"."FACTURA_PK" as
    function selectHeader return sys_refcursor
    is
    r_select sys_refcursor;
    begin
        open r_select for select NVL( MAX(id_factura + 1), 1), to_char(SysDATE, 'DD/MM/YYYY')
                            from factura where rownum <=1 and id_factura = (select NVL( (MAX(id_factura)), 1)
                            from factura);
                            
    return r_select;
    end selectHeader; 
    
    function sumar_detalle_facturas return number
    is
    ln_detalle detalle_factura.id_detalle_factura %type;
    begin
        select NVL(MAX(id_detalle_factura + 1), 1) into ln_detalle
                            from detalle_factura 
                            where id_detalle_factura = (select NVL( (MAX(id_detalle_factura)), 1) from detalle_factura);    
    return ln_detalle;
    exception
    when no_data_found then
        return 0;
    end sumar_detalle_facturas;
    
    procedure insert_detalle_facturas(pn_id_factura number, pn_id_producto number, 
                                    cantidad number, peso number, descuento number,pn_total number) 
    is
        ln_detalle_factura detalle_factura.id_detalle_factura %type;
    begin
        ln_detalle_factura := factura_pk.sumar_detalle_facturas();
        insert into detalle_factura 
            values(ln_detalle_factura, pn_id_factura, pn_id_producto,cantidad,peso,descuento,pn_total);
    
    end insert_detalle_facturas;        
    
    function sacar_id_datos_usuario(pn_id_cliente number, pv_nombre_cliente varchar2) return number
    is
    ln_id_usuarios datos_usuario.id_datos_usuario %type;
    begin
        select d.id_datos_usuario into ln_id_usuarios
                    from Datos_Usuario d 
                    inner join cliente c on d.id_cliente = c.id_cliente 
                    where  c.id_cliente = pn_id_cliente and pv_nombre_cliente = c.nombre;
    return ln_id_usuarios;    
    exception
    when no_data_found then
        return 0;
    end sacar_id_datos_usuario;
    
    procedure insertar_Factura(pn_id_factura number,pv_fecha varchar2, pn_id_cliente number, pv_nombre_cliente varchar2)
    is
    ln_id_usuarios datos_usuario.id_datos_usuario %type;
    begin
        ln_id_usuarios := sacar_id_datos_usuario(pn_id_cliente,pv_nombre_cliente);
        insert into factura values(pn_id_factura,to_date(pv_fecha, 'dd/mm/yyyy'),ln_id_usuarios,1,1);
    end insertar_factura;
end factura_pk;

/
--------------------------------------------------------
--  DDL for Package Body OPERACIONES_CLIENTE_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE BODY "ADMINISTRADOR"."OPERACIONES_CLIENTE_PK" as
    function selectCliente(pn_id number DEFAULT 0, pv_nombre varchar2) return sys_refcursor
    is 
    r_select sys_refcursor;
    begin
        open r_select for select C.id_cliente as "N Cliente",C.nombre as "Nombre", C.direccion, NVL(e.descripcion, 'NA')
                            from cliente C inner join estado_actividad e on e.id_estado = c.estado
                            where (C.id_cliente = pn_id or upper(pv_nombre) = C.nombre) and rownum <= 1;
        return r_select;
   end selectCliente;

   function selectTelefonoCliente(pn_id_cliente number default 0, pv_nombre varchar2) return sys_refcursor
   is
   r_select sys_refcursor;
   begin
    open r_select for select D.telefono as Telefono
                        from Datos_Usuario D
                        inner join Cliente C on D.id_cliente = C.id_cliente
                        where (D.id_Cliente = pn_id_cliente or upper(pv_nombre) =  C.nombre)  and rownum <= 4;
    return r_select;
    end selectTelefonoCliente;

end operaciones_cliente_pk;

/
--------------------------------------------------------
--  DDL for Package Body OPERACIONES_PRODUCTO_PK
--------------------------------------------------------

  CREATE OR REPLACE PACKAGE BODY "ADMINISTRADOR"."OPERACIONES_PRODUCTO_PK" as
    function select_Producto(pn_id number Default 0) return sys_refcursor is
    r_cursor sys_refcursor;
    begin
        open r_cursor for select upper(descripcion) as Descripcion, Precio from producto where id_producto = pn_id;
        return r_cursor;
    end select_Producto;
    
    function subtotal(pn_peso number default 1,  pn_precio number default 0) return sys_refcursor is
    pn_total number;
    r_cursor sys_refcursor;
    begin
        pn_total := pn_peso*pn_precio;
        open r_cursor for select pn_total from dual;
    return r_cursor;
    end subtotal;
    
    function total(pn_descuento number default 0, pn_subtotal number default 0) return  sys_refcursor is
    pn_total number;
    pn_descontado number;
    r_cursor sys_refcursor;
    begin
        pn_descontado := (pn_descuento/100)*pn_subtotal;
        pn_total :=pn_subtotal-pn_descontado;
        open r_cursor for select pn_total from dual;
        return r_cursor;
    end total;
end operaciones_producto_pk;

/
--------------------------------------------------------
--  Constraints for Table DETALLE_FACTURA
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."DETALLE_FACTURA" ADD CONSTRAINT "DETALLE_FACTURA_PK" PRIMARY KEY ("ID_DETALLE_FACTURA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table FORMA_PAGO
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."FORMA_PAGO" ADD CONSTRAINT "FORMA_PAGO_PK" PRIMARY KEY ("ID_FORMA_PAGO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table SUCURSAL
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."SUCURSAL" ADD CONSTRAINT "SUCURSAL_PK" PRIMARY KEY ("ID_SUCURSAL")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table FACTURA
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."FACTURA" ADD CONSTRAINT "FACTURA_PK" PRIMARY KEY ("ID_FACTURA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PRODUCTO
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."PRODUCTO" ADD CONSTRAINT "PRODUCTO_PK" PRIMARY KEY ("ID_PRODUCTO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table DATOS_EMPRESA
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."DATOS_EMPRESA" ADD CONSTRAINT "DATOS_EMPRESA_PK" PRIMARY KEY ("ID_DATOS_EMPRESA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table EMPRESA
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."EMPRESA" ADD CONSTRAINT "EMPRESA_PK" PRIMARY KEY ("ID_EMPRESA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CLIENTE
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."CLIENTE" ADD CONSTRAINT "CLIENTE_PK" PRIMARY KEY ("ID_CLIENTE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table DATOS_USUARIO
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."DATOS_USUARIO" ADD CONSTRAINT "DATOS_USUARIO_PK" PRIMARY KEY ("ID_DATOS_USUARIO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table ESTADO_ACTIVIDAD
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."ESTADO_ACTIVIDAD" ADD CONSTRAINT "ESTADO_ACTIVIDAD_PK" PRIMARY KEY ("ID_ESTADO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table CLIENTE
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."CLIENTE" ADD CONSTRAINT "CLIENTE_FK" FOREIGN KEY ("ESTADO")
	  REFERENCES "ADMINISTRADOR"."ESTADO_ACTIVIDAD" ("ID_ESTADO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DATOS_EMPRESA
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."DATOS_EMPRESA" ADD CONSTRAINT "DATOS_EMPRESA_FK" FOREIGN KEY ("ID_SUCURSAL")
	  REFERENCES "ADMINISTRADOR"."SUCURSAL" ("ID_SUCURSAL") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DATOS_USUARIO
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."DATOS_USUARIO" ADD CONSTRAINT "DATOS_USUARIO_FK" FOREIGN KEY ("ID_CLIENTE")
	  REFERENCES "ADMINISTRADOR"."CLIENTE" ("ID_CLIENTE") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DETALLE_FACTURA
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."DETALLE_FACTURA" ADD CONSTRAINT "DETALLE_FACTURA_FK" FOREIGN KEY ("ID_FACTURA")
	  REFERENCES "ADMINISTRADOR"."FACTURA" ("ID_FACTURA") ENABLE;
  ALTER TABLE "ADMINISTRADOR"."DETALLE_FACTURA" ADD CONSTRAINT "DETALLE_FACTURA_FK2" FOREIGN KEY ("ID_PRODUCTO")
	  REFERENCES "ADMINISTRADOR"."PRODUCTO" ("ID_PRODUCTO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FACTURA
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."FACTURA" ADD CONSTRAINT "FACTURA_FK" FOREIGN KEY ("ID_FACTURA")
	  REFERENCES "ADMINISTRADOR"."FACTURA" ("ID_FACTURA") ENABLE;
  ALTER TABLE "ADMINISTRADOR"."FACTURA" ADD CONSTRAINT "FACTURA_FK1" FOREIGN KEY ("ID_DATOS_USUARIO")
	  REFERENCES "ADMINISTRADOR"."DATOS_USUARIO" ("ID_DATOS_USUARIO") ENABLE;
  ALTER TABLE "ADMINISTRADOR"."FACTURA" ADD CONSTRAINT "FACTURA_FK2" FOREIGN KEY ("ID_DATOS_EMPRESA")
	  REFERENCES "ADMINISTRADOR"."DATOS_EMPRESA" ("ID_DATOS_EMPRESA") ENABLE;
  ALTER TABLE "ADMINISTRADOR"."FACTURA" ADD CONSTRAINT "FACTURA_FK3" FOREIGN KEY ("FORMA_PAGO")
	  REFERENCES "ADMINISTRADOR"."FORMA_PAGO" ("ID_FORMA_PAGO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table SUCURSAL
--------------------------------------------------------

  ALTER TABLE "ADMINISTRADOR"."SUCURSAL" ADD CONSTRAINT "SUCURSAL_FK" FOREIGN KEY ("ID_EMPRESA")
	  REFERENCES "ADMINISTRADOR"."EMPRESA" ("ID_EMPRESA") ENABLE;
