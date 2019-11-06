<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="TP3_LACIOPPA.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>MENU PRINCIPAL</h2>
    <br />
    <div class="row">
<!-- CLIENTES -->
        <div class="col-sm-2">
    <div class="card" style=" width: 15rem;">
    <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRrN6jk28w41e5Zr8is-Tf0zeha4NMZgW8uKooOSozJVkfmHbqk" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Clientes</h5>

   <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#multiCollapseExample1" aria-expanded="false" aria-controls="multiCollapseExample1">
    Menu
  </button>
        <div class="collapse multi-collapse" id="multiCollapseExample1">
      
         <li><a href="AltaCliente.aspx">Agregar Cliente</a></li>
     <li>  <a href="#">Eliminar Cliente</a></li>
     <li> <a href="#">Modificar Cliente</a></li>
     <li>  <a href="BusquedaCliente.aspx">Buscar Cliente</a></li>
      
    </div>


    </div>
    </div>

  </div>
<!-- REPUESTOS -->
  <div class="col-sm-2">
    <div class="card" style=" width: 15rem;">
    <img src="https://cdn.iconscout.com/icon/premium/png-256-thumb/drawing-tools-1507636-1280063.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Repuestos</h5>

    <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#multiCollapseExample2" aria-expanded="false" aria-controls="multiCollapseExample2">
    Menu
  </button>

        <div class="collapse multi-collapse" id="multiCollapseExample2">
      
         <li><a href="#">Agregar Repuestos</a></li>
     <li>  <a href="#">Eliminar Repuestos</a></li>
     <li> <a href="#">Modificar Repuestos</a></li>
     <li>  <a href="#">Buscar Repuestos</a></li>
      </div>
    

    </div>
    </div>
  </div>
    <!-- REPARACION -->
    <div class="col-sm-2">
    <div class="card" style=" width: 15rem;">
    <img src="https://image.flaticon.com/icons/png/512/69/69769.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Reparaciones</h5>

    <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="DropDownList3" runat="server">
            <asp:ListItem Text="One" Value=1 />
            <asp:ListItem Text="Two" Value=2 />
            <asp:ListItem Text="Three" Value=3 />
        </asp:DropDownList>

    </div>
    </div>
  </div>
    <!-- TECNICOS -->
    <div class="col-sm-2">
    <div class="card" style=" width: 15rem;">
    <img src="https://static.thenounproject.com/png/146720-200.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Tecnicos</h5>

        <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#multiCollapseExample3" aria-expanded="false" aria-controls="multiCollapseExample3">
    Menu
  </button>

        <div class="collapse multi-collapse" id="multiCollapseExample3">
      
         <li><a href="#">Agregar Tecnico</a></li>
     <li>  <a href="#">Eliminar Tecnico</a></li>
     <li> <a href="#">Modificar Tecnico</a></li>
     <li>  <a href="#">Buscar Tecnicos</a></li>
      
    </div>

    </div>
    </div>
  </div>
</div>
</asp:Content>
