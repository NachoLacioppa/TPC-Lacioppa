<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FinalizarReparacion.aspx.cs" Inherits="TP3_LACIOPPA.FinalizarReparacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>FINALIZAR REPARACION</h2>
    </center>
    
    <div class="container">
        <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Buscar Numero de Orden: " runat="server" />
        <asp:TextBox ID="txtOrden" runat="server" class="form-control" Width="150px" TextMode="Number"></asp:TextBox>
         <asp:TextBox ID="txtIDReparacion" runat="server" Visible="false"></asp:TextBox>
        <br />
         <asp:Button ID="btnBuscarOrden" runat="server" Text="Buscar Orden" class="btn btn-primary" OnClick="btnBuscarOrden_Click" />
    </div>
  </div>
    <br />
        <h4>DATOS DE LA REPARACION</h4>
     <%--DATOS CLIENTE--%>
    <div class="form-row">
    <div class="form-group col-md-3">
        <asp:Label Text="DATOS DEL CLIENTE" runat="server" Font-Size="X-Large" ForeColor="#000099"/>
        <asp:Label Text="Nombre: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtNombreCli" runat="server" CssClass="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <br />
        <asp:Label Text="Apellido: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtApellidoCli" runat="server" CssClass="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <br />
        <asp:Label Text="Telefono: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtTelefonoCli" runat="server" CssClass="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <br />
    </div>
         <%--DATOS EQUIPO--%>
    <div class="form-group col-md-3">
        <asp:Label Text="DATOS DEL EQUIPO" runat="server" CssClass="col-form-label" Font-Size="X-Large" ForeColor="#000099"/>
        <br />
        <asp:Label Text="S/N: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtSN" runat="server" CssClass="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <br />
        <asp:Label Text="Marca: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" Width="150px" Enabled="false" ></asp:TextBox>
        <br />
        <asp:Label Text="Modelo: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control" Width="150px" Enabled="false" ></asp:TextBox>
    </div>
        <div class="form-group col-md-3">
        <asp:Label Text="DATOS EXTRA" runat="server" CssClass="col-form-label" Font-Size="X-Large" ForeColor="#000099"/>
        <br />
        <asp:Label Text="Tecnico Asignado" runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtUser" runat="server" class="form-control" Width="150px" Enabled="false" CssClass="form-control"></asp:TextBox>
        <asp:Label Text="Fecha de Ingreso" runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtFechaIng" runat="server" class="form-control" Width="150px" Enabled="false" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label Text="Problema" runat="server" CssClass="col-form-label"/>
        <br />
        <asp:TextBox ID="txtProblema" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="false" CssClass="form-control"></asp:TextBox>
        <asp:Label Text="Estado de Reparacion" runat="server" CssClass="col-form-label" />
        <asp:TextBox ID="txtEstado" runat="server" class="form-control" Width="150px" Enabled="false" CssClass="form-control"></asp:TextBox>
    </div>
  </div>
        <h4>DATOS DE FINAL DE REPARACION</h4>
        <div class="form-row">
            <div class="form-group col-md-3">
                <%--INFORME FINAL Y REPUESTOS--%>
                <asp:Label Text="Informe Final" runat="server" />
        <br />
       <asp:TextBox ID="txtInforme" runat="server" Height="107px" Width="308px" TextMode="MultiLine" Rows=5 Enabled="true"></asp:TextBox>
        <br />
            </div>
              </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label Text="Ingrese codigo del repuesto: " runat="server" />
        <asp:TextBox ID="txtCodigoRep" runat="server" class="form-control" Width="150px" Enabled="true" ></asp:TextBox>
        <br />
        <asp:Button ID="btnBuscarRepuesto" runat="server" Text="Buscar Repuesto" class="btn btn-primary" OnClick="btnBuscarRepuesto_Click" />
        <asp:Label Text="POR FAVOR INGRESE UN CODIGO DE REPUESTO ANTES DE APRETAR EL BOTON REPUESTO!!!!!" runat="server" ID="lblVerificaRepuesto" CssClass="col-form-label"/>
        <br />
        <asp:TextBox ID="txtIDRepuesto" runat="server" Visible="false"></asp:TextBox>
        <asp:Label Text="Nombre del repuesto: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtNompreRep" runat="server" CssClass="form-control" Enabled="false" ></asp:TextBox>
        <br />
        <asp:Label Text="Precio: " runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtPrecioRepuesto" runat="server" CssClass="form-control" Enabled="false" ></asp:TextBox>
        <br />
        <asp:Button ID="btnAgregarRepuesto" runat="server" Text="Agregar Repuesto" class="btn btn-primary" OnClick="btnAgregarRepuesto_Click"  />
            </div>
            <div class="form-group col-md-6"></div>
            <asp:GridView ID="gvDatosRepuestos" runat="server" AutoGenerateColumns="false" ShowFooter="false" CssClass="table-bordered">
            <Columns>
                <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate> 
                        <asp:label text='<%# Eval("Codigo")%>' runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
                        <Columns>
                <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate> 
                        <asp:label text='<%# Eval("Nombre")%>' runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
                                 <Columns>
                <asp:TemplateField HeaderText="Precio">
                <ItemTemplate> 
                        <asp:label text='<%# Eval("precio")%>' runat="server" />
                    </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
        </asp:GridView>
            <br />
            <div class="form-group col-md-3">
                <asp:Label Text="Precio acumulable de los repuestos:" runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtPrecioAcumulativoRepuestos" runat="server" CssClass="form-control" Enabled="false" Text="0" Width="150px"></asp:TextBox>
            </div>
            </div>
        <br />
        <br />
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label Text="PRESUPUESTO MANO DE OBRA" runat="server" CssClass="col-form-label"/>
        <asp:TextBox ID="txtPrecioManoObra" runat="server" CssClass="form-control" Width="150px" Enabled="true" ></asp:TextBox>
        <asp:Button ID="btnCalcularTotal" runat="server" Text="Calcular Presupuesto" class="btn btn-secondary" OnClick="btnCalcularTotal_Click" />
        <asp:Label Text="NO SE INGRESO UNA ORDEN DE REPARACION" runat="server" ForeColor="#FF0F0F" ID="lblingresoorden" CssClass="col-form-label"/>  
    <br />
    <asp:Label Text="PRESUPUESTO TOTAL: " runat="server" CssClass="col-form-label"/>
    <asp:TextBox ID="txtPrecioTotal" runat="server" class="form-control" Width="150px" Enabled="false" Text="0" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Button ID="btnFinalizarOrden" runat="server" Text="Finalizar Orden" class="btn btn-success" OnClick="btnFinalizarOrden_Click" />
            </div>
        </div>
    </div>
</asp:Content>
