<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaRepuesto.aspx.cs" Inherits="TP3_LACIOPPA.AltaRepuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
          <h2>AGREGAR NUEVO REPUESTO</h2>
    </center>

<form>
  <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Codigo" runat="server" />
         <asp:TextBox ID="txtCodigo" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <asp:Label Text="Nombre" runat="server" />
         <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="450px"></asp:TextBox>
        <asp:Label Text="Precio" runat="server" />
         <asp:TextBox ID="txtPrecio" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <asp:Label Text="Categoria" runat="server" />
        <br />
         <asp:DropDownList ID="dwCategorias" runat="server" class="btn btn-secondary btn-sm dropdown-toggle"></asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnAltaRepuesto" runat="server" class="btn btn-primary" Text="Cargar Repuesto" OnClick="btnAltaRepuesto_Click" />
    </div>
  </div>
</form>
</asp:Content>
