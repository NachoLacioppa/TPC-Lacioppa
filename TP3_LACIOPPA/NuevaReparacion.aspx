<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevaReparacion.aspx.cs" Inherits="TP3_LACIOPPA.NuevaReparacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>NUEVA REPARACION</h2>
    <br />
    <p>Numero de orden</p>
    <asp:TextBox ID="txtOrden" runat="server" class="form-control" Width="150px" TextMode="Number"></asp:TextBox>
    <p>Cliente (Buscar por DNI)</p>
    <asp:TextBox ID="txtCliente" runat="server" class="form-control" placeholder="DNI" Width="150px"></asp:TextBox>
    <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar Cliente" class="btn btn-primary" CssClass="position-relative" />
    <asp:GridView ID="dgvDatosCliente" runat="server"></asp:GridView>
    <br />
    <br />
    <p>Equipo</p>
    <asp:TextBox ID="txtNumeroSerie" runat="server" class="form-control" placeholder="Numero de Serie" Width="250px"></asp:TextBox>
    <asp:Button ID="btnBuscarEquipo" runat="server" Text="Buscar Equipo" class="btn btn-primary" />
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
    <asp:Button ID="btnCargarReparacion" runat="server" Text="Buscar Equipo" class="btn btn-primary" />

</asp:Content>
