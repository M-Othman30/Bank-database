/****** Script for SelectTopNRows command from SSMS  ******/
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK') and o.name = 'ADMIN_ADDS_BANK')
alter table BANK
   drop constraint ADMIN_ADDS_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK_ACCOUNT') and o.name = 'CUSTOMER_HAS_BANK_ACCOUNT')
alter table BANK_ACCOUNT
   drop constraint CUSTOMER_HAS_BANK_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK_ACCOUNT') and o.name = 'BRANCH_MAKES_BANK_ACCOUNT')
alter table BANK_ACCOUNT
   drop constraint BRANCH_MAKES_BANK_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'ADMIN_ALSO_ADDS_BRANCH')
alter table BRANCH
   drop constraint ADMIN_ALSO_ADDS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'BANK_OWNS_BRANCH')
alter table BRANCH
   drop constraint BANK_OWNS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'BRANCH_HIRE_EMPLOYEE')
alter table EMPLOYEE
   drop constraint BRANCH_HIRE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'EMPLOYEE_ACCEPTS/REJECTS_LOANS')
alter table LOAN
   drop constraint "EMPLOYEE_ACCEPTS/REJECTS_LOANS"
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'BRANCH_OFFERS_LOAN')
alter table LOAN
   drop constraint BRANCH_OFFERS_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'CUSTOMER_REQUESTS/PAYS_LOAN')
alter table LOAN
   drop constraint "CUSTOMER_REQUESTS/PAYS_LOAN"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK')
            and   name  = 'ADDS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK.ADDS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK_ACCOUNT')
            and   name  = 'MAKES_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK_ACCOUNT.MAKES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK_ACCOUNT')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK_ACCOUNT.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK_ACCOUNT')
            and   type = 'U')
   drop table BANK_ACCOUNT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'ALSO_ADDS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.ALSO_ADDS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'OWNS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.OWNS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'HIRE_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.HIRE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'REQUEST_PAY_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.REQUEST_PAY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'OFFERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.OFFERS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'ACCEPTS_REJECTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.ACCEPTS_REJECTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMIN_USER_NAME      varchar(200)         not null,
   ADMIN_NAME           varchar(200)         not null,
   ADMIN_PASSWORD       varchar(200)         not null,
   ADMIN_ID             numeric              not null,
   constraint PK_ADMIN primary key (ADMIN_ID)
)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   BANK_NAME            varchar(200)         not null,
   BANK_ADDRESS         varchar(200)         not null,
   BANK_CODE            varchar(200)         not null,
   ADMIN_ID             numeric              not null,
   constraint PK_BANK primary key (BANK_CODE)
)
go

/*==============================================================*/
/* Index: ADDS_FK                                               */
/*==============================================================*/




create nonclustered index ADDS_FK on BANK (ADMIN_ID ASC)
go

/*==============================================================*/
/* Table: BANK_ACCOUNT                                          */
/*==============================================================*/
create table BANK_ACCOUNT (
   ACCOUNT_NO           numeric              not null,
   BRANCH_NO            numeric              not null,
   SSN                  numeric              not null,
   BALANCE              money                not null,
   TYPE                 varchar(200)         not null,
   constraint PK_BANK_ACCOUNT primary key (ACCOUNT_NO)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on BANK_ACCOUNT (SSN ASC)
go

/*==============================================================*/
/* Index: MAKES_FK                                              */
/*==============================================================*/




create nonclustered index MAKES_FK on BANK_ACCOUNT (BRANCH_NO ASC)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCH_NO            numeric              not null,
   BANK_CODE            varchar(200)         not null,
   ADMIN_ID             numeric              not null,
   BRANCH_ADDRESS       varchar(200)         not null,
   constraint PK_BRANCH primary key (BRANCH_NO)
)
go

/*==============================================================*/
/* Index: OWNS_FK                                               */
/*==============================================================*/




create nonclustered index OWNS_FK on BRANCH (BANK_CODE ASC)
go

/*==============================================================*/
/* Index: ALSO_ADDS_FK                                          */
/*==============================================================*/




