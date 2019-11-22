<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BajaTecnicos.aspx.cs" Inherits="TP3_LACIOPPA.BajaTecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>BAJA TECNICOS (BETA: solo con usuario)</h2>
    <br />
    <label>Ingrese Usuario del Tecnico:</label>
    <asp:TextBox ID="txtBuscaTecnico" runat="server" class="form-control" Width="150px" ></asp:TextBox>
    <br />
    <asp:Button ID="btnEliminarTecnico" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="btnEliminarTecnico_Click" />
</asp:Content>
