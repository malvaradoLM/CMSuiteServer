//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPSuiteServer {
    using System;
    using System.Collections.Generic;
    using RemObjects.SDK;
    using RemObjects.SDK.Types;
    using RemObjects.SDK.Server;
    using RemObjects.SDK.Server.ClassFactories;
    using RemObjects.DataAbstract.Server;
    
    [System.Reflection.ObfuscationAttribute(Exclude=true)]
    public class RPLoginService_Invoker : RemObjects.DataAbstract.Server.SimpleLoginService_Invoker {
        public RPLoginService_Invoker() : 
                base() {
        }
    }
    [System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=false)]
    public class RPLoginService_Activator : object, RemObjects.SDK.Server.IServiceActivator {
        public RPLoginService_Activator() {
        }
        public RemObjects.SDK.IROService CreateInstance() {
            return new RPLoginService();
        }
    }
    [System.Reflection.ObfuscationAttribute(Exclude=true)]
    public class RPDataService_Invoker : RemObjects.DataAbstract.Server.DataAbstractService_Invoker {
        public RPDataService_Invoker() : 
                base() {
        }
        public static void Invoke_GuardaFactura(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TFactura Datos = ((TFactura)(@__Message.Read("Datos", typeof(TFactura), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                bool Result;
                Result = ((IRPDataService)(@__Instance)).GuardaFactura(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GuardaFacturaResponse");
                @__Message.WriteBoolean("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_NotaCredito(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                string NewParam = @__Message.ReadAnsiString("NewParam");
                string NewParam1 = @__Message.ReadAnsiString("NewParam1");
                string NewParam2 = @__Message.ReadAnsiString("NewParam2");
                string NewParam3 = @__Message.ReadAnsiString("NewParam3");
                TFactura Result;
                Result = ((IRPDataService)(@__Instance)).NotaCredito(NewParam, NewParam1, NewParam2, NewParam3);
                @__ObjectDisposer.Add(Result);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "NotaCreditoResponse");
                @__Message.Write("Result", Result, typeof(TFactura), RemObjects.SDK.StreamingFormat.Default);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_Fecha(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            System.DateTime Result;
            Result = ((IRPDataService)(@__Instance)).Fecha();
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "FechaResponse");
            @__Message.WriteDateTime("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_Folio(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            string Campo = @__Message.ReadAnsiString("Campo");
            string Serie = @__Message.ReadAnsiString("Serie");
            int Result;
            Result = ((IRPDataService)(@__Instance)).Folio(Campo, Serie);
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "FolioResponse");
            @__Message.WriteInt32("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_GuardaClienteNuevo(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TClienteNuevo Datos = ((TClienteNuevo)(@__Message.Read("Datos", typeof(TClienteNuevo), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                int Result;
                Result = ((IRPDataService)(@__Instance)).GuardaClienteNuevo(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GuardaClienteNuevoResponse");
                @__Message.WriteInt32("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_BuscarCliente(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                int ClienteID = @__Message.ReadInt32("ClienteID");
                TCliente Result;
                Result = ((IRPDataService)(@__Instance)).BuscarCliente(ClienteID);
                @__ObjectDisposer.Add(Result);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "BuscarClienteResponse");
                @__Message.Write("Result", Result, typeof(TCliente), RemObjects.SDK.StreamingFormat.Default);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_BuscarPedido(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                string Datos = @__Message.ReadAnsiString("Datos");
                TPedido Result;
                Result = ((IRPDataService)(@__Instance)).BuscarPedido(Datos);
                @__ObjectDisposer.Add(Result);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "BuscarPedidoResponse");
                @__Message.Write("Result", Result, typeof(TPedido), RemObjects.SDK.StreamingFormat.Default);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_UpdateDetallePedido(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TDetallePedido Datos = ((TDetallePedido)(@__Message.Read("Datos", typeof(TDetallePedido), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                bool Result;
                Result = ((IRPDataService)(@__Instance)).UpdateDetallePedido(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "UpdateDetallePedidoResponse");
                @__Message.WriteBoolean("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_GuardarSaldo(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TSaldo Datos = ((TSaldo)(@__Message.Read("Datos", typeof(TSaldo), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                bool Result;
                Result = ((IRPDataService)(@__Instance)).GuardarSaldo(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GuardarSaldoResponse");
                @__Message.WriteBoolean("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_GenerarFactura(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TPedido Datos = ((TPedido)(@__Message.Read("Datos", typeof(TPedido), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                int Result;
                Result = ((IRPDataService)(@__Instance)).GenerarFactura(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GenerarFacturaResponse");
                @__Message.WriteInt32("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_InsertarFactura(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            string Serie = @__Message.ReadAnsiString("Serie");
            int Folio = @__Message.ReadInt32("Folio");
            System.DateTime Fecha = @__Message.ReadDateTime("Fecha");
            int Ejercicio = @__Message.ReadInt32("Ejercicio");
            int Periodo = @__Message.ReadInt32("Periodo");
            int Dia = @__Message.ReadInt32("Dia");
            System.DateTime FechaVencimiento = @__Message.ReadDateTime("FechaVencimiento");
            double ImpuestoPorcentaje = @__Message.ReadDouble("ImpuestoPorcentaje");
            bool Status = @__Message.ReadBoolean("Status");
            string Observacion = @__Message.ReadAnsiString("Observacion");
            int FacturaUsoID = @__Message.ReadInt32("FacturaUsoID");
            int FormaPagoID = @__Message.ReadInt32("FormaPagoID");
            int MetodoPagoID = @__Message.ReadInt32("MetodoPagoID");
            int EstacionID = @__Message.ReadInt32("EstacionID");
            int ConfiguracionID = @__Message.ReadInt32("ConfiguracionID");
            int MovimientoID = @__Message.ReadInt32("MovimientoID");
            int Result;
            Result = ((IRPDataService)(@__Instance)).InsertarFactura(Serie, Folio, Fecha, Ejercicio, Periodo, Dia, FechaVencimiento, ImpuestoPorcentaje, Status, Observacion, FacturaUsoID, FormaPagoID, MetodoPagoID, EstacionID, ConfiguracionID, MovimientoID);
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "InsertarFacturaResponse");
            @__Message.WriteInt32("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_InsertarDetalleFactura(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            int Cantidad = @__Message.ReadInt32("Cantidad");
            double Precio = @__Message.ReadDouble("Precio");
            double SubTotal = @__Message.ReadDouble("SubTotal");
            double IVA = @__Message.ReadDouble("IVA");
            double IEPS = @__Message.ReadDouble("IEPS");
            double Total = @__Message.ReadDouble("Total");
            double Descuento = @__Message.ReadDouble("Descuento");
            int NoItems = @__Message.ReadInt32("NoItems");
            int FacturaID = @__Message.ReadInt32("FacturaID");
            int ProductoID = @__Message.ReadInt32("ProductoID");
            int Result;
            Result = ((IRPDataService)(@__Instance)).InsertarDetalleFactura(Cantidad, Precio, SubTotal, IVA, IEPS, Total, Descuento, NoItems, FacturaID, ProductoID);
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "InsertarDetalleFacturaResponse");
            @__Message.WriteInt32("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_UpdateSaldoCargoPedido(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            double Saldo = @__Message.ReadDouble("Saldo");
            int EstacionID = @__Message.ReadInt32("EstacionID");
            double Result;
            Result = ((IRPDataService)(@__Instance)).UpdateSaldoCargoPedido(Saldo, EstacionID);
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "UpdateSaldoCargoPedidoResponse");
            @__Message.WriteDouble("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_UpdatePedidoFactura(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            int PedidoID = @__Message.ReadInt32("PedidoID");
            int FacturaID = @__Message.ReadInt32("FacturaID");
            int Result;
            Result = ((IRPDataService)(@__Instance)).UpdatePedidoFactura(PedidoID, FacturaID);
            @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "UpdatePedidoFacturaResponse");
            @__Message.WriteInt32("Result", Result);
            @__Message.FinalizeMessage();
            @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
        }
        public static void Invoke_GuardaPedido(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TPedido Datos = ((TPedido)(@__Message.Read("Datos", typeof(TPedido), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                int Result;
                Result = ((IRPDataService)(@__Instance)).GuardaPedido(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GuardaPedidoResponse");
                @__Message.WriteInt32("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
        public static void Invoke_GuardaDetallePedido(RemObjects.SDK.IROService @__Instance, RemObjects.SDK.IMessage @__Message, RemObjects.SDK.Server.IServerChannelInfo @__ServerChannelInfo, out RemObjects.SDK.Server.ResponseOptions @__oResponseOptions) {
            RemObjects.SDK.ObjectDisposer @__ObjectDisposer = new RemObjects.SDK.ObjectDisposer(1);
            try {
                TDetallePedido Datos = ((TDetallePedido)(@__Message.Read("Datos", typeof(TDetallePedido), RemObjects.SDK.StreamingFormat.Default)));
                @__ObjectDisposer.Add(Datos);
                int Result;
                Result = ((IRPDataService)(@__Instance)).GuardaDetallePedido(Datos);
                @__Message.InitializeResponseMessage(@__ServerChannelInfo, "RPSuiteServer", "RPDataService", "GuardaDetallePedidoResponse");
                @__Message.WriteInt32("Result", Result);
                @__Message.FinalizeMessage();
                @__oResponseOptions = RemObjects.SDK.Server.ResponseOptions.roDefault;
            }
            finally {
                @__ObjectDisposer.Dispose();
            }
        }
    }
    [System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=false)]
    public class RPDataService_Activator : object, RemObjects.SDK.Server.IServiceActivator {
        public RPDataService_Activator() {
        }
        public RemObjects.SDK.IROService CreateInstance() {
            return new RPDataService();
        }
    }
}