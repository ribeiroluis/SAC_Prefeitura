#==============================================================
# DBMS name:      Microsoft Access 2000
# Created on:     20/05/2013 18:20:44
#==============================================================


RemoveJoin C=FK_ACESSOSI_REFERENCE_FUNCIONA T=AcessoSistema P=Funcionario;

RemoveJoin C=FK_DEMANDAS_REFERENCE_TIPODEMA T=Demandas P=TipoDemanda;

RemoveJoin C=FK_FUNCIONA_REFERENCE_SETOR T=Funcionario P=Setor;

RemoveJoin C=FK_TIPODEMA_REFERENCE_SETOR T=TipoDemanda P=Setor;

RemoveJoin C=FK_USUARIOD_REFERENCE_USUARIO T=UsuarioDemanda P=Usuario;

RemoveJoin C=FK_USUARIOD_REFERENCE_DEMANDAS T=UsuarioDemanda P=Demandas;

RemoveIndx C=PrimaryKey T=AcessoSistema;

RemoveTble C=AcessoSistema;

RemoveIndx C=PrimaryKey T=Demandas;

RemoveTble C=Demandas;

RemoveIndx C=PrimaryKey T=Funcionario;

RemoveTble C=Funcionario;

RemoveIndx C=PrimaryKey T=Setor;

RemoveTble C=Setor;

RemoveIndx C=IDSETOR T=TipoDemanda;

RemoveIndx C=PrimaryKey T=TipoDemanda;

RemoveTble C=TipoDemanda;

RemoveIndx C=PrimaryKey T=Usuario;

RemoveTble C=Usuario;

RemoveIndx C=PrimaryKey T=UsuarioDemanda;

RemoveTble C=UsuarioDemanda;

#==============================================================
# Table: AcessoSistema
#==============================================================
CreateTble C=AcessoSistema N="AcessoSistema"
(
   C=Código T="INTEGER" P=Yes M=Yes N="Código" Z=false,
   C=LOGIN T="VARCHAR" P=No M=No N="LOGIN" Z=false,
   C=SENHA T="VARCHAR" P=No M=No N="SENHA" Z=false
);

#==============================================================
# Index: PrimaryKey
#==============================================================
CreateIndx C=PrimaryKey T=AcessoSistema U=unique
(
      C=Código A=ASC
);

#==============================================================
# Table: Demandas
#==============================================================
CreateTble C=Demandas N="Demandas"
(
   C=ID T="INTEGER" P=Yes M=Yes N="ID" Z=false,
   C=IDTIPODEMANDA T="INTEGER" P=No M=No N="IDTIPODEMANDA" Z=false,
   C=LOGRADOURO T="VARCHAR" P=No M=No N="LOGRADOURO" Z=false,
   C=NUMERO T="INTEGER" P=No M=No N="NUMERO" Z=false,
   C=COMPLEMENTO T="VARCHAR" P=No M=No N="COMPLEMENTO" Z=false,
   C=BAIRRO T="VARCHAR" P=No M=No N="BAIRRO" Z=false,
   C=DESCRICAODETALHADA T="VARCHAR" P=No M=No N="DESCRICAODETALHADA" Z=false
);

#==============================================================
# Index: PrimaryKey
#==============================================================
CreateIndx C=PrimaryKey T=Demandas U=unique
(
      C=ID A=ASC
);

#==============================================================
# Table: Funcionario
#==============================================================
CreateTble C=Funcionario N="Funcionario"
(
   C=Código T="INTEGER" P=Yes M=Yes N="Código" Z=false,
   C=NOME T="VARCHAR" P=No M=No N="NOME" Z=false,
   C=SETOR_IDSETOR T="INTEGER" P=No M=No N="SETOR_IDSETOR" Z=false,
   C=TELEFONE T="VARCHAR" P=No M=No N="TELEFONE" Z=false
);

#==============================================================
# Index: PrimaryKey
#==============================================================
CreateIndx C=PrimaryKey T=Funcionario U=unique
(
      C=Código A=ASC
);

#==============================================================
# Table: Setor
#==============================================================
CreateTble C=Setor N="Setor"
(
   C=Código T="COUNTER" P=Yes M=Yes N="Código" Z=false,
   C=NOME T="VARCHAR" P=No M=No N="NOME" Z=false,
   C=SECRETARIA T="VARCHAR" P=No M=No N="SECRETARIA" Z=false
);

#==============================================================
# Index: PrimaryKey
#==============================================================
CreateIndx C=PrimaryKey T=Setor U=unique
(
      C=Código A=ASC
);

