<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="TP3_LACIOPPA.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
            <h2>MENU PRINCIPAL</h2>
    </center>
    <br />
        <asp:Label Text="Bienvenido: " runat="server" Font-Size="X-Large" />
        <asp:Label Text=" " runat="server" ID="lblUser" Font-Size="X-Large"/>
    <br />
    <asp:label text=" " runat="server" ID="lblPerfilTecnico"/>
    <br />
    <div class="row">
<!-- CLIENTES -->
        <div class="col-sm-3">
    <div class="card" style=" width: 15rem;">
    <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRrN6jk28w41e5Zr8is-Tf0zeha4NMZgW8uKooOSozJVkfmHbqk" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Clientes</h5>

   <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#multiCollapseExample1" aria-expanded="false" aria-controls="multiCollapseExample1">Menu</button>
    
        <div class="collapse multi-collapse" id="multiCollapseExample1">
      
         <li><a href="AltaCliente.aspx">Agregar Cliente</a></li>
     <li>  <a href="BajaCliente.aspx">Eliminar Cliente</a></li>
     <li> <a href="ModificarCliente.aspx">Modificar Cliente</a></li>
     <li>  <a href="BusquedaCliente.aspx">Listar Clientes</a></li>
      
    </div>


    </div>
    </div>

  </div>
<!-- REPUESTOS -->
  <div class="col-sm-3">
    <div class="card" style=" width: 15rem;">
    <img src="https://cdn.iconscout.com/icon/premium/png-256-thumb/drawing-tools-1507636-1280063.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Repuestos</h5>

    <button id="btnRepuestos" runat="server" class="btn btn-primary" type="button" data-toggle="collapse" data-target="#multiCollapseExample2" aria-expanded="false" aria-controls="multiCollapseExample2">
    Menu
  </button>

        <div class="collapse multi-collapse" id="multiCollapseExample2">
      
     <li><a href="AltaRepuesto.aspx">Nuevo Repuesto</a></li>
     <li>  <a href="BajaRepuestos.aspx">Eliminar Repuestos</a></li>
    <%-- <li> <a href="StockRepuestos.aspx">Agregar Stock Repuestos</a></li>--%>
     <li>  <a href="BusquedaRepuestos.aspx">Listar Repuestos</a></li>
     <li>  <a href="ModificarRepuestos.aspx">Modificar Repuestos</a></li>
     <li>  <a href="AgregarCateogtiasRepuestos.aspx">CATEGORIAS</a></li>
      </div>
    

    </div>
    </div>
  </div>
    <!-- REPARACION -->
    <div class="col-sm-3">
    <div class="card" style=" width: 15rem;">
    <img src="https://image.flaticon.com/icons/png/512/69/69769.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Reparaciones</h5>

     <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#multiCollapseExample4" aria-expanded="false" aria-controls="multiCollapseExample2">
    Menu
  </button>

        <div class="collapse multi-collapse" id="multiCollapseExample4">
     <li><a href="NuevaReparacion.aspx">Nueva Reparacion</a></li>
     <li>  <a href="FinalizarReparacion.aspx">Finalizar Reparacion</a></li>
     <li> <a runat="server" id="lstReparaciones" href="ListarReparaciones.aspx">Listar Reparaciones</a></li>
     <li> <a href="BuscarOrden.aspx">Buscar Reparacion</a></li>
     <li>  <a href="ListarOrdenesPropias.aspx">MIS REPARACIONES</a></li>
     <li> <a href="EquiposCargados.aspx">EQUIPOS CARGADOS</a></li>
      </div>
    </div>
    </div>
  </div>
    <!-- TECNICOS -->
    <div class="col-sm-3">
    <div class="card" style=" width: 15rem;">
    <img src="https://static.thenounproject.com/png/146720-200.png" class="card-img-top" alt="...">
    <div class="card-body">
    <h5 class="card-title">Tecnicos</h5>

        <button id="btnTec" runat="server" class="btn btn-primary" type="button" data-toggle="collapse" data-target="#multiCollapseExample3" aria-expanded="false" aria-controls="multiCollapseExample3">
    Menu
  </button>
        <div class="collapse multi-collapse" id="multiCollapseExample3">
         <li><a href="AltaTecnicos.aspx">Agregar Tecnico</a></li>
     <li>  <a href="BajaTecnicos.aspx">Eliminar Tecnico</a></li>
     <li> <a href="ModificarTecnico.aspx">Modificar Tecnico</a></li>
     <li>  <a href="BusquedaTecnicos.aspx">Listar Tecnicos</a></li>
     <%--<li>  <a href="AgregarPerfilesTecnicos.aspx">PERFILES</a></li>--%>
      
    </div>

    </div>
    </div>
  </div>
</div>
</asp:Content>
