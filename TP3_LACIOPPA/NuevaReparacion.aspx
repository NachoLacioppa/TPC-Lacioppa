<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevaReparacion.aspx.cs" Inherits="TP3_LACIOPPA.NuevaReparacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>NUEVA REPARACION</h2>
    <br />
    <p>Numero de orden</p>
    <asp:TextBox ID="txtOrden" runat="server" class="form-control" Width="150px" TextMode="Number" Enabled="False"></asp:TextBox>
    <div class="form-row">
        <p>Cliente (Buscar por DNI)</p>
    <asp:TextBox ID="txtCliente" runat="server" class="form-control" placeholder="DNI" Width="150px"></asp:TextBox>
    <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar Cliente" class="btn btn-primary" OnClick="btnBuscarCliente_Click" />
        <asp:TextBox ID="txtidcliente" runat="server" class="form-control" placeholder="ID" Width="150px" Height="23px" Enabled="False" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Nombre" Width="150px" Height="23px" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Apellido" Width="150px" Height="23px" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="txtTelefono" runat="server" class="form-control" placeholder="Telefono" Width="150px" Height="23px" Enabled="False"></asp:TextBox>
    </div>
    
    <br />
    <br />
    
    <p>Equipo</p>
    <asp:TextBox ID="txtidequipo" runat="server" class="form-control" placeholder="ID" Width="150px" Height="23px" Enabled="False" Visible="false"></asp:TextBox>
    <asp:TextBox ID="txtNumeroSerie" runat="server" class="form-control" placeholder="Numero de Serie" Width="250px"></asp:TextBox>
    <asp:Button ID="btnBuscarEquipo" runat="server" Text="Buscar Equipo" class="btn btn-primary" OnClick="btnBuscarEquipo_Click" />
    <%--<asp:Label ID="lblNoExiste" runat="server" Text="EQUIPO NO ENCONTRADO"></asp:Label>--%>
    <asp:TextBox ID="txtMarca" runat="server" class="form-control" placeholder="Marca" Width="250px"></asp:TextBox>
    <asp:TextBox ID="txtModelo" runat="server" class="form-control" placeholder="Modelo" Width="250px"></asp:TextBox>
    
    
    <br />
    <br />
    <p>Problema</p>
    <asp:TextBox ID="txtProblema" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5></asp:TextBox>
    <br />
    <p>Tecnico asignado</p>
    <asp:DropDownList ID="dwTecnico" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="btnCargarReparacion" runat="server" Text="Carga Reparacion" class="btn btn-primary" OnClick="btnCargarReparacion_Click" />

</asp:Content>