#==============================================================
# Table: TipoDemanda
#==============================================================
CreateTble C=TipoDemanda N="TipoDemanda"
(
   C=ID T="COUNTER" P=Yes M=Yes N="ID" Z=false,
   C=IDSETOR T="INTEGER" P=No M=No N="IDSETOR" Z=false,
   C=DESCRICAO T="VARCHAR" P=No M=No N="DESCRICAO" Z=false
);

#==============================================================
# Index: PrimaryKey
#==============================================================
CreateIndx C=PrimaryKey T=TipoDemanda U=unique
(
      C=ID A=ASC
);

#==============================================================
# Index: IDSETOR
#==============================================================
CreateIndx C=IDSETOR T=TipoDemanda
(
      C=IDSETOR A=ASC
);

#==============================================================
# Table: Usuario
#==============================================================
CreateTble C=Usuario N="Usuario"
(
   C=CPF T="VARCHAR" P=Yes M=Yes N="CPF" Z=false,
   C=SENHA T="VARCHAR" P=No M=No N="SENHA" Z=false,
   C=NOME T="VARCHAR" P=No M=No N="NOME" Z=false,
   C=DATANASCIMENTO T="DATE" P=No M=No N="DATANASCIMENTO" Z=false,
   C=CEP T="VARCHAR" P=No M=No N="CEP" Z=false,
   C=LOGRADOURO T="VARCHAR" P=No M=No N="LOGRADOURO" Z=false,
   C=NUMERO T="INTEGER" P=No M=No N="NUMERO" Z=false,
   C=COMPLEMENTO T="VARCHAR" P=No M=No N="COMPLEMENTO" Z=false,
   C=BAIRRO T="VARCHAR" P=No M=No N="BAIRRO" Z=false,
   C=TELEFONEFIXO T="VARCHAR" P=No M=No N="TELEFONEFIXO" Z=false,
   C=TELEFONECELULAR T="VARCHAR" P=No M=No N="TELEFONECELULAR" Z=false,
   C=EMAIL T="VARCHAR" P=No M=No N="EMAIL" Z=false
);

#==============================================================
# Index: PrimaryKey
#==============================================================
CreateIndx C=PrimaryKey T=Usuario U=unique
(
      C=CPF A=ASC
);

#==============================================================
# Table: UsuarioDemanda
#==============================================================
CreateTble C=UsuarioDemanda N="UsuarioDemanda"
(
   C=Código T="COUNTER" P=Yes M=Yes N="Código" Z=false,
   C=IDUSUARIO_CPFUSUARIO T="VARCHAR" P=No M=No N="IDUSUARIO_CPFUSUARIO" Z=false,
   C=IDDEMANDA_IDDEMANDA T="INTEGER" P=No M=No N="IDDEMANDA_IDDEMANDA" Z=false,
   C=DATACADASTRO T="DATE" P=No M=No N="DATACADASTRO" Z=false,
   C=DATAINICIO T="DATE" P=No M=No N="DATAINICIO" Z=false,
   C=DATAFIM T="DATE" P=No M=No N="DATAFIM" Z=false,
   C=STATUS T="YesNo" P=No M=Yes N="STATUS" Z=false
);

#==============================================================
# Index: PrimaryKey
#==============================================================
CreateIndx C=PrimaryKey T=UsuarioDemanda U=unique
(
      C=Código A=ASC
);

CreateJoin C=FK_ACESSOSI_REFERENCE_FUNCIONA T=AcessoSistema P=Funcionario D=restrict U=restrict
(
      P=Código F=Código
);

CreateJoin C=FK_DEMANDAS_REFERENCE_TIPODEMA T=Demandas P=TipoDemanda D=restrict U=restrict
(
      P=ID F=IDTIPODEMANDA
);

CreateJoin C=FK_FUNCIONA_REFERENCE_SETOR T=Funcionario P=Setor D=restrict U=restrict
(
      P=Código F=SETOR_IDSETOR
);

CreateJoin C=FK_TIPODEMA_REFERENCE_SETOR T=TipoDemanda P=Setor D=restrict U=restrict
(
      P=Código F=IDSETOR
);

CreateJoin C=FK_USUARIOD_REFERENCE_USUARIO T=UsuarioDemanda P=Usuario D=restrict U=restrict
(
      P=CPF F=IDUSUARIO_CPFUSUARIO
);

CreateJoin C=FK_USUARIOD_REFERENCE_DEMANDAS T=UsuarioDemanda P=Demandas D=restrict U=restrict
(
      P=ID F=IDDEMANDA_IDDEMANDA
);

