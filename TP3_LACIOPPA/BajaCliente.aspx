<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BajaCliente.aspx.cs" Inherits="TP3_LACIOPPA.BajaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>BAJA CLIENTE (BETA: solo dni)</h2>
    <br />
    <label>Ingrese DNI del cliente:</label>
    <asp:TextBox ID="txtBusquedaCliente" runat="server" class="form-control" Width="150px" ></asp:TextBox>
    <br />
    <asp:Button ID="btnEliminarCliente" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="btnEliminarCliente_Click" />
    </center>
</asp:Content>
