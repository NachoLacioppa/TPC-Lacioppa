<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FinalizarReparacion.aspx.cs" Inherits="TP3_LACIOPPA.FinalizarReparacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>FINALIZAR REPARACION</h2>
    <br />
    <p>Buscar numero de orden</p>
    <asp:TextBox ID="txtOrden" runat="server" class="form-control" Width="150px" TextMode="Number"></asp:TextBox>
    <asp:TextBox ID="txtIDReparacion" runat="server" Visible="false"></asp:TextBox>
    <asp:Button ID="btnBuscarOrden" runat="server" Text="Buscar Orden" class="btn btn-primary" OnClick="btnBuscarOrden_Click" />
    <br />
    <h5>CLIENTE</h5>
    <div>
        <asp:Label Text="Nombre: " runat="server" />
        <asp:TextBox ID="txtNombreCli" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Apellido: " runat="server" />
        <asp:TextBox ID="txtApellidoCli" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Telefono: " runat="server" />
        <asp:TextBox ID="txtTelefonoCli" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    </div>
    <br />
    <h5>EQUIPO</h5>
    <div>
        <asp:Label Text="S/N: " runat="server" />
        <asp:TextBox ID="txtSN" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Marca: " runat="server" />
        <asp:TextBox ID="txtMarca" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <asp:Label Text="Modelo: " runat="server" />
        <asp:TextBox ID="txtModelo" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    </div>
    <br />
    <h5>TECNICO ASIGNADO</h5>
    <asp:TextBox ID="txtUser" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    <br />
    <h5>FECHA DE INGRESO</h5>
    <asp:TextBox ID="txtFechaIng" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    <br />
    <div>
        <h5>PROBLEMA</h5>
        <asp:TextBox ID="txtProblema" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="false"></asp:TextBox>
        <h5>ESTADO DE LA REPARACION</h5>
        <asp:TextBox ID="txtEstado" runat="server" class="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    </div>
    <br />
    <br />
    <h5>INFORME FINAL</h5>
    <asp:TextBox ID="txtInforme" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="true"></asp:TextBox>
    <div>
        <h5>CARGAR REPUESTOS A LA REPARACION</h5>
        <asp:Label Text="Ingrese codigo del repuesto: " runat="server" />
        <asp:TextBox ID="txtCodigoRep" runat="server" class="form-control" Width="150px" Enabled="true" ></asp:TextBox>
        <asp:Button ID="btnBuscarRepuesto" runat="server" Text="Buscar Repuesto" class="btn btn-primary" OnClick="btnBuscarRepuesto_Click" />
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
        <asp:Label Text="PRESUPUESTO MANO DE OBRA" runat="server" />
        <asp:TextBox ID="txtPrecioManoObra" runat="server" class="form-control" Width="150px" Enabled="true" ></asp:TextBox>
        <br />
    </div>
    <br />
    <asp:Button ID="btnCalcularTotal" runat="server" Text="Calcular Presupuesto" class="btn btn-secondary" OnClick="btnCalcularTotal_Click" />
    <br />
    <asp:Label Text="PRESUPUESTO TOTAL: " runat="server" />
    <asp:TextBox ID="txtPrecioTotal" runat="server" class="form-control" Width="150px" Enabled="false" Text="0"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnFinalizarOrden" runat="server" Text="Finalizar Orden" class="btn btn-success" OnClick="btnFinalizarOrden_Click" />
    <br />
</asp:Content>
