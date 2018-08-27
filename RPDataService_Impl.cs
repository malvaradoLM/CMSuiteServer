﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPSuiteServer
{
    using System;
    using System.Collections.Generic;
    using RemObjects.SDK;
    using RemObjects.SDK.Types;
    using RemObjects.SDK.Server;
    using RemObjects.SDK.Server.ClassFactories;
    using System.Data;

    [RemObjects.SDK.Server.ClassFactories.StandardClassFactory()]
    [RemObjects.SDK.Server.Service(Name = "RPDataService", InvokerClass = typeof(RPDataService_Invoker), ActivatorClass = typeof(RPDataService_Activator))]
    public class RPDataService : RemObjects.DataAbstract.Server.DataAbstractService, IRPDataService
    {
        private RemObjects.DataAbstract.Bin2DataStreamer dataStreamer;
        private System.ComponentModel.IContainer components;

        public RPDataService() :
                this(null, null)
        {
        }
        public RPDataService(ISessionManager sessionManager, IEventSinkManager eventManager) :
                base(sessionManager, eventManager)
        {
            this.InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataStreamer = new RemObjects.DataAbstract.Bin2DataStreamer(this.components);
            // 
            // dataStreamer
            // 
            this.dataStreamer.SendReducedDelta = false;
            // 
            // RPDataService
            // 
            this.AcquireConnection = true;
            this.RequireSession = true;
            this.ServiceDataStreamer = this.dataStreamer;
            this.ServiceSchemaName = "RPSuiteServer";

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if ((this.components != null))
                {
                    this.components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        public System.DateTime Fecha()
        {
            return System.DateTime.Now;
        }

        public bool GuardaFactura(TFactura Datos)
        {
            IDbCommand command;
            using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "spFolio", new string[] { "Campo", "Serie" }, new object[] { "user", "password" }, out command))
            {
                while (reader.Read())
                {


                    // do something
                }
            }


            using (IDbCommand lCommand = this.ServiceSchema.NewCommand(this.Connection, "spInserta", new string[] { }, new object[] { }))
            {
                lCommand.ExecuteNonQuery();
            }
            return true;
        }

        public TFactura NotaCredito(string NewParam, string NewParam1, string NewParam2, string NewParam3)
        {
            GuardaFactura(null);
            Fecha();
            return null;
        }

        public int Folio(string Campo, string Serie)
        {
            int Res = -1;
            IDbCommand command;
            using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "spFolio", new string[] { "Campo", "Serie" }, new object[] { Campo, Serie }, out command))
            {
                while (reader.Read())
                {
                    Res = (int)reader["Folio"];
                }
            }
            return Res;
        }

        public int GuardaClienteNuevo(TClienteNuevo Datos)
        {
            //string[] Params;
            //Params = new string[32];
            Datos.ClienteId = Folio("ClienteID", "");

            int Res = -1;
            //bool Res = false;
            try
            {
                //using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] { }, new object[] { }))

                //using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] {"ClienteID", "Codigo"
                //     ,"Nombre" ,"Grupo" ,"Calle" ,"Colonia" ,"Ciudad" ,"Telefono" ,"CodigoPostal" ,"RFC" ,"Curp" ,"LimiteCredito" ,"email" 
                //     ,"Localidad" ,"Estado" ,"NoExterior" ,"NoInterior"  ,"CuentaBancaria" }, new object[] {
                //         Datos.ClienteId, Datos.Codigo,Datos.Nombre,Datos.Grupo,Datos.Calle,Datos.Colonia,Datos.Ciudad,Datos.Telefono,Datos.CodigoPostal,Datos.RFC,
                //      Datos.CURP,Datos.LimiteCredito, Datos.Email,Datos.Localidad,Datos.Estado,Datos.NoExterior,Datos.NoInterior,Datos.CuentaBancaria}))


                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarClienteNuevo", new string[] {"ClienteID", "Codigo"
                     ,"Nombre" ,"Grupo" ,"Calle" ,"Colonia" ,"Ciudad" ,"Telefono" ,"CodigoPostal" ,"RFC",
                       "Curp","Status","AutorizaCheque","TicketBoucher","AutorizaValeCredito"  ,"LimiteCredito" ,"email"
                     ,"Localidad" ,"Estado" ,"NoExterior" ,"NoInterior"  ,"CuentaBancaria" }, new object[] {
                         Datos.ClienteId,Datos.Codigo,Datos.Nombre,Datos.Grupo,Datos.Calle,Datos.Colonia,Datos.Ciudad,Datos.Telefono,Datos.CodigoPostal,Datos.RFC,
                      Datos.CURP,Datos.Status,Datos.AutorizaCheque,Datos.TicketBoucher,Datos.AutorizaValeCredito, 0,Datos.Email,Datos.Localidad,Datos.Estado,Datos.NoExterior,Datos.NoInterior,Datos.CuentaBancaria}))
                {
                    lcommand.ExecuteNonQuery();
                    Res = Datos.ClienteId;
                }
                // Res = true;
            }
            catch (Exception ex)
            {
                Res = -1;
                // Res = false;
            }

            return Res;
        }

        //public int GuardaDocumentoNuevo(TDocumentoNuevo Datos)
        //{
        //    Datos.DocumentoId = Folio("DocumentoID", "");
        //    byte[] Imagen = System.Text.Encoding.Default.GetBytes(Datos.Imagen);
        //    int Res = -1;
        //    try
        //    {


        //        using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertaDocumentoNuevo", new string[] {"DocumentoID", "Fecha"
        //             ,"Observaciones" ,"Imagen" ,"EmpleadoID" ,"TipoDocumentoID" ,"UsuarioID"}, new object[] {
        //                 Datos.DocumentoId,Datos.Fecha,Datos.Observaciones,Imagen,Datos.EmpleadoId,Datos.TipoDocumentoId,Datos.UsuarioId}))
        //        {
        //            lcommand.ExecuteNonQuery();
        //            Res = Datos.DocumentoId;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Res = -1;
        //    }

        //    return Res;
        //}


        public TCliente BuscarCliente(int clienteID)
        {

            TCliente res = new TCliente();
            // TCliente res; // = new TCliente { ClienteID =};
            try
            {
                int x = 0;
                IDbCommand command;

                using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "BuscaCliente", new string[] { "ClienteID" }, new object[] { clienteID }, out command))
                {
                    while (reader.Read())
                    {


                        // investigar si se puede pasar el Reader completo de manera directa a la variable res, la variable Res es de Tipo TCliente,
                        //Contiene todos los campos de la tabla cliente

                        res.ClienteID = (int)reader["ClienteID"];  // (TCliente)reader["Folio"];
                        if (reader["Nombre"] != DBNull.Value)
                        {
                            res.Nombre = (string)reader["Nombre"];
                        }
                        if (reader["codigo"] != DBNull.Value)
                        {
                            res.Codigo = (string)reader["Codigo"];
                        }
                        if (reader["Calle"] != DBNull.Value)
                        { res.Calle = (string)reader["Calle"]; }

                        if (reader["Colonia"] != DBNull.Value)
                        { res.Colonia = (string)reader["Colonia"]; }

                        if (reader["Ciudad"] != DBNull.Value)
                        { res.Ciudad = (string)reader["Ciudad"]; }

                        if (reader["Telefono"] != DBNull.Value)
                        { res.Telefono = (string)reader["Telefono"]; }

                        if (reader["CodigoPostal"] != DBNull.Value)
                        { res.CodigoPostal = (string)reader["CodigoPostal"]; }

                        if (reader["RFC"] != DBNull.Value)
                        { res.RFC = (string)reader["RFC"]; }

                        if (reader["CURP"] != DBNull.Value)
                        { res.CURP = (string)reader["CURP"]; }

                        if (reader["Status"] != DBNull.Value)
                        { res.Status = (bool)reader["Status"]; }

                        if (reader["AutorizaCheque"] != DBNull.Value)
                        { res.AutorizaCheque = (bool)reader["AutorizaCheque"]; }

                        //    if (reader["TicketBoucher"] != null)
                        //    { res.TicketBoucher = (bool)reader["TicketBoucher"]; }
                        //    if (reader["AutorizaValeCredito"] != null)
                        //    { res.AutorizaValeCredito = (bool)reader["AutorizaValeCredito"]; }

                        if (reader["CuentaContableCredito"] != DBNull.Value)
                        { res.CuentaContableCredito = (string)reader["CuentaContableCredito"]; }

                        //    if (reader["CuentaContableAnticipo"] != null)
                        //    { res.CuentaContableAnticipo = (string)reader["CuentaContableAnticipo"]; }
                        //    if (reader["LimiteCredito"] != null)
                        //    { res.LimiteCredito = (double)reader["LimiteCredito"]; }
                        //    if (reader["DiasCredito"] != null)
                        //    { res.DiasCredito = (int)reader["DiasCredito"]; }
                        //    if (reader["NIP"] != null)
                        //    { res.NIP = (int)reader["NIP"]; }
                        //    if (reader["FacturayLiquidacion"] != null)
                        //    { res.FacturayLiquidacion = (bool)reader["FacturayLiquidacion"]; }
                        //    if (reader["ApellidoPaterno"] != null)
                        //    { res.ApellidoPaterno = (string)reader["ApellidoPaterno"]; }
                        //    if (reader["ApellidoMaterno"] != null)
                        //    { res.ApellidoMaterno = (string)reader["ApellidoMaterno"]; }
                        //    if (reader["Email"] != null)
                        //    { res.Email = (string)reader["Email"]; }
                        //    if (reader["Referencia"] != null)
                        //    { res.Referencia = (string)reader["Referencia"]; }
                        //    if (reader["Telefonos"] != null)
                        //    { res.Telefonos = (string)reader["Telefonos"]; }
                        //    if (reader["FacturaExpress"] != null)
                        //    { res.FacturaExpress = (bool)reader["FacturaExpress"]; }
                        //    if (reader["saldo"] != null)
                        //    { res.Saldo = (double)reader["saldo"]; }
                        //    if (reader["PuntosCategoriaID"] != null)
                        //    { res.PuntosCategoriaID = (int)reader["PuntosCategoriaID"]; }
                        //    if (reader["Localidad"] != null)
                        //    { res.Localidad = (string)reader["Localidad"]; }
                        //    
                        //if (reader["Estado"] != null)
                        //{ res.Estado = (string)reader["Estado"]; }
                        //if (reader["NoExterior"] != null)
                        //{ res.NoExterior = (string)reader["NoExterior"]; }
                        //if (reader["NoInterior"] != null)
                        //{ res.NoInterior = (string)reader["NoInterior"]; }
                        //if (reader["Actualizado"] != null)
                        //{ res.Actualizado = (bool)reader["Actualizado"]; }
                        //if (reader["CuentaBancaria"] != null)
                        //{ res.CuentaBancaria = (string)reader["CuentaBancaria"]; }

                        //if (reader["Sexo"] != null)
                        //{ res.Sexo = (string)reader["Sexo"]; }
                        //if (reader["Clasificacion"] != null)
                        //{ res.Clasificacion = (double)reader["Clasificacion"]; }
                        //if (reader["INE"] != null)
                        //{ res.INE = (bool)reader["INE"]; }
                        //if (reader["INETipoProceso"] != null)
                        //{ res.INETipoProceso = (string)reader["INETipoProceso"]; }
                        //if (reader["INETipoComite"] != null)
                        //{ res.INETipoComite = (string)reader["INETipoComite"]; }
                        //if (reader["INEidContabilidad"] != null)
                        //{ res.INEidContabilidad = (int)reader["INEidContabilidad"]; }
                        //if (reader["INEClaveEntidad"] != null)
                        //{ res.INEClaveEntidad = (string)reader["INEClaveEntidad"]; }
                        //if (reader["INEEntidadAmbito"] != null)
                        //{ res.INEEntidadAmbito = (string)reader["INEEntidadAmbito"]; }
                        //if (reader["INEEntidadContabilidad"] != null)
                        //{ res.INEEntidadContabilidad = (int)reader["INEEntidadContabilidad"]; }
                        //if (reader["UUID"] != null)
                        //{ res.UUID = (string)reader["UUID"]; }


                    }
                }

            }

            catch (Exception ex)
            {
                //

                res.ClienteID = -1;
                // Res = false;
            }
            return res;
        }

        public TPedido BuscarPedido(string Datos)
        {

            TPedido res = new TPedido();
            // TCliente res; // = new TCliente { ClienteID =};
            try
            {
                int x = 0;
                IDbCommand command;

                using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "spPedido", new string[] { "Datos" }, new object[] { Datos }, out command))
                {
                    while (reader.Read())
                    {


                        // investigar si se puede pasar el Reader completo de manera directa a la variable res,
                        res.PedidoID = (int)reader["PedidoID"];
                        res.Fecha = (DateTime)(reader["Fecha"] != DBNull.Value ? reader["Fecha"] : DateTime.MinValue);
                        res.FechaModificacion = (DateTime)(reader["FechaModificacion"] != DBNull.Value ? reader["FechaModificacion"] : DateTime.MinValue);
                        res.EstacionID = (int)(reader["EstacionID"] != DBNull.Value ? reader["EstacionID"] : -1);
                        res.Subtotal = (double)(reader["Subtotal"] != DBNull.Value ? reader["Subtotal"] : (double)0);
                        res.IVA = (double)(reader["IVA"] != DBNull.Value ? reader["IVA"] : (double)0);
                        res.IEPS = (double)(reader["IEPS"] != DBNull.Value ? reader["IEPS"] : (double)0);
                        res.Total = (double)(reader["Total"] != DBNull.Value ? reader["Total"] : (double)0);
                        res.Descuento = (double)(reader["Descuento"] != DBNull.Value ? reader["Descuento"] : (double)0);
                        res.UsuarioID = (int)(reader["UsuarioID"] != DBNull.Value ? reader["UsuarioID"] : -1);
                        res.Serie = (string)(reader["Serie"] != DBNull.Value ? reader["Serie"] : "");
                        res.Folio = (int)(reader["Folio"] != DBNull.Value ? reader["Folio"] : 0);
                        //res.Status = (bool)(reader["Status"] != DBNull.Value ? reader["Status"] : false);
                        res.Observacion = (string)(reader["Observacion"] != DBNull.Value ? reader["Observacion"] : "");
                        res.ConfiguracionID = (int)(reader["ConfiguracionID"] != DBNull.Value ? reader["ConfiguracionID"] : -1);
                        res.Dia = (int)(reader["Dia"] != DBNull.Value ? reader["Dia"] : -1);
                        res.Ejercisio = (int)(reader["Ejercicio"] != DBNull.Value ? reader["Ejercicio"] : -1);
                    }
                }

            }

            catch (Exception ex)
            {
                res.PedidoID = -1;
            }
            return res;
        }

        public bool UpdateDetallePedido(TDetallePedido[] Datos)
        {
            try
            {
                string Command = "";
                foreach (TDetallePedido DetallePedido in Datos)
                {

                    if (DetallePedido.DetallePedidoID < 0)
                    {
                        DetallePedido.DetallePedidoID = Folio("DetallePedidoID", "");
                        Command = "cmdDetallePedidoInserta";
                    }
                    else
                        Command = "cmdDetallePedidoUpdate";

                    using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, Command,
                        new string[]
                        {
                            "DetallePedidoID","Precio","Subtotal","IVA","IEPS","Total","Descuento",
                            "NoItems","PedidoID","VehiculoID","ProductoID","Volumen" ,"TerminalID"
                        },
                        new object[]
                        {
                             DetallePedido.DetallePedidoID,DetallePedido.Precio,DetallePedido.Subtotal,
                             DetallePedido.IVA,DetallePedido.IEPS,DetallePedido.Total,
                             DetallePedido.Descuento,DetallePedido.NoItems, DetallePedido.PedidoID,
                             DetallePedido.VehiculoID,DetallePedido.ProductoID,DetallePedido.Volumen,
                             DetallePedido.TerminalID
                        }
                        ))
                    {
                        lcommand.ExecuteNonQuery();
                    }

                }

                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public int GenerarFactura(TPedido Datos, TDetallePedido detallePedido)
        {
            try
            {
                int MovimientoID;
                int FacturaID;
                int DetalleFactura;
                int factura;
                //Generar un nuevo Movimiento
                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertaMovimiento", new string[] { "FechaMovimiento", "FechaVencimiento", "Referencia", "Ejercicio", "Periodo", "CargoAbono", "Cargo", "Abono", "FechaRegistro", "Origen", "AfectaSaldos", "TipoMovimientoID", "UsuarioID", "EstacionID" },
                                                                                                                 new object[] { Datos.Fecha, Datos.FechaModificacion, "Facturando", Datos.Ejercisio, Datos.Periodo, "C", "C", "", DateTime.Today, "Auto", "si", 12, Datos.UsuarioID, Datos.EstacionID }))
                {
                    MovimientoID = int.Parse(lcommand.ExecuteScalar().ToString());
                    //return MovimientoID;
                    FacturaID = InsertarFactura(Datos.Serie, Datos.Folio, Datos.Fecha, Datos.Ejercisio, Datos.Periodo, Datos.Dia, Datos.FechaModificacion, Datos.IVA, Datos.Observacion, 1, -1, 1, Datos.EstacionID, 1, MovimientoID);

                    DetalleFactura = InsertarDetalleFactura(int.Parse(detallePedido.Volumen.ToString()), detallePedido.Precio, detallePedido.Subtotal, detallePedido.IVA, detallePedido.IEPS, detallePedido.Total, detallePedido.Descuento, detallePedido.NoItems, FacturaID, detallePedido.ProductoID);

                    UpdateSaldoCargoPedido(detallePedido.Total, Datos.EstacionID);

                    factura = UpdatePedidoFactura(Datos.PedidoID, FacturaID);
                }
                return factura;

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public bool GuardarSaldo(TSaldo Datos)
        {
            try
            {
                IDbCommand commandSaldo;
                using (IDataReader reader = this.ServiceSchema.GetDataReader(this.Connection, "spSaldo", new string[] { "EstacionID" }, new object[] { Datos.EstacionID }, out commandSaldo))

                    if (reader.Read())
                    {

                        if (Datos.LimiteCredito != (double)reader["LimiteCredito"])
                        {
                            Datos.Saldo = (double)reader["Saldo"];
                            Datos.Saldo += (Datos.LimiteCredito - (double)reader["LimiteCredito"]);
                        }
                        using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "cmdActualizaSaldo", new string[] {"EstacionID","LimiteCredito", "CreditoUsado"
                     ,"Saldo"}, new object[] {
                         Datos.EstacionID, Datos.LimiteCredito,(double)reader["CreditoUsado"],Datos.Saldo}))
                        {
                            reader.Close();
                            commandSaldo.Dispose();
                            lcommand.ExecuteNonQuery();
                            return true;
                        }
                    }
                    else
                    {
                        using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "cmdInsertarSaldo", new string[] {"EstacionID","LimiteCredito", "CreditoUsado"
                     ,"Saldo"}, new object[] {
                         Datos.EstacionID, Datos.LimiteCredito,Datos.CreditoUsado,Datos.LimiteCredito}))
                        {
                            reader.Close();
                            commandSaldo.Dispose();
                            lcommand.ExecuteNonQuery();
                            return true;
                        }
                    }
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public int InsertarFactura(string Serie, int Folio, DateTime Fecha, int Ejercicio, int Periodo, int Dia, DateTime FechaVencimiento, double ImpuestoPorcentaje, string Observacion, int FacturaUsoID, int FormaPagoID, int MetodoPagoID, int EstacionID, int ConfiguracionID, int MovimientoID)
        {
            try
            {
                //Generar una nueva Factura y Detalle Factura
                int FacturaID;
                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarFactura", new string[]
                { "Serie", "Folio", "Fecha", "Ejercicio", "Periodo", "Dia", "FechaVencimiento", "ImpuestoPorcentaje","Status", "Observacion", "FacturaUsoID", "FormaPagoID", "MetodoPagoID", "EstacionID", "ConfiguracionID", "MovimientoID" },
                                                                                                                 new object[]
                { Serie, Folio, Fecha,Ejercicio, Periodo,Dia,FechaVencimiento,ImpuestoPorcentaje,true,Observacion,FacturaUsoID,FormaPagoID,MetodoPagoID,EstacionID,ConfiguracionID,MovimientoID}))
                {
                    FacturaID = int.Parse(lcommand.ExecuteScalar().ToString());

                }
                return FacturaID;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int InsertarDetalleFactura(int Cantidad, double Precio, double SubTotal, double IVA, double IEPS, double Total, double Descuento, int NoItems, int FacturaID, int ProductoID)
        {
            try
            {
                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "InsertarDetalleFactura", new string[]
                { "Cantidad", "Precio", "SubTotal", "IVA", "IEPS", "Total", "Descuento", "NoItems", "FacturaID", "ProductoID"},
                new object[]
                { Cantidad, Precio, SubTotal,IVA, IEPS,Total,Descuento,NoItems,FacturaID,ProductoID}))
                {
                    return int.Parse(lcommand.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public double UpdateSaldoCargoPedido(double Saldo, int EstacionID)
        {
            try
            {
                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "UpdateSaldoCargoPedido", new string[]
                {"Saldo", "EstacionID"},
                new object[]
                {Saldo,EstacionID}))
                {
                    return double.Parse(lcommand.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public int UpdatePedidoFactura(int PedidoID, int FacturaID)
        {
            try
            {
                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "UpdatePedidoFactura", new string[]
                {"PedidoID", "FacturaID"},
                new object[]
                {PedidoID,FacturaID}))
                {
                    return int.Parse(lcommand.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int GuardaPedido(TPedido pedido)
        {
            int res = -1;
            try
            {
                using (IDbCommand lCommand = this.ServiceSchema.NewCommand(this.Connection, "InsertPedido", new string[] { "PedidoID", "Serie", "Folio", "Fecha", "FechaModificacion", "Ejercicio", "Periodo", "Dia", "SubTotal", "IVA", "IEPS", "Total", "Descuento", "Observacion", "EstacionID", "ConfiguracionID", "UsuarioID", "StatusID" }, new object[] { pedido.PedidoID, pedido.Serie, pedido.Folio, pedido.Fecha, pedido.FechaModificacion, pedido.Ejercisio, pedido.Periodo, pedido.Dia, pedido.Subtotal, pedido.IVA, pedido.IEPS, pedido.Total, pedido.Descuento, pedido.Observacion, pedido.EstacionID, pedido.ConfiguracionID, pedido.UsuarioID, pedido.StatusID }))
                {
                    res = int.Parse(lCommand.ExecuteScalar().ToString());
                }
                return res;
            }
            catch (Exception ex)
            {

                return res;
            }

        }

        public int GuardaDetallePedido(TDetallePedido Datos)
        {
            int res = -1;
            try
            {
                using (IDbCommand lCommand = this.ServiceSchema.NewCommand(this.Connection, "InsertDetallePedido", new string[] { "DetallePedidoID", "Descuento", "IEPS", "IVA", "NoItems", "PedidoID", "Precio", "ProductoID", "SubTotal", "TerminalID", "Total", "VehiculoID", "Volumen" }, new object[] { Datos.DetallePedidoID, Datos.Descuento, Datos.IEPS, Datos.IVA, Datos.NoItems, Datos.PedidoID, Datos.Precio, Datos.ProductoID, Datos.Subtotal, Datos.TerminalID, Datos.Total, Datos.VehiculoID, Datos.Volumen }))
                {
                    res = int.Parse(lCommand.ExecuteScalar().ToString());
                }
                return res;
            }
            catch (Exception ex)
            {

                return res;
            }

        }

        public TEstacion GetEstacion(string Datos)
        {
            try
            {
                TEstacion est = new TEstacion();
                IDbCommand command;


                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "cmdEstacion", new string[] { "Datos" }, new object[] { Datos }))
                {
                    IDataReader reader = lcommand.ExecuteReader();
                    while (reader.Read())
                    {

                        est.EstacionID = (int)(reader["EstacionID"] != DBNull.Value ? reader["EstacionID"] : "");
                        est.Nombre = (string)(reader["Nombre"] != DBNull.Value ? reader["Nombre"] : "");
                        est.RazonSocial = (string)(reader["RazonSocial"] != DBNull.Value ? reader["RazonSocial"] : "");
                        est.NombreGrupo = (string)(reader["NombreGrupo"] != DBNull.Value ? reader["NombreGrupo"] : "");
                        est.Calle = (string)(reader["Calle"] != DBNull.Value ? reader["Calle"] : "");
                        est.NoInterior = (string)(reader["NoInterior"] != DBNull.Value ? reader["NoInterior"] : "");
                        est.NoExterior = (string)(reader["NoExterior"] != DBNull.Value ? reader["NoExterior"] : "");
                        est.Ciudad = (string)(reader["Ciudad"] != DBNull.Value ? reader["Ciudad"] : "");
                        est.Municipio = (string)(reader["Municipio"] != DBNull.Value ? reader["Municipio"] : "");
                        est.Estado = (string)(reader["Estado"] != DBNull.Value ? reader["Estado"] : "");
                        est.NombreZona = (string)(reader["NombreZona"] != DBNull.Value ? reader["NombreZona"] : "");
                        est.NombreGrupo = (string)(reader["NombreGrupo"] != DBNull.Value ? reader["NombreGrupo"] : "");
                    }
                }
                return est;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public TVendedor GetVendedor(string Datos)
        {
            try
            {
                TVendedor est = new TVendedor();
                IDbCommand command;


                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "cmdBuscarVendedor", new string[] { "Datos" }, new object[] { Datos }))
                {
                    IDataReader reader = lcommand.ExecuteReader();
                    while (reader.Read())
                    {

                        est.VendedorID = (int)(reader["VendedorID"] != DBNull.Value ? reader["VendedorID"] : "");
                        est.Nombre = (string)(reader["Nombre"] != DBNull.Value ? reader["Nombre"] : "");
                        est.Telefono = (string)(reader["Telefono"] != DBNull.Value ? reader["Telefono"] : "");
                        est.Email = (string)(reader["Email"] != DBNull.Value ? reader["Email"] : "");
                    }
                }
                return est;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public bool CancelarPedido(string Datos)
        {
            try
            {
                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "cmdCancelarPedido", new string[]
                {"Datos"},
                new object[]
                {Datos}))
                {
                    lcommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public TCustomProductoIEPS[] CargarProductoIEPS ()
        {
            List<TCustomProductoIEPS> lstProductoIEPS = new List<TCustomProductoIEPS>();
            IDataReader reader=null;
            try
            {
                using (IDbCommand lcommand = this.ServiceSchema.NewCommand(this.Connection, "spProductoIEPSCargar"))
                {
                    reader = lcommand.ExecuteReader();
                    while (reader.Read())
                    {
                        lstProductoIEPS.Add
                    (new TCustomProductoIEPS()
                    {
                        TerminalID = (int)(reader["TerminalID"] != DBNull.Value ? reader["TerminalID"] : ""),
                        PIEPSID87 = (int)(reader["PIEPSID87"] != DBNull.Value ? reader["PIEPSID87"] : -1),
                        Precio87 = (double)(reader["87 Octanos"] != DBNull.Value ? reader["87 Octanos"] : (double)0),
                        IEPS87 = (double)(reader["IEPS87"] != DBNull.Value ? reader["IEPS87"] : (double)0),
                        PIEPSID91 = (int)(reader["PIEPS91"] != DBNull.Value ? reader["PIEPS91"] : -1),
                        Precio91 = (double)(reader["91 Octanos"] != DBNull.Value ? reader["91 Octanos"] : (double)0),
                        IEPS91 = (double)(reader["IEPS91"] != DBNull.Value ? reader["IEPS91"] : (double)0),
                        PIEPSIDDiesel = (int)(reader["PIEPSDIESEL"] != DBNull.Value ? reader["PIEPSDIESEL"] : -1),
                        PrecioDiesel = (double)(reader["Diesel"] != DBNull.Value ? reader["Diesel"] : (double)0),
                        IEPSDiesel = (double)(reader["IEPSDiesel"] != DBNull.Value ? reader["IEPSDiesel"] : (double)0),
                        IVA = (double)(reader["IVA"] != DBNull.Value ? reader["IVA"] : (double)0),
                        Ejercicio = (int)(reader["Ejercicio"] != DBNull.Value ? reader["Ejercicio"] : -1),
                        Periodo = (int)(reader["Periodo"] != DBNull.Value ? reader["Periodo"] : -1),
                        Dia = (int)(reader["Dia"] != DBNull.Value ? reader["Dia"] : -1),
                        Fecha = (DateTime)(reader["Fecha"] != DBNull.Value ? reader["Fecha"] : DateTime.MinValue),
                        UsuarioID = (int)(reader["UsuarioID"] != DBNull.Value ? reader["UsuarioID"] : -1),
                        Descripcion = (string)(reader["Descripcion"] != DBNull.Value ? reader["Descripcion"] : "")
                    }
                    );
                        
                    }
                    reader.Close();
                }

            }

            catch (Exception ex)
            {
                reader.Close();
            }

            TCustomProductoIEPS[] arrayProductoIEPS = lstProductoIEPS.ToArray();

            return arrayProductoIEPS;
        }
        public int InsertaMuestradeProducto(TMuestraProducto MuestraProducto)
        {

            //Inserta en la Tabla MuestraProducto la Muestra que realiza pemex y va en la Remision .

            int res= -1;
            MuestraProducto.MuestraProductoID = Folio("MuestraProductoID", "");

            DateTime FechaActual = Fecha();
            try
            {
                using (IDbCommand lCommand = this.ServiceSchema.NewCommand(this.Connection, "InsertMuestraProducto", new string[]
                { "MuestraProductoID", "Fecha", "TerminalID", "NoMuestra", "PesodeCarga", "Azufre", "Octanaje", "Adimensional", "ProductoID", "Observacion"},
                    new object[] { MuestraProducto.MuestraProductoID,FechaActual,MuestraProducto.TerminalID,MuestraProducto.NoMuestra,MuestraProducto.PesodeCarga,
                                MuestraProducto.Azufre,MuestraProducto.Octanaje,MuestraProducto.Adimensional,MuestraProducto.ProductoID,MuestraProducto.Observacion}))
                {
                    
                      res = int.Parse(lCommand.ExecuteScalar().ToString());
                    
                }
                return res;

            }
            catch
            {
                return -1;
            }
            
        }



    }
}
