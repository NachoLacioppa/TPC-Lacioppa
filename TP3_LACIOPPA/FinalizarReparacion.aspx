<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FinalizarReparacion.aspx.cs" Inherits="TP3_LACIOPPA.FinalizarReparacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>FINALIZAR REPARACION</h2>
    </center>
    

    <%--BUSCAR NUMERO DE ORDEN--%>
    <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Buscar Numero de Orden: " runat="server" />
        <asp:TextBox ID="txtOrden" runat="server" class="form-control" Width="150px" TextMode="Number"></asp:TextBox>
         <asp:TextBox ID="txtIDReparacion" runat="server" Visible="false"></asp:TextBox>
         <asp:Button ID="btnBuscarOrden" runat="server" Text="Buscar Orden" class="btn btn-primary" OnClick="btnBuscarOrden_Click" />
    </div>
  </div>
    <br />
    <h4>DATOS DE LA REPARACION</h4>
     <%--DATOS CLIENTE--%>
    <div class="form-row">
    <div class="form-group col-md-6">
        <h6>DATOS DEL CLIENTE</h6>
        <asp:Label Text="Nombre: " runat="server" />
        <asp:TextBox ID="txtNombreCli" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Apellido: " runat="server" />
        <asp:TextBox ID="txtApellidoCli" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Telefono: " runat="server" />
        <asp:TextBox ID="txtTelefonoCli" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    </div>
  </div>
     <%--DATOS EQUIPO--%>
    <div class="form-row">
    <div class="form-group col-md-6">
        <h6>DATOS DEL EQUIPO</h6>
        <asp:Label Text="S/N: " runat="server" />
        <asp:TextBox ID="txtSN" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Marca: " runat="server" />
        <asp:TextBox ID="txtMarca" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Modelo: " runat="server" />
        <asp:TextBox ID="txtModelo" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    </div>
  </div>
     <%--TECNICO ASIGNADO, FECHA, PROBLEMA--%>
    <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Tecnico Asignado" runat="server" />
        <asp:TextBox ID="txtUser" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Fecha de Ingreso" runat="server" />
        <asp:TextBox ID="txtFechaIng" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <br />
        <br />
        <asp:Label Text="Problema" runat="server" />
        <br />
        <asp:TextBox ID="txtProblema" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="false"></asp:TextBox>
        <asp:Label Text="Estado de Reparacion" runat="server" />
        <asp:TextBox ID="txtEstado" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    </div>
  </div>
    <br />
    <br />
    <h4>CIERRE DE LA REPARACION</h4>
     <%--INFORME FINAL--%>
    <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Informe Final" runat="server" />
        <br />
       <asp:TextBox ID="txtInforme" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="true"></asp:TextBox>
    </div>
  </div>
    <br />
         <%--CARGA DE REPUESTOS UTILIZADOS--%>
    <div class="form-row">
    <div class="form-group col-md-6">
       <asp:Label Text="Ingrese codigo del repuesto: " runat="server" />
        <asp:TextBox ID="txtCodigoRep" runat="server" class="form-control" Width="150px" Enabled="true" ></asp:TextBox>
        <asp:Button ID="btnBuscarRepuesto" runat="server" Text="Buscar Repuesto" class="btn btn-primary" OnClick="btnBuscarRepuesto_Click" />
        <asp:Label Text="POR FAVOR INGRESE UN CODIGO DE REPUESTO ANTES DE APRETAR EL BOTON REPUESTO!!!!!" runat="server" ID="lblVerificaRepuesto"/>
        <br />
        <asp:Label Text="Nombre del repuesto: " runat="server" />
        <asp:TextBox ID="txtIDRepuesto" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtNompreRep" runat="server" class="form-control" Width="350px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Precio: " runat="server" />
        <asp:TextBox ID="txtPrecioRepuesto" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Button ID="btnAgregarRepuesto" runat="server" Text="Agregar Repuesto" class="btn btn-primary" OnClick="btnAgregarRepuesto_Click" />
        <br />
        <asp:GridView ID="gvDatosRepuestos" runat="server"></asp:GridView>
        <br />
        <asp:Label Text="Precio acumulable de los repuestos:" runat="server" />
        <asp:TextBox ID="txtPrecioAcumulativoRepuestos" runat="server" class="form-control" Width="150px" Enabled="false" Text="0"></asp:TextBox>
       
        <br />
    </div>
  </div>

         <%--PARTE FINAL--%>
    <div class="form-row">
    <div class="form-group col-md-6">
        <br />
        <asp:Label Text="PRESUPUESTO MANO DE OBRA" runat="server" />
        <asp:TextBox ID="txtPrecioManoObra" runat="server" class="form-control" Width="150px" Enabled="true" ></asp:TextBox>
        <asp:Button ID="btnCalcularTotal" runat="server" Text="Calcular Presupuesto" class="btn btn-secondary" OnClick="btnCalcularTotal_Click" />
    <br />
    <asp:Label Text="PRESUPUESTO TOTAL: " runat="server" />
    <asp:TextBox ID="txtPrecioTotal" runat="server" class="form-control" Width="150px" Enabled="false" Text="0"></asp:TextBox>
    <br />
    <asp:Button ID="btnFinalizarOrden" runat="server" Text="Finalizar Orden" class="btn btn-success" OnClick="btnFinalizarOrden_Click" />
    </div>
  </div>
</asp:Content>
