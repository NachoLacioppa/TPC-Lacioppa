<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="TP3_LACIOPPA.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
<!-- CLIENTES -->
    <div class="col-sm-2">
    <div class="card" style=" width: 15rem;">
    <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRrN6jk28w41e5Zr8is-Tf0zeha4NMZgW8uKooOSozJVkfmHbqk" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Clientes</h5>
    <asp:Button ID="btnCliente" runat="server" Text="IR!" class="btn btn-primary" />
    </div>
    </div>
  </div>
<!-- REPUESTOS -->
  <div class="col-sm-2">
    <div class="card" style=" width: 15rem;">
    <img src="https://cdn.iconscout.com/icon/premium/png-256-thumb/drawing-tools-1507636-1280063.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Repuestos</h5>
    <asp:Button ID="btnRepuestos" runat="server" Text="IR!" class="btn btn-primary" />
    </div>
    </div>
  </div>
    <!-- REPARACION -->
    <div class="col-sm-2">
    <div class="card" style=" width: 15rem;">
    <img src="https://image.flaticon.com/icons/png/512/69/69769.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Repuestos</h5>
    <asp:Button ID="btnReparacion" runat="server" Text="IR!" class="btn btn-primary" />
    </div>
    </div>
  </div>
</div>

 

   
</asp:Content>