create nonclustered index ALSO_ADDS_FK on BRANCH (ADMIN_ID ASC)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CUSTOMER_NAME        varchar(200)         not null,
   SSN                  numeric              not null,
   CUSTOMER_EMAIL       varchar(200)         not null,
   CUSTOMER_PHONE       numeric              not null,
   CUSTOMER_ADDRESS     varchar(1024)        not null,
   constraint PK_CUSTOMER primary key (SSN)
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMPLOYEE_ID          numeric              not null,
   BRANCH_NO            numeric              not null,
   EMPLOYEE_NAME        varchar(200)         not null,
   EMPLOYEE_USER_NAME   varchar(200)         not null,
   EMPLOYEE_PASSWORD    varchar(200)         not null,
   constraint PK_EMPLOYEE primary key (EMPLOYEE_ID)
)
go

/*==============================================================*/
/* Index: HIRE_FK                                               */
/*==============================================================*/




create nonclustered index HIRE_FK on EMPLOYEE (BRANCH_NO ASC)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOAN_NO              numeric              not null,
   BRANCH_NO            numeric              not null,
   EMPLOYEE_ID          numeric              not null,
   SSN                  numeric              not null,
   LOAN_AMOUNT          money                not null,
   LOAN_TYPE            varchar(200)         not null,
   LOAN_STATUS          varchar(200)         not null,
   constraint PK_LOAN primary key (LOAN_NO)
)
go

/*==============================================================*/
/* Index: ACCEPTS_REJECTS_FK                                    */
/*==============================================================*/




create nonclustered index ACCEPTS_REJECTS_FK on LOAN (EMPLOYEE_ID ASC)
go

/*==============================================================*/
/* Index: OFFERS_FK                                             */
/*==============================================================*/




create nonclustered index OFFERS_FK on LOAN (BRANCH_NO ASC)
go

/*==============================================================*/
/* Index: REQUEST_PAY_FK                                        */
/*==============================================================*/




create nonclustered index REQUEST_PAY_FK on LOAN (SSN ASC)
go

alter table BANK
   add constraint ADMIN_ADDS_BANK foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table BANK_ACCOUNT
   add constraint CUSTOMER_HAS_BANK_ACCOUNT foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BANK_ACCOUNT
   add constraint BRANCH_MAKES_BANK_ACCOUNT foreign key (BRANCH_NO)
      references BRANCH (BRANCH_NO)
go

alter table BRANCH
   add constraint ADMIN_ALSO_ADDS_BRANCH foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table BRANCH
   add constraint BANK_OWNS_BRANCH foreign key (BANK_CODE)
      references BANK (BANK_CODE)
go

alter table EMPLOYEE
   add constraint BRANCH_HIRE_EMPLOYEE foreign key (BRANCH_NO)
      references BRANCH (BRANCH_NO)
go

alter table LOAN
   add constraint "EMPLOYEE_ACCEPTS/REJECTS_LOANS" foreign key (EMPLOYEE_ID)
      references EMPLOYEE (EMPLOYEE_ID)
go

alter table LOAN
   add constraint BRANCH_OFFERS_LOAN foreign key (BRANCH_NO)
      references BRANCH (BRANCH_NO)
go

alter table LOAN
   add constraint "CUSTOMER_REQUESTS/PAYS_LOAN" foreign key (SSN)
      references CUSTOMER (SSN)
go

select b.branch_no , branch_address
from branch B left outer join bank_account BA
on B.branch_no=BA.branch_no full outer join customer c 
on c.ssn = BA.ssn
where customer_name is null;

select b.branch_no , branch_address
from branch B left outer join employee E
on B.branch_no = e.branch_no 
where employee_name is null ;

select employee_name
from employee E inner join loan L
on E.employee_id=L.employee_id
where loan_no in(select max(loan_no) from loan);




select customer_name 
from customer c inner join loan l
on c.ssn = l.ssn
where LOAN_NO in (select max(loan_no) from loan);


select customer_name 
from customer c left outer join loan l
on c.ssn = l.ssn
where LOAN_NO is null;


select CUSTOMER.CUSTOMER_NAME,CUSTOMER.SSN,CUSTOMER.CUSTOMER_EMAIL,CUSTOMER.CUSTOMER_PHONE,CUSTOMER.CUSTOMER_ADDRESS,(select count(*)
from [dbo].[CUSTOMER],[dbo].[LOAN]
where CUSTOMER.SSN = LOAN.SSN ) as Number_Of_Employees
from [dbo].[CUSTOMER]
