<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BajaRepuestos.aspx.cs" Inherits="TP3_LACIOPPA.BajaRepuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>BAJA REPUESTO (BETA: solo codigo)</h2>
    <br />
    <label>Ingrese codigo de repuesto:</label>
    <asp:TextBox ID="txtBusquedaRepuesto" runat="server" class="form-control" Width="150px" ></asp:TextBox>
    <br />
    <asp:Button ID="btnEliminarRepuesto" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="btnEliminarRepuesto_Click" />
</asp:Content>
