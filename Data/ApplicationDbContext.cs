using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Zismed_Apis.Models;
using Zismed_Apis.Models.Dto;

namespace Zismed_Apis.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AceptaTerminosCondiciones> AceptaTerminosCondiciones { get; set; }

    public virtual DbSet<AdmisionImagenes> AdmisionImagenes { get; set; }

    public virtual DbSet<AdmisionLaboratorio> AdmisionLaboratorio { get; set; }

    public virtual DbSet<AfectacionesXresolucion> AfectacionesXresolucion { get; set; }

    public virtual DbSet<AfiliadosUpa> AfiliadosUpa { get; set; }

    public virtual DbSet<AgendaTareaAdjuntos> AgendaTareaAdjuntos { get; set; }

    public virtual DbSet<AgendaTareaAspNetUsers> AgendaTareaAspNetUsers { get; set; }

    public virtual DbSet<AgendaTareaComentarios> AgendaTareaComentarios { get; set; }

    public virtual DbSet<AgendaTareaHistorico> AgendaTareaHistorico { get; set; }

    public virtual DbSet<AgendaTareaHistoricoMovimientos> AgendaTareaHistoricoMovimientos { get; set; }

    public virtual DbSet<AgendaTareas> AgendaTareas { get; set; }

    public virtual DbSet<AlfaBetaAccioFar> AlfaBetaAccioFar { get; set; }

    public virtual DbSet<AlfaBetaBarextra> AlfaBetaBarextra { get; set; }

    public virtual DbSet<AlfaBetaExtraBarras> AlfaBetaExtraBarras { get; set; }

    public virtual DbSet<AlfaBetaFormas> AlfaBetaFormas { get; set; }

    public virtual DbSet<AlfaBetaGtin1> AlfaBetaGtin1 { get; set; }

    public virtual DbSet<AlfaBetaManExtra> AlfaBetaManExtra { get; set; }

    public virtual DbSet<AlfaBetaManPato> AlfaBetaManPato { get; set; }

    public virtual DbSet<AlfaBetaManualDat> AlfaBetaManualDat { get; set; }

    public virtual DbSet<AlfaBetaMonoDro> AlfaBetaMonoDro { get; set; }

    public virtual DbSet<AlfaBetaMultidro> AlfaBetaMultidro { get; set; }

    public virtual DbSet<AlfaBetaNuevadro> AlfaBetaNuevadro { get; set; }

    public virtual DbSet<AlfaBetaRegNueva> AlfaBetaRegNueva { get; set; }

    public virtual DbSet<AlfaBetaTipoUnid> AlfaBetaTipoUnid { get; set; }

    public virtual DbSet<AlfaBetaUPotenci> AlfaBetaUPotenci { get; set; }

    public virtual DbSet<AlfaBetaVias> AlfaBetaVias { get; set; }

    public virtual DbSet<AlfabetaTamanos> AlfabetaTamanos { get; set; }

    public virtual DbSet<AlimentacionVia> AlimentacionVia { get; set; }

    public virtual DbSet<AnaemnesisGeneral> AnaemnesisGeneral { get; set; }

    public virtual DbSet<AnaemnesisObstetricia> AnaemnesisObstetricia { get; set; }

    public virtual DbSet<AnaemnesisReducida> AnaemnesisReducida { get; set; }

    public virtual DbSet<AnalisisLaboratorio> AnalisisLaboratorio { get; set; }

    public virtual DbSet<AnalisisSocioEconomico> AnalisisSocioEconomico { get; set; }

    public virtual DbSet<Anamnesis> Anamnesis { get; set; }

    public virtual DbSet<AnamnesisDetalle> AnamnesisDetalle { get; set; }

    public virtual DbSet<AnamnesisRecienNacido> AnamnesisRecienNacido { get; set; }

    public virtual DbSet<AnamnesisRespuestas> AnamnesisRespuestas { get; set; }

    public virtual DbSet<AnemnesisPuerperio> AnemnesisPuerperio { get; set; }

    public virtual DbSet<AnestesiaFormulario> AnestesiaFormulario { get; set; }

    public virtual DbSet<AnestesiaMedicacion> AnestesiaMedicacion { get; set; }

    public virtual DbSet<AnestesiaMetodo> AnestesiaMetodo { get; set; }

    public virtual DbSet<AnestesiaPulso> AnestesiaPulso { get; set; }

    public virtual DbSet<AnestesiaRespiracion> AnestesiaRespiracion { get; set; }

    public virtual DbSet<ApgarRn> ApgarRn { get; set; }

    public virtual DbSet<Articulos> Articulos { get; set; }

    public virtual DbSet<ArticulosFarmaciaCis> ArticulosFarmaciaCis { get; set; }

    public virtual DbSet<AsientoXpartida> AsientoXpartida { get; set; }

    public virtual DbSet<AsistenciaEmpleado> AsistenciaEmpleado { get; set; }

    public virtual DbSet<AsistenciaMedicos> AsistenciaMedicos { get; set; }

    public virtual DbSet<AsistenciaMedicosPlanillas> AsistenciaMedicosPlanillas { get; set; }

    public virtual DbSet<AspNetMenu> AspNetMenu { get; set; }

    public virtual DbSet<AspNetMenuRoles> AspNetMenuRoles { get; set; }

    public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }

    public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<Bancos> Bancos { get; set; }

    public virtual DbSet<BancosPersonas> BancosPersonas { get; set; }

    public virtual DbSet<Barrios> Barrios { get; set; }

    public virtual DbSet<BaseCisb> BaseCisb { get; set; }

    public virtual DbSet<BienPatrimonialMovimientos> BienPatrimonialMovimientos { get; set; }

    public virtual DbSet<BienesPatrimoniales> BienesPatrimoniales { get; set; }

    public virtual DbSet<Bonos> Bonos { get; set; }

    public virtual DbSet<Camas> Camas { get; set; }

    public virtual DbSet<CambioContingente> CambioContingente { get; set; }

    public virtual DbSet<Cargos> Cargos { get; set; }

    public virtual DbSet<CategoriaProveedor> CategoriaProveedor { get; set; }

    public virtual DbSet<CategoriaTarea> CategoriaTarea { get; set; }

    public virtual DbSet<Categorias> Categorias { get; set; }

    public virtual DbSet<Centro> Centro { get; set; }

    public virtual DbSet<CentrosVacunacion> CentrosVacunacion { get; set; }

    public virtual DbSet<Centrosprueba> Centrosprueba { get; set; }

    public virtual DbSet<Cie10> Cie10 { get; set; }

    public virtual DbSet<Cie10Capitulos> Cie10Capitulos { get; set; }

    public virtual DbSet<CirujiaDetalle> CirujiaDetalle { get; set; }

    public virtual DbSet<Colores> Colores { get; set; }

    public virtual DbSet<Consentimientos> Consentimientos { get; set; }

    public virtual DbSet<Consulta> Consulta { get; set; }

    public virtual DbSet<ConsultasAmbulatorias> ConsultasAmbulatorias { get; set; }

    public virtual DbSet<Consultorios> Consultorios { get; set; }

    public virtual DbSet<ContableGastos> ContableGastos { get; set; }

    public virtual DbSet<ContableRecursos> ContableRecursos { get; set; }

    public virtual DbSet<Contactos> Contactos { get; set; }

    public virtual DbSet<ContactosEstrechos> ContactosEstrechos { get; set; }

    public virtual DbSet<Coseguro> Coseguro { get; set; }

    public virtual DbSet<CovidInstituciones> CovidInstituciones { get; set; }

    public virtual DbSet<CovidReportes> CovidReportes { get; set; }

    public virtual DbSet<CovidTipoReporte> CovidTipoReporte { get; set; }

    public virtual DbSet<CovidUsuario> CovidUsuario { get; set; }

    public virtual DbSet<CuentaBancaria> CuentaBancaria { get; set; }

    public virtual DbSet<CuentaBancariaDetalleMovimiento> CuentaBancariaDetalleMovimiento { get; set; }

    public virtual DbSet<CuentaMovConcepto> CuentaMovConcepto { get; set; }

    public virtual DbSet<CuentaTipoMovimiento> CuentaTipoMovimiento { get; set; }

    public virtual DbSet<CuentasBancos> CuentasBancos { get; set; }

    public virtual DbSet<CuentasContables> CuentasContables { get; set; }

    public virtual DbSet<CuestionarioTipoRespuesta> CuestionarioTipoRespuesta { get; set; }

    public virtual DbSet<Ddjjdetalle> Ddjjdetalle { get; set; }

    public virtual DbSet<Ddjjempleados> Ddjjempleados { get; set; }

    public virtual DbSet<Delegaciones> Delegaciones { get; set; }

    public virtual DbSet<Departamentos> Departamentos { get; set; }

    public virtual DbSet<DepositoDetalle> DepositoDetalle { get; set; }

    public virtual DbSet<DepositoEncabezado> DepositoEncabezado { get; set; }

    public virtual DbSet<DepositoIeestado> DepositoIeestado { get; set; }

    public virtual DbSet<DepositoIeestadoHistorico> DepositoIeestadoHistorico { get; set; }

    public virtual DbSet<DepositoIngresoEgreso> DepositoIngresoEgreso { get; set; }

    public virtual DbSet<DepositoServicio> DepositoServicio { get; set; }

    public virtual DbSet<DepositoTipoMovimiento> DepositoTipoMovimiento { get; set; }

    public virtual DbSet<Depositos> Depositos { get; set; }

    public virtual DbSet<DerivacionDetalleGuardia> DerivacionDetalleGuardia { get; set; }

    public virtual DbSet<DerivacionesDesde> DerivacionesDesde { get; set; }

    public virtual DbSet<DerivacionesEnvios> DerivacionesEnvios { get; set; }

    public virtual DbSet<DetalleAutorizaciones> DetalleAutorizaciones { get; set; }

    public virtual DbSet<DetalleImagenes> DetalleImagenes { get; set; }

    public virtual DbSet<DetalleIngresoEgreso> DetalleIngresoEgreso { get; set; }

    public virtual DbSet<DetalleTipoRespuesta> DetalleTipoRespuesta { get; set; }

    public virtual DbSet<DiagnosticosConsultas> DiagnosticosConsultas { get; set; }
    
    public virtual DbSet<DiagnosticoDto> DiagnosticoDto { get; set; }

    public virtual DbSet<DiagnosticosInternado> DiagnosticosInternado { get; set; }

    public virtual DbSet<DiagnosticosIosep> DiagnosticosIosep { get; set; }

    public virtual DbSet<Dias> Dias { get; set; }

    public virtual DbSet<DietasNodo> DietasNodo { get; set; }

    public virtual DbSet<DispositivoOxigeno> DispositivoOxigeno { get; set; }

    public virtual DbSet<Domicilios> Domicilios { get; set; }

    public virtual DbSet<Emfermeros> Emfermeros { get; set; }

    public virtual DbSet<EmfermerosXinstituciones> EmfermerosXinstituciones { get; set; }

    public virtual DbSet<EmpleadoCapacitacion> EmpleadoCapacitacion { get; set; }

    public virtual DbSet<EmpleadoCategorias> EmpleadoCategorias { get; set; }

    public virtual DbSet<EmpleadoDatoEducacion> EmpleadoDatoEducacion { get; set; }

    public virtual DbSet<EmpleadoDatoLaboral> EmpleadoDatoLaboral { get; set; }

    public virtual DbSet<EmpleadoDomicilio> EmpleadoDomicilio { get; set; }

    public virtual DbSet<EmpleadoGrupoConvivencia> EmpleadoGrupoConvivencia { get; set; }

    public virtual DbSet<EmpleadoInstitucion> EmpleadoInstitucion { get; set; }

    public virtual DbSet<EmpleadoIntumizacion> EmpleadoIntumizacion { get; set; }

    public virtual DbSet<EmpleadoTipoContrato> EmpleadoTipoContrato { get; set; }

    public virtual DbSet<EmpleadosHospital> EmpleadosHospital { get; set; }

    public virtual DbSet<EmpleadosSectoresPlanificado> EmpleadosSectoresPlanificado { get; set; }

    public virtual DbSet<EmpresasColectivos> EmpresasColectivos { get; set; }

    public virtual DbSet<EncabezadoAutorizaciones> EncabezadoAutorizaciones { get; set; }

    public virtual DbSet<EncabezadoResultado> EncabezadoResultado { get; set; }

    public virtual DbSet<EncuestasBot> EncuestasBot { get; set; }

    public virtual DbSet<EnfermedadCronica> EnfermedadCronica { get; set; }

    public virtual DbSet<Enfermeria> Enfermeria { get; set; }

    public virtual DbSet<EntidadesCapacitadoras> EntidadesCapacitadoras { get; set; }

    public virtual DbSet<EnvioEntreDeposito> EnvioEntreDeposito { get; set; }

    public virtual DbSet<EnvioEntreDepositoDetalle> EnvioEntreDepositoDetalle { get; set; }

    public virtual DbSet<Epicrisis> Epicrisis { get; set; }

    public virtual DbSet<EpicrisisDetalle> EpicrisisDetalle { get; set; }

    public virtual DbSet<EpicrisisPendiente> EpicrisisPendiente { get; set; }

    public virtual DbSet<EquipoPrestadores> EquipoPrestadores { get; set; }

    public virtual DbSet<EquipoPrestadoresHistorial> EquipoPrestadoresHistorial { get; set; }

    public virtual DbSet<Especialidades> Especialidades { get; set; }

    public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }

    public virtual DbSet<EstadoEquipo> EstadoEquipo { get; set; }

    public virtual DbSet<EventoDetalle> EventoDetalle { get; set; }

    public virtual DbSet<EventoEncabezado> EventoEncabezado { get; set; }

    public virtual DbSet<Evolucion> Evolucion { get; set; }

    public virtual DbSet<EvolucionZismedIosep> EvolucionZismedIosep { get; set; }

    public virtual DbSet<Expediente> Expediente { get; set; }

    public virtual DbSet<FarDetalleCompras> FarDetalleCompras { get; set; }

    public virtual DbSet<FarDetalleVentas> FarDetalleVentas { get; set; }

    public virtual DbSet<FarEncabezadoCompras> FarEncabezadoCompras { get; set; }

    public virtual DbSet<FarEncabezadoVenta> FarEncabezadoVenta { get; set; }

    public virtual DbSet<FarIdentificacionCompras> FarIdentificacionCompras { get; set; }

    public virtual DbSet<FarMedicamento> FarMedicamento { get; set; }

    public virtual DbSet<FarRemitoTemporalDetalle> FarRemitoTemporalDetalle { get; set; }

    public virtual DbSet<FarRemitoTemporalDetalleLoteVto> FarRemitoTemporalDetalleLoteVto { get; set; }

    public virtual DbSet<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezado { get; set; }

    public virtual DbSet<FarSucursales> FarSucursales { get; set; }

    public virtual DbSet<FarTipoComprobante> FarTipoComprobante { get; set; }

    public virtual DbSet<FarTipoEgreso> FarTipoEgreso { get; set; }

    public virtual DbSet<FarTipoEstadoEnvioDeposito> FarTipoEstadoEnvioDeposito { get; set; }

    public virtual DbSet<FarTipoEstadoRecepcionDeposito> FarTipoEstadoRecepcionDeposito { get; set; }

    public virtual DbSet<FarTipoIngreso> FarTipoIngreso { get; set; }

    public virtual DbSet<FarTipoMedicamento> FarTipoMedicamento { get; set; }

    public virtual DbSet<FarTipoMovimiento> FarTipoMovimiento { get; set; }

    public virtual DbSet<FarVentasPagos> FarVentasPagos { get; set; }

    public virtual DbSet<FarmaciaArticulo> FarmaciaArticulo { get; set; }

    public virtual DbSet<FarmaciaArticuloDeposito> FarmaciaArticuloDeposito { get; set; }

    public virtual DbSet<FarmaciaArticuloDepositoLoteVto> FarmaciaArticuloDepositoLoteVto { get; set; }

    public virtual DbSet<FarmaciaDeposito> FarmaciaDeposito { get; set; }

    public virtual DbSet<FarmaciaEgreso> FarmaciaEgreso { get; set; }

    public virtual DbSet<FarmaciaEgresoDetalle> FarmaciaEgresoDetalle { get; set; }

    public virtual DbSet<FarmaciaEnvioDeposito> FarmaciaEnvioDeposito { get; set; }

    public virtual DbSet<FarmaciaEnvioDepositoDetalle> FarmaciaEnvioDepositoDetalle { get; set; }

    public virtual DbSet<FarmaciaEnvioDepositoDetalleLoteVto> FarmaciaEnvioDepositoDetalleLoteVto { get; set; }

    public virtual DbSet<FarmaciaIngreso> FarmaciaIngreso { get; set; }

    public virtual DbSet<FarmaciaIngresoDetalle> FarmaciaIngresoDetalle { get; set; }

    public virtual DbSet<FarmaciaPresentacionesBusqueda> FarmaciaPresentacionesBusqueda { get; set; }

    public virtual DbSet<FarmaciaSucursalXusuario> FarmaciaSucursalXusuario { get; set; }

    public virtual DbSet<Feriado> Feriado { get; set; }

    public virtual DbSet<FeriadosAsuetos> FeriadosAsuetos { get; set; }

    public virtual DbSet<FojaQuirurjica> FojaQuirurjica { get; set; }

    public virtual DbSet<FondoPermanente> FondoPermanente { get; set; }

    public virtual DbSet<FondoPermanenteDetalle> FondoPermanenteDetalle { get; set; }

    public virtual DbSet<FondoPermanenteEstado> FondoPermanenteEstado { get; set; }

    public virtual DbSet<FormatoConsentimiento> FormatoConsentimiento { get; set; }

    public virtual DbSet<Funcion> Funcion { get; set; }

    public virtual DbSet<GrupoFamiliar> GrupoFamiliar { get; set; }

    public virtual DbSet<Grupos> Grupos { get; set; }

    public virtual DbSet<GruposPersonas> GruposPersonas { get; set; }

    public virtual DbSet<GuardiaAnamnesis> GuardiaAnamnesis { get; set; }

    public virtual DbSet<GuardiaCama> GuardiaCama { get; set; }

    public virtual DbSet<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; }

    public virtual DbSet<GuardiaDerivacionInterna> GuardiaDerivacionInterna { get; set; }

    public virtual DbSet<GuardiaRegistro> GuardiaRegistro { get; set; }

    public virtual DbSet<GuardiaSector> GuardiaSector { get; set; }

    public virtual DbSet<GuardiaSectoresDestino> GuardiaSectoresDestino { get; set; }

    public virtual DbSet<GuardiaTipoCuestionario> GuardiaTipoCuestionario { get; set; }

    public virtual DbSet<GuardiaTipoCuestionarioLista> GuardiaTipoCuestionarioLista { get; set; }

    public virtual DbSet<GuardiaTipoCuestionarioPregunta> GuardiaTipoCuestionarioPregunta { get; set; }

    public virtual DbSet<GuardiaTipoCuestionarioResultado> GuardiaTipoCuestionarioResultado { get; set; }

    public virtual DbSet<GuardiaTipoCuestionarioXsector> GuardiaTipoCuestionarioXsector { get; set; }

    public virtual DbSet<GuardiaTipoIngreso> GuardiaTipoIngreso { get; set; }

    public virtual DbSet<GyO> GyO { get; set; }

    public virtual DbSet<HabitacionXhabitacionPase> HabitacionXhabitacionPase { get; set; }

    public virtual DbSet<HabitacionesHospital> HabitacionesHospital { get; set; }

    public virtual DbSet<HabitacionesHospitalXusuario> HabitacionesHospitalXusuario { get; set; }

    public virtual DbSet<Hcsnomed> Hcsnomed { get; set; }

    public virtual DbSet<HcsnomedConcept> HcsnomedConcept { get; set; }

    public virtual DbSet<HistorialCama> HistorialCama { get; set; }

    public virtual DbSet<HistorialDiagDetalle> HistorialDiagDetalle { get; set; }

    public virtual DbSet<HistorialDiagnosticosInternacion> HistorialDiagnosticosInternacion { get; set; }

    public virtual DbSet<HistorialEmpleadoHospital> HistorialEmpleadoHospital { get; set; }

    public virtual DbSet<HistorialdeActualizacionInternaciones> HistorialdeActualizacionInternaciones { get; set; }

    public virtual DbSet<Hl7MensajesEnviados> Hl7MensajesEnviados { get; set; }

    public virtual DbSet<Hl7MensajesRecibidos> Hl7MensajesRecibidos { get; set; }

    public virtual DbSet<Hospital> Hospital { get; set; }

    public virtual DbSet<HospitalActividad> HospitalActividad { get; set; }

    public virtual DbSet<HospitalPartida> HospitalPartida { get; set; }

    public virtual DbSet<HospitalProyecto> HospitalProyecto { get; set; }

    public virtual DbSet<HospitalSubPrograma> HospitalSubPrograma { get; set; }

    public virtual DbSet<Hospitalizacion> Hospitalizacion { get; set; }

    public virtual DbSet<HospitalizacionObstetrica> HospitalizacionObstetrica { get; set; }

    public virtual DbSet<HospitalizacionObstetricaDetalle> HospitalizacionObstetricaDetalle { get; set; }

    public virtual DbSet<HospitalizacionPases> HospitalizacionPases { get; set; }

    public virtual DbSet<HuellasDigitales> HuellasDigitales { get; set; }

    public virtual DbSet<Iconos> Iconos { get; set; }

    public virtual DbSet<ImagenPedido> ImagenPedido { get; set; }

    public virtual DbSet<ImagenPedidoEstado> ImagenPedidoEstado { get; set; }

    public virtual DbSet<ImagenPractica> ImagenPractica { get; set; }

    public virtual DbSet<ImagenRegistro> ImagenRegistro { get; set; }

    public virtual DbSet<ImagenRegistroXestado> ImagenRegistroXestado { get; set; }

    public virtual DbSet<ImagenResultado> ImagenResultado { get; set; }

    public virtual DbSet<ImagenResultadoDetalle> ImagenResultadoDetalle { get; set; }

    public virtual DbSet<ImagenTipoOrgano> ImagenTipoOrgano { get; set; }

    public virtual DbSet<ImagenTipoPractica> ImagenTipoPractica { get; set; }

    public virtual DbSet<ImagenesXservicio> ImagenesXservicio { get; set; }

    public virtual DbSet<IndicacionesDieta> IndicacionesDieta { get; set; }

    public virtual DbSet<IndicacionesKinesiologia> IndicacionesKinesiologia { get; set; }

    public virtual DbSet<IndicacionesObservacionesGrales> IndicacionesObservacionesGrales { get; set; }

    public virtual DbSet<IndicacionesPosicion> IndicacionesPosicion { get; set; }

    public virtual DbSet<IndicacionesRegistroAplicacion> IndicacionesRegistroAplicacion { get; set; }

    public virtual DbSet<IndicacionesRegistroAplicacionDescartables> IndicacionesRegistroAplicacionDescartables { get; set; }

    public virtual DbSet<IndicacionesVentilacionMecanica> IndicacionesVentilacionMecanica { get; set; }

    public virtual DbSet<InformeCci> InformeCci { get; set; }

    public virtual DbSet<InformeDigital> InformeDigital { get; set; }

    public virtual DbSet<InformeGeneral> InformeGeneral { get; set; }

    public virtual DbSet<InstitucionTipoAislamientos> InstitucionTipoAislamientos { get; set; }

    public virtual DbSet<Instituciones> Instituciones { get; set; }

    public virtual DbSet<Interconsulta> Interconsulta { get; set; }

    public virtual DbSet<InternacionAcompanantes> InternacionAcompanantes { get; set; }

    public virtual DbSet<Internaciones> Internaciones { get; set; }

    public virtual DbSet<InternadoAislamiento> InternadoAislamiento { get; set; }

    public virtual DbSet<InternadosAfeccion> InternadosAfeccion { get; set; }

    public virtual DbSet<InternadosControl> InternadosControl { get; set; }

    public virtual DbSet<InternadosSectorIosep> InternadosSectorIosep { get; set; }

    public virtual DbSet<Intumizacion> Intumizacion { get; set; }

    public virtual DbSet<IosepDatosIngreso> IosepDatosIngreso { get; set; }

    public virtual DbSet<LabGrupoPractica> LabGrupoPractica { get; set; }

    public virtual DbSet<LabRegistroDetalle> LabRegistroDetalle { get; set; }

    public virtual DbSet<LabRegistroResultadosLog> LabRegistroResultadosLog { get; set; }

    public virtual DbSet<LabRegistroXestado> LabRegistroXestado { get; set; }

    public virtual DbSet<LabTipoMuestra> LabTipoMuestra { get; set; }

    public virtual DbSet<LabTipoPractica> LabTipoPractica { get; set; }

    public virtual DbSet<LabUnidadMedida> LabUnidadMedida { get; set; }

    public virtual DbSet<LaboratorioAgrupaSuma> LaboratorioAgrupaSuma { get; set; }

    public virtual DbSet<LaboratorioFormulaDetalle> LaboratorioFormulaDetalle { get; set; }

    public virtual DbSet<LaboratorioFormulas> LaboratorioFormulas { get; set; }

    public virtual DbSet<LaboratorioMetodos> LaboratorioMetodos { get; set; }

    public virtual DbSet<LaboratorioOperadores> LaboratorioOperadores { get; set; }

    public virtual DbSet<LaboratorioPracticaListaResultado> LaboratorioPracticaListaResultado { get; set; }

    public virtual DbSet<LaboratorioPracticaMuestra> LaboratorioPracticaMuestra { get; set; }

    public virtual DbSet<LaboratorioPracticas> LaboratorioPracticas { get; set; }

    public virtual DbSet<LaboratorioRegistro> LaboratorioRegistro { get; set; }

    public virtual DbSet<LaboratorioSecciones> LaboratorioSecciones { get; set; }

    public virtual DbSet<LaboratorioXsector> LaboratorioXsector { get; set; }

    public virtual DbSet<LaboratorioXusuario> LaboratorioXusuario { get; set; }

    public virtual DbSet<Laboratorios> Laboratorios { get; set; }

    public virtual DbSet<Localidades> Localidades { get; set; }

    public virtual DbSet<LogExcepciones> LogExcepciones { get; set; }

    public virtual DbSet<Logs> Logs { get; set; }

    public virtual DbSet<LoteRegPagos> LoteRegPagos { get; set; }

    public virtual DbSet<LoteRegXestado> LoteRegXestado { get; set; }

    public virtual DbSet<Lotes> Lotes { get; set; }

    public virtual DbSet<LugarRetira> LugarRetira { get; set; }

    public virtual DbSet<Mails> Mails { get; set; }

    public virtual DbSet<ManualDatCobertura> ManualDatCobertura { get; set; }

    public virtual DbSet<Marcas> Marcas { get; set; }

    public virtual DbSet<MedicacionDiscreta> MedicacionDiscreta { get; set; }

    public virtual DbSet<MedicacionInfusionContinua> MedicacionInfusionContinua { get; set; }

    public virtual DbSet<MedicacionInfusionContinuaDetalle> MedicacionInfusionContinuaDetalle { get; set; }

    public virtual DbSet<MedicacionPaciente> MedicacionPaciente { get; set; }

    public virtual DbSet<MedicacionPacienteDetalle> MedicacionPacienteDetalle { get; set; }

    public virtual DbSet<MedicacionPacienteHistorico> MedicacionPacienteHistorico { get; set; }

    public virtual DbSet<MedicacionVia> MedicacionVia { get; set; }

    public virtual DbSet<MedioCompra> MedioCompra { get; set; }

    public virtual DbSet<MetodoAnticonceptivo> MetodoAnticonceptivo { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }

    public virtual DbSet<MotivoConsulta> MotivoConsulta { get; set; }

    public virtual DbSet<MotivoGanador> MotivoGanador { get; set; }

    public virtual DbSet<MotivoProtegido> MotivoProtegido { get; set; }

    public virtual DbSet<MotivoProtegidoPaciente> MotivoProtegidoPaciente { get; set; }

    public virtual DbSet<MotivoProtegidoRol> MotivoProtegidoRol { get; set; }

    public virtual DbSet<MotivoSancionProveedor> MotivoSancionProveedor { get; set; }

    public virtual DbSet<MotivosAnula> MotivosAnula { get; set; }

    public virtual DbSet<MotivosConsultas> MotivosConsultas { get; set; }

    public virtual DbSet<MovilHospital> MovilHospital { get; set; }

    public virtual DbSet<MovimientosInternaciones> MovimientosInternaciones { get; set; }

    public virtual DbSet<MovimientosUsuario> MovimientosUsuario { get; set; }

    public virtual DbSet<Nbu2012Ed2016> Nbu2012Ed2016 { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NodoAdmision> NodoAdmision { get; set; }

    public virtual DbSet<NodoControlesDiarios> NodoControlesDiarios { get; set; }

    public virtual DbSet<NodoDietas> NodoDietas { get; set; }

    public virtual DbSet<NodoExamenFisico> NodoExamenFisico { get; set; }

    public virtual DbSet<NodoHisopado> NodoHisopado { get; set; }

    public virtual DbSet<NodoHisopadoResultado> NodoHisopadoResultado { get; set; }

    public virtual DbSet<NodoIngreso> NodoIngreso { get; set; }

    public virtual DbSet<NodoLugaresAltoRiesgo> NodoLugaresAltoRiesgo { get; set; }

    public virtual DbSet<NodoLugaresAltoRiesgoTrigger> NodoLugaresAltoRiesgoTrigger { get; set; }

    public virtual DbSet<NodoMovimientos> NodoMovimientos { get; set; }

    public virtual DbSet<NodoNotificacion> NodoNotificacion { get; set; }

    public virtual DbSet<NodoPacienteEstado> NodoPacienteEstado { get; set; }

    public virtual DbSet<NodoRegistroEnvioEmail> NodoRegistroEnvioEmail { get; set; }

    public virtual DbSet<NodoTipos> NodoTipos { get; set; }

    public virtual DbSet<Nododepartamentos> Nododepartamentos { get; set; }

    public virtual DbSet<Nodolocalidades> Nodolocalidades { get; set; }

    public virtual DbSet<NomCatLaboratorio> NomCatLaboratorio { get; set; }

    public virtual DbSet<NomExpDetallePagos> NomExpDetallePagos { get; set; }

    public virtual DbSet<NomExpRegXestado> NomExpRegXestado { get; set; }

    public virtual DbSet<NomExpediente> NomExpediente { get; set; }

    public virtual DbSet<NomExpedienteDetalle> NomExpedienteDetalle { get; set; }

    public virtual DbSet<NomListas> NomListas { get; set; }

    public virtual DbSet<NomServicios> NomServicios { get; set; }

    public virtual DbSet<NomTipoAtencion> NomTipoAtencion { get; set; }

    public virtual DbSet<Nomenclador> Nomenclador { get; set; }

    public virtual DbSet<Nomenclador2> Nomenclador2 { get; set; }

    public virtual DbSet<NomencladorResolucion> NomencladorResolucion { get; set; }

    public virtual DbSet<NotaPedido> NotaPedido { get; set; }

    public virtual DbSet<NotaPedidoDetalle> NotaPedidoDetalle { get; set; }

    public virtual DbSet<NotaPedidoEstado> NotaPedidoEstado { get; set; }

    public virtual DbSet<NotaPedidoEstadoHistorico> NotaPedidoEstadoHistorico { get; set; }

    public virtual DbSet<NotaPedidoPresupuesto> NotaPedidoPresupuesto { get; set; }

    public virtual DbSet<NotaPedidoPresupuestoDetalle> NotaPedidoPresupuestoDetalle { get; set; }

    public virtual DbSet<NotificacionCovidResidencia> NotificacionCovidResidencia { get; set; }

    public virtual DbSet<NotificacionDengue> NotificacionDengue { get; set; }

    public virtual DbSet<NotificacionesCovid> NotificacionesCovid { get; set; }

    public virtual DbSet<NumeradorHc> NumeradorHc { get; set; }

    public virtual DbSet<ObraSocial> ObraSocial { get; set; }

    public virtual DbSet<Observaciones> Observaciones { get; set; }

    public virtual DbSet<ObservacionesVarias> ObservacionesVarias { get; set; }

    public virtual DbSet<Ocupacion> Ocupacion { get; set; }

    public virtual DbSet<Odontograma> Odontograma { get; set; }

    public virtual DbSet<Oftalmologia> Oftalmologia { get; set; }

    public virtual DbSet<OrdenCompra> OrdenCompra { get; set; }

    public virtual DbSet<OrdenCompraAutorizaRecepParcial> OrdenCompraAutorizaRecepParcial { get; set; }

    public virtual DbSet<OrdenCompraEstado> OrdenCompraEstado { get; set; }

    public virtual DbSet<OrdenCompraEstadoHistorico> OrdenCompraEstadoHistorico { get; set; }

    public virtual DbSet<OrdenCompraRecepcion> OrdenCompraRecepcion { get; set; }

    public virtual DbSet<OrdenCompraRecepcionDetalle> OrdenCompraRecepcionDetalle { get; set; }

    public virtual DbSet<OrdenLaboratorioPracticas> OrdenLaboratorioPracticas { get; set; }

    public virtual DbSet<OrdenPago> OrdenPago { get; set; }

    public virtual DbSet<OrdenPagoAsiento> OrdenPagoAsiento { get; set; }

    public virtual DbSet<OrdenPagoDetalle> OrdenPagoDetalle { get; set; }

    public virtual DbSet<OrdenPagoEstado> OrdenPagoEstado { get; set; }

    public virtual DbSet<OrdenPagoEstadoHistorico> OrdenPagoEstadoHistorico { get; set; }

    public virtual DbSet<OrdenPagoRetenciones> OrdenPagoRetenciones { get; set; }

    public virtual DbSet<OrientacionDeriva> OrientacionDeriva { get; set; }

    public virtual DbSet<OrientacionObstetrica> OrientacionObstetrica { get; set; }

    public virtual DbSet<OrientacionObstetricaFormulario> OrientacionObstetricaFormulario { get; set; }

    public virtual DbSet<OrigenEstado> OrigenEstado { get; set; }

    public virtual DbSet<OtrosCentros> OtrosCentros { get; set; }

    public virtual DbSet<PacienteAntecedentes> PacienteAntecedentes { get; set; }

    public virtual DbSet<PacienteEstado> PacienteEstado { get; set; }

    public virtual DbSet<PacienteExtraInfo> PacienteExtraInfo { get; set; }

    public virtual DbSet<PacienteFotos> PacienteFotos { get; set; }

    public virtual DbSet<PacientePrevencionPromocion> PacientePrevencionPromocion { get; set; }

    public virtual DbSet<PacienteSitSocioEconomica> PacienteSitSocioEconomica { get; set; }

    public virtual DbSet<Pacientes> Pacientes { get; set; }

    public virtual DbSet<PacientesObraSocial> PacientesObraSocial { get; set; }
    public virtual DbSet<PacienteGuardiaDto> PacienteGuardiaDtos { get; set; }

    public virtual DbSet<Paises> Paises { get; set; }

    public virtual DbSet<ParametrosHoraHabil> ParametrosHoraHabil { get; set; }

    public virtual DbSet<ParametrosHoraHabilDetalle> ParametrosHoraHabilDetalle { get; set; }

    public virtual DbSet<PartidasAafectar> PartidasAafectar { get; set; }

    public virtual DbSet<Patologias> Patologias { get; set; }

    public virtual DbSet<PedIntDetalleRetirar> PedIntDetalleRetirar { get; set; }

    public virtual DbSet<PedIntDetalleRetirarFarmacia> PedIntDetalleRetirarFarmacia { get; set; }

    public virtual DbSet<PedIntEstado> PedIntEstado { get; set; }

    public virtual DbSet<PedIntEstadoHistorico> PedIntEstadoHistorico { get; set; }

    public virtual DbSet<PedidoInterno> PedidoInterno { get; set; }

    public virtual DbSet<PedidoInternoDestinos> PedidoInternoDestinos { get; set; }

    public virtual DbSet<PedidoInternoDetalle> PedidoInternoDetalle { get; set; }

    public virtual DbSet<PedidoInternoEncabezado> PedidoInternoEncabezado { get; set; }

    public virtual DbSet<PedidoInternoFarmacia> PedidoInternoFarmacia { get; set; }

    public virtual DbSet<PedidoInternoFarmaciaDetalle> PedidoInternoFarmaciaDetalle { get; set; }

    public virtual DbSet<PedidoInternoMotivo> PedidoInternoMotivo { get; set; }

    public virtual DbSet<PedidoInternoNotaPedido> PedidoInternoNotaPedido { get; set; }

    public virtual DbSet<PedidoLugarEntrega> PedidoLugarEntrega { get; set; }

    public virtual DbSet<PedidoPrioridad> PedidoPrioridad { get; set; }

    public virtual DbSet<PedidoSector> PedidoSector { get; set; }

    public virtual DbSet<PedidosEnConsultorio> PedidosEnConsultorio { get; set; }

    public virtual DbSet<PendientesServicios> PendientesServicios { get; set; }

    public virtual DbSet<PerfilAnalisisLaboratorio> PerfilAnalisisLaboratorio { get; set; }

    public virtual DbSet<PerfilDetalleLaboratorio> PerfilDetalleLaboratorio { get; set; }

    public virtual DbSet<PerfilGeneralLaboratorio> PerfilGeneralLaboratorio { get; set; }

    public virtual DbSet<PersClasificacionInasistencia> PersClasificacionInasistencia { get; set; }

    public virtual DbSet<PersEstadoSolicitud> PersEstadoSolicitud { get; set; }

    public virtual DbSet<PersLicencia> PersLicencia { get; set; }

    public virtual DbSet<PersPlanificacion> PersPlanificacion { get; set; }

    public virtual DbSet<PersPlanificacionDetalle> PersPlanificacionDetalle { get; set; }

    public virtual DbSet<PersPlanificacionReloj> PersPlanificacionReloj { get; set; }

    public virtual DbSet<PersPlanificacionRelojChek> PersPlanificacionRelojChek { get; set; }

    public virtual DbSet<PersPlanificacionRelojTurno> PersPlanificacionRelojTurno { get; set; }

    public virtual DbSet<PersRegistro> PersRegistro { get; set; }

    public virtual DbSet<PersReloj> PersReloj { get; set; }

    public virtual DbSet<PersRestriccion> PersRestriccion { get; set; }

    public virtual DbSet<PersRestriccionXantiguedad> PersRestriccionXantiguedad { get; set; }

    public virtual DbSet<PersSolicitudPermiso> PersSolicitudPermiso { get; set; }

    public virtual DbSet<PersTipoLicencia> PersTipoLicencia { get; set; }

    public virtual DbSet<PersTipoTrabajo> PersTipoTrabajo { get; set; }

    public virtual DbSet<PersTurno> PersTurno { get; set; }

    public virtual DbSet<PersVacacionAnual> PersVacacionAnual { get; set; }

    public virtual DbSet<PersVacacionAnualHistorial> PersVacacionAnualHistorial { get; set; }

    public virtual DbSet<PersonaTipo> PersonaTipo { get; set; }

    public virtual DbSet<Personas> Personas { get; set; }

    public virtual DbSet<PersonasTipoDetalle> PersonasTipoDetalle { get; set; }

    public virtual DbSet<PisosHospital> PisosHospital { get; set; }

    public virtual DbSet<Plan> Plan { get; set; }

    public virtual DbSet<PlanObraSocial> PlanObraSocial { get; set; }

    public virtual DbSet<Planes> Planes { get; set; }

    public virtual DbSet<PlanesInstituciones> PlanesInstituciones { get; set; }

    public virtual DbSet<PlanillaControl> PlanillaControl { get; set; }

    public virtual DbSet<PlanillaTurnos> PlanillaTurnos { get; set; }

    public virtual DbSet<PracticaTurnos> PracticaTurnos { get; set; }

    public virtual DbSet<PracticasBase> PracticasBase { get; set; }

    public virtual DbSet<PracticasEstado> PracticasEstado { get; set; }

    public virtual DbSet<PracticasEstados> PracticasEstados { get; set; }

    public virtual DbSet<PracticasMedicas> PracticasMedicas { get; set; }

    public virtual DbSet<PracticasMedicasTipo> PracticasMedicasTipo { get; set; }

    public virtual DbSet<PracticasOrigen> PracticasOrigen { get; set; }

    public virtual DbSet<PracticasXtipoInternacion> PracticasXtipoInternacion { get; set; }

    public virtual DbSet<Prescripcion> Prescripcion { get; set; }

    public virtual DbSet<PrescripcionDetalle> PrescripcionDetalle { get; set; }

    public virtual DbSet<PrescripcionEncabezado> PrescripcionEncabezado { get; set; }

    public virtual DbSet<PrescripcionTipoIndicacion> PrescripcionTipoIndicacion { get; set; }

    public virtual DbSet<PrestacionesOdontologicas> PrestacionesOdontologicas { get; set; }

    public virtual DbSet<PrestadorDias> PrestadorDias { get; set; }

    public virtual DbSet<PrestadorXservicio> PrestadorXservicio { get; set; }

    public virtual DbSet<Prestadores> Prestadores { get; set; }

    public virtual DbSet<PrestadoresAsignados> PrestadoresAsignados { get; set; }

    public virtual DbSet<PrestadoresDiasExcepcion> PrestadoresDiasExcepcion { get; set; }

    public virtual DbSet<PrestadoresEspecialidades> PrestadoresEspecialidades { get; set; }

    public virtual DbSet<PrestadoresInstituciones> PrestadoresInstituciones { get; set; }

    public virtual DbSet<PrestadoresServicios> PrestadoresServicios { get; set; }

    public virtual DbSet<PresupuestoAnual> PresupuestoAnual { get; set; }

    public virtual DbSet<PresupuestoAnualAfectacion> PresupuestoAnualAfectacion { get; set; }

    public virtual DbSet<PresupuestoAnualDetalle> PresupuestoAnualDetalle { get; set; }

    public virtual DbSet<PresupuestoAnualMovimiento> PresupuestoAnualMovimiento { get; set; }

    public virtual DbSet<PresupuestoCompromiso> PresupuestoCompromiso { get; set; }

    public virtual DbSet<PresupuestoConcepto> PresupuestoConcepto { get; set; }

    public virtual DbSet<PresupuestoMotivoGanador> PresupuestoMotivoGanador { get; set; }

    public virtual DbSet<PresupuestoMovEntrePartidas> PresupuestoMovEntrePartidas { get; set; }

    public virtual DbSet<PresupuestoResolucion> PresupuestoResolucion { get; set; }

    public virtual DbSet<PresupuestoResolucionEstado> PresupuestoResolucionEstado { get; set; }

    public virtual DbSet<PresupuestoResolucionEstadoHistorial> PresupuestoResolucionEstadoHistorial { get; set; }

    public virtual DbSet<ProcedimientoEnfermeria> ProcedimientoEnfermeria { get; set; }

    public virtual DbSet<ProcedimientoEnfermeriaDetalle> ProcedimientoEnfermeriaDetalle { get; set; }

    public virtual DbSet<Productos> Productos { get; set; }

    public virtual DbSet<ProductosXdeposito> ProductosXdeposito { get; set; }

    public virtual DbSet<Profesion> Profesion { get; set; }

    public virtual DbSet<ProveedorCategoriaPertenece> ProveedorCategoriaPertenece { get; set; }

    public virtual DbSet<ProveedorSancion> ProveedorSancion { get; set; }

    public virtual DbSet<Proveedores> Proveedores { get; set; }

    public virtual DbSet<Provincias> Provincias { get; set; }

    public virtual DbSet<ProyectoEstado> ProyectoEstado { get; set; }

    public virtual DbSet<QuirofanoDias> QuirofanoDias { get; set; }

    public virtual DbSet<Quirofanos> Quirofanos { get; set; }

    public virtual DbSet<RecetaIndicaciones> RecetaIndicaciones { get; set; }

    public virtual DbSet<RecetaIndicacionesDetalle> RecetaIndicacionesDetalle { get; set; }

    public virtual DbSet<RecetaIndicacionesTurno> RecetaIndicacionesTurno { get; set; }

    public virtual DbSet<RecetaIndicacionesTurnoDescripcion> RecetaIndicacionesTurnoDescripcion { get; set; }

    public virtual DbSet<RegistroHistorialCambioSector> RegistroHistorialCambioSector { get; set; }

    public virtual DbSet<RegistroModificaciones> RegistroModificaciones { get; set; }

    public virtual DbSet<RegistroPedidosPendientes> RegistroPedidosPendientes { get; set; }

    public virtual DbSet<RegistroPracticaDetalle> RegistroPracticaDetalle { get; set; }

    public virtual DbSet<RegistroPracticas> RegistroPracticas { get; set; }

    public virtual DbSet<RegistrosContingente> RegistrosContingente { get; set; }

    public virtual DbSet<ReportSchemas> ReportSchemas { get; set; }

    public virtual DbSet<Respiradores> Respiradores { get; set; }

    public virtual DbSet<RespuestasDeFormulario1> RespuestasDeFormulario1 { get; set; }

    public virtual DbSet<ResultadosInformes> ResultadosInformes { get; set; }

    public virtual DbSet<RevistaSala> RevistaSala { get; set; }

    public virtual DbSet<RevistaSalaObstetricia> RevistaSalaObstetricia { get; set; }

    public virtual DbSet<SatuacionRn> SatuacionRn { get; set; }

    public virtual DbSet<SectorPedidoInternoXusuario> SectorPedidoInternoXusuario { get; set; }

    public virtual DbSet<SectorPlanificacion> SectorPlanificacion { get; set; }

    public virtual DbSet<SectoresHospital> SectoresHospital { get; set; }

    public virtual DbSet<SectoresHospitalXusuario> SectoresHospitalXusuario { get; set; }

    public virtual DbSet<Servicios> Servicios { get; set; }

    public virtual DbSet<ServiciosDias> ServiciosDias { get; set; }

    public virtual DbSet<ServiciosXroles> ServiciosXroles { get; set; }

    public virtual DbSet<ServiciosXusuario> ServiciosXusuario { get; set; }

    public virtual DbSet<Sexo> Sexo { get; set; }

    public virtual DbSet<ShockRoomAnamnesis> ShockRoomAnamnesis { get; set; }

    public virtual DbSet<ShockRoomAnamnesisDetalle> ShockRoomAnamnesisDetalle { get; set; }

    public virtual DbSet<ShockRoomCamas> ShockRoomCamas { get; set; }

    public virtual DbSet<ShockRoomDerivAlHospital> ShockRoomDerivAlHospital { get; set; }

    public virtual DbSet<ShockRoomDerivInt> ShockRoomDerivInt { get; set; }

    public virtual DbSet<ShockRoomEventoDetalle> ShockRoomEventoDetalle { get; set; }

    public virtual DbSet<ShockRoomEventoEncabezado> ShockRoomEventoEncabezado { get; set; }

    public virtual DbSet<ShockRoomRegistro> ShockRoomRegistro { get; set; }

    public virtual DbSet<ShockRoomServicios> ShockRoomServicios { get; set; }

    public virtual DbSet<ShockRoomTipoAnamnesis> ShockRoomTipoAnamnesis { get; set; }

    public virtual DbSet<SituacionLaboral> SituacionLaboral { get; set; }

    public virtual DbSet<SituacionTributaria> SituacionTributaria { get; set; }

    public virtual DbSet<SliderHome> SliderHome { get; set; }

    public virtual DbSet<Solicitudes> Solicitudes { get; set; }

    public virtual DbSet<SolicitudesApi> SolicitudesApi { get; set; }

    public virtual DbSet<Telefonos> Telefonos { get; set; }

    public virtual DbSet<TemperaturaRn> TemperaturaRn { get; set; }

    public virtual DbSet<TicketTotem> TicketTotem { get; set; }

    public virtual DbSet<TipoAceptacion> TipoAceptacion { get; set; }

    public virtual DbSet<TipoAcompañante> TipoAcompañante { get; set; }

    public virtual DbSet<TipoActividad> TipoActividad { get; set; }

    public virtual DbSet<TipoActualizacion> TipoActualizacion { get; set; }

    public virtual DbSet<TipoAdmisionHospital> TipoAdmisionHospital { get; set; }

    public virtual DbSet<TipoAislamiento> TipoAislamiento { get; set; }

    public virtual DbSet<TipoAltaIntenado> TipoAltaIntenado { get; set; }

    public virtual DbSet<TipoAnamnesis> TipoAnamnesis { get; set; }

    public virtual DbSet<TipoAntitetanica> TipoAntitetanica { get; set; }

    public virtual DbSet<TipoBeneficiario> TipoBeneficiario { get; set; }

    public virtual DbSet<TipoBuenaRegular> TipoBuenaRegular { get; set; }

    public virtual DbSet<TipoCama> TipoCama { get; set; }

    public virtual DbSet<TipoCapacitacion> TipoCapacitacion { get; set; }

    public virtual DbSet<TipoCasa> TipoCasa { get; set; }

    public virtual DbSet<TipoCbancos> TipoCbancos { get; set; }

    public virtual DbSet<TipoCirugia> TipoCirugia { get; set; }

    public virtual DbSet<TipoCompletoIncompletoNc> TipoCompletoIncompletoNc { get; set; }

    public virtual DbSet<TipoCompra> TipoCompra { get; set; }

    public virtual DbSet<TipoComprobante> TipoComprobante { get; set; }

    public virtual DbSet<TipoConsentimiento> TipoConsentimiento { get; set; }

    public virtual DbSet<TipoConsulta> TipoConsulta { get; set; }

    public virtual DbSet<TipoConsumirBono> TipoConsumirBono { get; set; }

    public virtual DbSet<TipoContactoCovid> TipoContactoCovid { get; set; }

    public virtual DbSet<TipoContactos> TipoContactos { get; set; }

    public virtual DbSet<TipoCuentaContable> TipoCuentaContable { get; set; }

    public virtual DbSet<TipoCuit> TipoCuit { get; set; }

    public virtual DbSet<TipoCuracion> TipoCuracion { get; set; }

    public virtual DbSet<TipoDeriva> TipoDeriva { get; set; }

    public virtual DbSet<TipoDiabetes> TipoDiabetes { get; set; }

    public virtual DbSet<TipoDieta> TipoDieta { get; set; }

    public virtual DbSet<TipoDiscapacidad> TipoDiscapacidad { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }

    public virtual DbSet<TipoDomicilio> TipoDomicilio { get; set; }

    public virtual DbSet<TipoEmergencia> TipoEmergencia { get; set; }

    public virtual DbSet<TipoEmpleado> TipoEmpleado { get; set; }

    public virtual DbSet<TipoEntidad> TipoEntidad { get; set; }

    public virtual DbSet<TipoEstadoAnimo> TipoEstadoAnimo { get; set; }

    public virtual DbSet<TipoEstadoMedicacionPaciente> TipoEstadoMedicacionPaciente { get; set; }

    public virtual DbSet<TipoEstadoMedicacionPacienteDetalle> TipoEstadoMedicacionPacienteDetalle { get; set; }

    public virtual DbSet<TipoEstadoRemito> TipoEstadoRemito { get; set; }

    public virtual DbSet<TipoEtnia> TipoEtnia { get; set; }

    public virtual DbSet<TipoGastos> TipoGastos { get; set; }

    public virtual DbSet<TipoGoteo> TipoGoteo { get; set; }

    public virtual DbSet<TipoGuardia> TipoGuardia { get; set; }

    public virtual DbSet<TipoHorarioTrabajo> TipoHorarioTrabajo { get; set; }

    public virtual DbSet<TipoImagen> TipoImagen { get; set; }

    public virtual DbSet<TipoInformeDigital> TipoInformeDigital { get; set; }

    public virtual DbSet<TipoIngresos> TipoIngresos { get; set; }

    public virtual DbSet<TipoInstruccion> TipoInstruccion { get; set; }

    public virtual DbSet<TipoInternacion> TipoInternacion { get; set; }

    public virtual DbSet<TipoInternacionIosep> TipoInternacionIosep { get; set; }

    public virtual DbSet<TipoKinesiologia> TipoKinesiologia { get; set; }

    public virtual DbSet<TipoLaboral> TipoLaboral { get; set; }

    public virtual DbSet<TipoLlamador> TipoLlamador { get; set; }

    public virtual DbSet<TipoMail> TipoMail { get; set; }

    public virtual DbSet<TipoMamas> TipoMamas { get; set; }

    public virtual DbSet<TipoMarcaAlfaBeta> TipoMarcaAlfaBeta { get; set; }

    public virtual DbSet<TipoMaterialConstruccion> TipoMaterialConstruccion { get; set; }

    public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }

    public virtual DbSet<TipoMovimientoBanco> TipoMovimientoBanco { get; set; }

    public virtual DbSet<TipoNormalAlterado> TipoNormalAlterado { get; set; }

    public virtual DbSet<TipoNormalAnormal> TipoNormalAnormal { get; set; }

    public virtual DbSet<TipoOsculta> TipoOsculta { get; set; }

    public virtual DbSet<TipoPaciente> TipoPaciente { get; set; }

    public virtual DbSet<TipoParentezco> TipoParentezco { get; set; }

    public virtual DbSet<TipoParto> TipoParto { get; set; }

    public virtual DbSet<TipoPedidoEnConsultorio> TipoPedidoEnConsultorio { get; set; }

    public virtual DbSet<TipoPedidoInterno> TipoPedidoInterno { get; set; }

    public virtual DbSet<TipoPersona> TipoPersona { get; set; }

    public virtual DbSet<TipoPosicion> TipoPosicion { get; set; }

    public virtual DbSet<TipoPositivoNegativo> TipoPositivoNegativo { get; set; }

    public virtual DbSet<TipoPrefesionalQuirofano> TipoPrefesionalQuirofano { get; set; }

    public virtual DbSet<TipoPresentacionAlturaFeto> TipoPresentacionAlturaFeto { get; set; }

    public virtual DbSet<TipoPresentacionFetal> TipoPresentacionFetal { get; set; }

    public virtual DbSet<TipoRazonTrabajo> TipoRazonTrabajo { get; set; }

    public virtual DbSet<TipoRelacionesSexuales> TipoRelacionesSexuales { get; set; }

    public virtual DbSet<TipoRespuesta> TipoRespuesta { get; set; }

    public virtual DbSet<TipoRetencion> TipoRetencion { get; set; }

    public virtual DbSet<TipoRevistaSala> TipoRevistaSala { get; set; }

    public virtual DbSet<TipoServicio> TipoServicio { get; set; }

    public virtual DbSet<TipoServicioAmb> TipoServicioAmb { get; set; }

    public virtual DbSet<TipoSiNoNoContesta> TipoSiNoNoContesta { get; set; }

    public virtual DbSet<TipoTeleSalud> TipoTeleSalud { get; set; }

    public virtual DbSet<TipoTelefonos> TipoTelefonos { get; set; }

    public virtual DbSet<TipoTenenciaVivienda> TipoTenenciaVivienda { get; set; }

    public virtual DbSet<TipoTrabJuvenil> TipoTrabJuvenil { get; set; }

    public virtual DbSet<TipoTrabajos> TipoTrabajos { get; set; }

    public virtual DbSet<TipoTraslado> TipoTraslado { get; set; }

    public virtual DbSet<TipoUltimoPrevio> TipoUltimoPrevio { get; set; }

    public virtual DbSet<TipoValor> TipoValor { get; set; }

    public virtual DbSet<TipoVehiculo> TipoVehiculo { get; set; }

    public virtual DbSet<TipoVentaAlfaBeta> TipoVentaAlfaBeta { get; set; }

    public virtual DbSet<TipoVentilacion> TipoVentilacion { get; set; }

    public virtual DbSet<TipoZonaResidencia> TipoZonaResidencia { get; set; }

    public virtual DbSet<TiposFeriados> TiposFeriados { get; set; }

    public virtual DbSet<TituloProfesional> TituloProfesional { get; set; }

    public virtual DbSet<Titulos> Titulos { get; set; }

    public virtual DbSet<TokenAclimed> TokenAclimed { get; set; }

    public virtual DbSet<TramiteEstado> TramiteEstado { get; set; }

    public virtual DbSet<Turnos> Turnos { get; set; }

    public virtual DbSet<TurnosHistorico> TurnosHistorico { get; set; }

    public virtual DbSet<TurnosQuirofano> TurnosQuirofano { get; set; }

    public virtual DbSet<TurnosReplanificados> TurnosReplanificados { get; set; }

    public virtual DbSet<TvMonitor> TvMonitor { get; set; }

    public virtual DbSet<UltimoTurnoRecomendado> UltimoTurnoRecomendado { get; set; }

    public virtual DbSet<UnificacionUsHc> UnificacionUsHc { get; set; }

    public virtual DbSet<UnificacionUsHcdetalle> UnificacionUsHcdetalle { get; set; }

    public virtual DbSet<UsuarioConsultas> UsuarioConsultas { get; set; }

    public virtual DbSet<UsuarioConsultorioAdmins> UsuarioConsultorioAdmins { get; set; }

    public virtual DbSet<UsuarioHistoriaClinicaWeb> UsuarioHistoriaClinicaWeb { get; set; }

    public virtual DbSet<UsuarioXdeposito> UsuarioXdeposito { get; set; }

    public virtual DbSet<Vacunas> Vacunas { get; set; }

    public virtual DbSet<VacunasEdades> VacunasEdades { get; set; }

    public virtual DbSet<VacunasGrupos> VacunasGrupos { get; set; }

    public virtual DbSet<VacunasPacientes> VacunasPacientes { get; set; }

    public virtual DbSet<VigenciaTerminosCondiciones> VigenciaTerminosCondiciones { get; set; }

    public virtual DbSet<VwArticulos> VwArticulos { get; set; }

    public virtual DbSet<VwArticulos1> VwArticulos1 { get; set; }

    public virtual DbSet<VwGrillaTurnos> VwGrillaTurnos { get; set; }

    public virtual DbSet<VwManualDatCobertura> VwManualDatCobertura { get; set; }

    public virtual DbSet<VwPlanillaTurnos> VwPlanillaTurnos { get; set; }

    public virtual DbSet<VwRolesMenu> VwRolesMenu { get; set; }

    public virtual DbSet<VwTurnosDetalle> VwTurnosDetalle { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=168.226.219.57,2424; Database=DBH_Test; User ID=sa; Password=Excel159753; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración para SP con DTO
        modelBuilder.Entity<DiagnosticoDto>().HasNoKey();
        modelBuilder.Entity<AceptaTerminosCondiciones>(entity =>
        {
            entity.HasKey(e => e.AceptaId);

            entity.Property(e => e.AceptaId).HasColumnName("AceptaID");
            entity.Property(e => e.FechaAcepta).HasColumnType("datetime");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(128)
                .HasColumnName("UsuarioID");
            entity.Property(e => e.VigenciaId).HasColumnName("VigenciaID");
        });

        // Relación entre ConsultasAmbulatorias y Pacientes
        modelBuilder.Entity<ConsultasAmbulatorias>()
            .HasOne(c => c.Pacientes)
            .WithMany(p => p.ConsultasAmbulatorias)
            .HasForeignKey(c => c.PacienteId)
            .OnDelete(DeleteBehavior.Restrict); // o lo que necesites

        // Relación entre ConsultasAmbulatorias y DiagnosticosConsultas (como Diagnóstico Principal)
        modelBuilder.Entity<ConsultasAmbulatorias>()
            .HasOne(c => c.DiagnosticosConsultas)
            .WithMany() // Si no hay navegación inversa
            .HasForeignKey(c => c.DiagnosticoPrincipalId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<AdmisionImagenes>(entity =>
        {
            entity.ToTable("Admision_Imagenes");

            entity.Property(e => e.AdmisionImagenesId)
                .ValueGeneratedNever()
                .HasColumnName("AdmisionImagenesID");
            entity.Property(e => e.DetalleImagenesId).HasColumnName("DetalleImagenesID");
            entity.Property(e => e.NumeroProtocolo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Numero_Protocolo");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

            entity.HasOne(d => d.DetalleImagenes).WithMany(p => p.AdmisionImagenes)
                .HasForeignKey(d => d.DetalleImagenesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admision_Imagenes_Detalle_Imagenes");

            entity.HasOne(d => d.Turno).WithMany(p => p.AdmisionImagenes)
                .HasForeignKey(d => d.TurnoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admision_Imagenes_Turnos");
        });

        modelBuilder.Entity<AdmisionLaboratorio>(entity =>
        {
            entity.ToTable("Admision_Laboratorio");

            entity.Property(e => e.AdmisionLaboratorioId)
                .ValueGeneratedNever()
                .HasColumnName("AdmisionLaboratorioID");
            entity.Property(e => e.DetalleLaboratorioId).HasColumnName("DetalleLaboratorioID");
            entity.Property(e => e.HoraTomaMuestra)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.NumeroProtocolo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Numero_Protocolo");
            entity.Property(e => e.Tomadapor)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

            entity.HasOne(d => d.DetalleLaboratorio).WithMany(p => p.AdmisionLaboratorio)
                .HasForeignKey(d => d.DetalleLaboratorioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admision_Laboratorio_Perfil_DetalleLaboratorio");

            entity.HasOne(d => d.Turno).WithMany(p => p.AdmisionLaboratorio)
                .HasForeignKey(d => d.TurnoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admision_Laboratorio_Turnos");
        });

        modelBuilder.Entity<AfectacionesXresolucion>(entity =>
        {
            entity.ToTable("AfectacionesXResolucion");

            entity.Property(e => e.AfectacionesXresolucionId).HasColumnName("AfectacionesXResolucionID");
            entity.Property(e => e.PresupuestoAnualAfectacionId).HasColumnName("PresupuestoAnualAfectacionID");
            entity.Property(e => e.PresupuestoResolucionId).HasColumnName("PresupuestoResolucionID");

            entity.HasOne(d => d.PresupuestoAnualAfectacion).WithMany(p => p.AfectacionesXresolucion)
                .HasForeignKey(d => d.PresupuestoAnualAfectacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AfectacionesXResolucion_PresupuestoAnualAfectacion");

            entity.HasOne(d => d.PresupuestoResolucion).WithMany(p => p.AfectacionesXresolucion)
                .HasForeignKey(d => d.PresupuestoResolucionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AfectacionesXResolucion_PresupuestoResolucion");
        });

        modelBuilder.Entity<AfiliadosUpa>(entity =>
        {
            entity.Property(e => e.AfiApellido)
                .HasMaxLength(40)
                .HasColumnName("afiApellido");
            entity.Property(e => e.AfiClaseDoc)
                .HasMaxLength(1)
                .HasColumnName("afiClaseDoc");
            entity.Property(e => e.AfiDni)
                .HasMaxLength(12)
                .HasColumnName("afiDNI");
            entity.Property(e => e.AfiDomBarrioParaje)
                .HasMaxLength(40)
                .HasColumnName("afiDomBarrioParaje");
            entity.Property(e => e.AfiDomCalle)
                .HasMaxLength(40)
                .HasColumnName("afiDomCalle");
            entity.Property(e => e.AfiDomCp)
                .HasMaxLength(8)
                .HasColumnName("afiDomCP");
            entity.Property(e => e.AfiDomDepartamento)
                .HasMaxLength(40)
                .HasColumnName("afiDomDepartamento");
            entity.Property(e => e.AfiDomDepto)
                .HasMaxLength(3)
                .HasColumnName("afiDomDepto");
            entity.Property(e => e.AfiDomEntreCalle1)
                .HasMaxLength(30)
                .HasColumnName("afiDomEntreCalle1");
            entity.Property(e => e.AfiDomEntreCalle2)
                .HasMaxLength(30)
                .HasColumnName("afiDomEntreCalle2");
            entity.Property(e => e.AfiDomLocalidad)
                .HasMaxLength(85)
                .HasColumnName("afiDomLocalidad");
            entity.Property(e => e.AfiDomManzana)
                .HasMaxLength(3)
                .HasColumnName("afiDomManzana");
            entity.Property(e => e.AfiDomMunicipio)
                .HasMaxLength(40)
                .HasColumnName("afiDomMunicipio");
            entity.Property(e => e.AfiDomNro)
                .HasMaxLength(5)
                .HasColumnName("afiDomNro");
            entity.Property(e => e.AfiDomPiso)
                .HasMaxLength(2)
                .HasColumnName("afiDomPiso");
            entity.Property(e => e.AfiDomProvincia)
                .HasMaxLength(2)
                .HasColumnName("afiDomProvincia");
            entity.Property(e => e.AfiFechaNac).HasColumnName("afiFechaNac");
            entity.Property(e => e.AfiLocalidad)
                .HasMaxLength(40)
                .HasColumnName("afiLocalidad");
            entity.Property(e => e.AfiNombre)
                .HasMaxLength(40)
                .HasColumnName("afiNombre");
            entity.Property(e => e.AfiSexo)
                .HasMaxLength(1)
                .HasColumnName("afiSexo");
            entity.Property(e => e.AfiTelefono)
                .HasMaxLength(20)
                .HasColumnName("afiTelefono");
            entity.Property(e => e.AfiTipoDoc)
                .HasMaxLength(5)
                .HasColumnName("afiTipoDoc");
            entity.Property(e => e.ClaveBeneficiario).HasMaxLength(16);
            entity.Property(e => e.LugarAtencionHabitual).HasMaxLength(80);
            entity.Property(e => e.MaApellido)
                .HasMaxLength(40)
                .HasColumnName("maApellido");
            entity.Property(e => e.MaNombre)
                .HasMaxLength(40)
                .HasColumnName("maNombre");
            entity.Property(e => e.MaNroDocumento)
                .HasMaxLength(12)
                .HasColumnName("maNroDocumento");
            entity.Property(e => e.MaTipoDocumento)
                .HasMaxLength(5)
                .HasColumnName("maTipoDocumento");
            entity.Property(e => e.MensajeBaja).HasMaxLength(150);
            entity.Property(e => e.MensajeBajaR).HasMaxLength(150);
            entity.Property(e => e.PaApellido)
                .HasMaxLength(40)
                .HasColumnName("paApellido");
            entity.Property(e => e.PaNombre)
                .HasMaxLength(40)
                .HasColumnName("paNombre");
            entity.Property(e => e.PaNroDocumento)
                .HasMaxLength(12)
                .HasColumnName("paNroDocumento");
            entity.Property(e => e.PaTipoDocumento)
                .HasMaxLength(5)
                .HasColumnName("paTipoDocumento");
            entity.Property(e => e.Pacienteid).HasColumnName("pacienteid");
        });

        modelBuilder.Entity<AgendaTareaAdjuntos>(entity =>
        {
            entity.HasKey(e => e.IdAdjunto);

            entity.Property(e => e.Id).HasMaxLength(128);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.AgendaTareaAdjuntos)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_AgendaTareaAdjuntos_AspNetUsers");

            entity.HasOne(d => d.IdAgendaTareaNavigation).WithMany(p => p.AgendaTareaAdjuntos)
                .HasForeignKey(d => d.IdAgendaTarea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgendaTareaAdjuntos_AgendaTareas");
        });

        modelBuilder.Entity<AgendaTareaAspNetUsers>(entity =>
        {
            entity.HasKey(e => e.IdAgendaTareaUsers);

            entity.ToTable("AgendaTarea_AspNetUsers");

            entity.Property(e => e.Id).HasMaxLength(128);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.AgendaTareaAspNetUsers)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_AgendaTarea_AspNetUsers_AspNetUsers");

            entity.HasOne(d => d.IdAgendaTareaNavigation).WithMany(p => p.AgendaTareaAspNetUsers)
                .HasForeignKey(d => d.IdAgendaTarea)
                .HasConstraintName("FK_AgendaTarea_AspNetUsers_AgendaTarea");
        });

        modelBuilder.Entity<AgendaTareaComentarios>(entity =>
        {
            entity.HasKey(e => e.IdAgendaComentario);

            entity.Property(e => e.Comentario).HasMaxLength(200);
            entity.Property(e => e.FechaComentario).HasColumnType("datetime");
            entity.Property(e => e.Id).HasMaxLength(128);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.AgendaTareaComentarios)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_AgendaTareaComentarios_AspNetUser");

            entity.HasOne(d => d.IdAgendaTareaNavigation).WithMany(p => p.AgendaTareaComentarios)
                .HasForeignKey(d => d.IdAgendaTarea)
                .HasConstraintName("FK_AgendaTareaComentarios_AgendaTarea");
        });

        modelBuilder.Entity<AgendaTareaHistorico>(entity =>
        {
            entity.HasKey(e => e.IdAgendaTareaHistorico);

            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.OpMod).HasMaxLength(11);

            entity.HasOne(d => d.IdAgendaTareaNavigation).WithMany(p => p.AgendaTareaHistorico)
                .HasForeignKey(d => d.IdAgendaTarea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgendaTareaHistorico_AgendaTarea");
        });

        modelBuilder.Entity<AgendaTareaHistoricoMovimientos>(entity =>
        {
            entity.HasKey(e => e.IdAgendaHistoricoMov);

            entity.Property(e => e.EstadoAnterior).HasMaxLength(10);
            entity.Property(e => e.EstadoNuevo).HasMaxLength(10);
            entity.Property(e => e.FechaCambio).HasColumnType("datetime");
            entity.Property(e => e.OpCambio).HasMaxLength(11);
        });

        modelBuilder.Entity<AgendaTareas>(entity =>
        {
            entity.HasKey(e => e.IdAgendaTarea);

            entity.Property(e => e.Categorias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Color).HasMaxLength(7);
            entity.Property(e => e.Detalle).HasMaxLength(400);
            entity.Property(e => e.EmpleadoSolicita)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasMaxLength(10);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaVence).HasColumnType("datetime");
            entity.Property(e => e.NroTarea)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.OpAnula)
                .HasMaxLength(11)
                .HasColumnName("opAnula");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .HasColumnName("opCrea");
            entity.Property(e => e.Prioridad).HasMaxLength(10);
            entity.Property(e => e.Resumen).HasMaxLength(40);
            entity.Property(e => e.Titulo).HasMaxLength(55);
        });

        modelBuilder.Entity<AlfaBetaAccioFar>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_AccioFar_1");

            entity.ToTable("AlfaBeta_AccioFar");

            entity.HasIndex(e => e.Codigo, "IX_AccioFar").IsUnique();

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(32)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlfaBetaBarextra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlfaBeta_Barextra");

            entity.Property(e => e.CodigoBarra)
                .HasMaxLength(13)
                .IsFixedLength();

            entity.HasOne(d => d.NroRegistroNavigation).WithMany()
                .HasForeignKey(d => d.NroRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_Barextra_AlfaBeta_ManualDat");
        });

        modelBuilder.Entity<AlfaBetaExtraBarras>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlfaBeta_ExtraBarras");

            entity.Property(e => e.CodigoBarra)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .IsFixedLength();

            entity.HasOne(d => d.NroRegistroNavigation).WithMany()
                .HasForeignKey(d => d.NroRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ExtraBarras_AlfaBeta_ManualDat");
        });

        modelBuilder.Entity<AlfaBetaFormas>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_Formas_1");

            entity.ToTable("AlfaBeta_Formas");

            entity.HasIndex(e => e.Codigo, "IX_Formas").IsUnique();

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlfaBetaGtin1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlfaBeta_Gtin1");

            entity.Property(e => e.Gtin)
                .HasMaxLength(14)
                .IsFixedLength();

            entity.HasOne(d => d.NroRegistroNavigation).WithMany()
                .HasForeignKey(d => d.NroRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_Gtin1_AlfaBeta_ManualDat");
        });

        modelBuilder.Entity<AlfaBetaManExtra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlfaBeta_ManExtra");

            entity.Property(e => e.Acciofar).HasComment("Acciofar.txt");
            entity.Property(e => e.Formas).HasComment("Formas.txt");
            entity.Property(e => e.Monodro).HasComment("Monodro.txt");
            entity.Property(e => e.NroRegistro).HasComment("Manual.Dat");
            entity.Property(e => e.Potencia)
                .HasMaxLength(16)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Tamanos).HasComment("Tamanos.txt");
            entity.Property(e => e.TipoUnid)
                .HasComment("tipoUnid.txt")
                .HasColumnName("tipoUnid");
            entity.Property(e => e.UPotenci)
                .HasComment("uPotenci.txt")
                .HasColumnName("uPotenci");
            entity.Property(e => e.Vias).HasComment("Vias.txt");

            entity.HasOne(d => d.AcciofarNavigation).WithMany()
                .HasForeignKey(d => d.Acciofar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_AccioFar");

            entity.HasOne(d => d.FormasNavigation).WithMany()
                .HasForeignKey(d => d.Formas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_Formas");

            entity.HasOne(d => d.MonodroNavigation).WithMany()
                .HasForeignKey(d => d.Monodro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_MonoDro");

            entity.HasOne(d => d.NroRegistroNavigation).WithMany()
                .HasForeignKey(d => d.NroRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_ManualDat");

            entity.HasOne(d => d.TamanosNavigation).WithMany()
                .HasForeignKey(d => d.Tamanos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_Alfabeta_Tamanos");

            entity.HasOne(d => d.TipoUn).WithMany()
                .HasForeignKey(d => d.TipoUnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_tipoUnid");

            entity.HasOne(d => d.UPotenciNavigation).WithMany()
                .HasForeignKey(d => d.UPotenci)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_uPotenci");

            entity.HasOne(d => d.ViasNavigation).WithMany()
                .HasForeignKey(d => d.Vias)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_vias");
        });

        modelBuilder.Entity<AlfaBetaManPato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlfaBeta_ManPato");

            entity.HasOne(d => d.IdPatologiaNavigation).WithMany()
                .HasForeignKey(d => d.IdPatologia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManPato_Patologias");

            entity.HasOne(d => d.MonodroNavigation).WithMany()
                .HasForeignKey(d => d.Monodro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManPato_AlfaBeta_MonoDro");
        });

        modelBuilder.Entity<AlfaBetaManualDat>(entity =>
        {
            entity.HasKey(e => e.NroRegistro).HasName("PK_ManualDat_1");

            entity.ToTable("AlfaBeta_ManualDat");

            entity.Property(e => e.NroRegistro).ValueGeneratedNever();
            entity.Property(e => e.Baja)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("0 = Presentación activa.\r\n1 = Presentación dada de baja.");
            entity.Property(e => e.Blanco)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("Espacios en blanco.");
            entity.Property(e => e.Blanco2)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.CodBarras)
                .HasMaxLength(13)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Fecha)
                .HasMaxLength(8)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("Fecha de vigencia del precio.(AAAAMMDD)");
            entity.Property(e => e.Gravamen)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Heladera)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("1 = Debe conservarse en heladera.");
            entity.Property(e => e.Importado)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("1 = Importado; 0 = Nacional");
            entity.Property(e => e.Ioma1).HasColumnType("numeric(8, 0)");
            entity.Property(e => e.Ioma2)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("Marca de uso Normatizado. (‘N’ = No / ‘S’ = Si / ‘A’ = Anexo II / ‘E’ = Plan\r\nSER / ‘T’ = Diag. Tuber., Lepra o Miastenia gravis / ‘C’ = IOMA ACC. )");
            entity.Property(e => e.Ioma3)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("Marca de cobertura en Internación. (N/S)");
            entity.Property(e => e.Iva)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("1 = con IVA a farmacia.");
            entity.Property(e => e.Laboratorio)
                .HasMaxLength(16)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("Descripción del laboratorio.");
            entity.Property(e => e.Marca)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("0 = No controlado\r\n2 = Psicotrópico II\r\n3 = Psicotrópico III\r\n4 = Psicotrópico IV\r\n6 = Estupefaciente I\r\n7 = Estupefaciente II\r\n8 = Estupefaciente III\r\n9 = Succinilcolina\r\nA = Venta Vigilada");
            entity.Property(e => e.Nombre)
                .HasMaxLength(44)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Pami)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("0 = Sin Información (Sin descuento)\r\n1 = 70%\r\n2 = 50 %.\r\n3 = 45%\r\n4 = 100% EMPADRONAMIENTO PREVIO\r\n5 = 30%.\r\n6 = 80 %.\r\n7 = 40%\r\n8 = 60%\r\n9 = 65%\r\nA =USO AUTORIZADO\r\nB = 55%\r\nC = 75%\r\nD = 35%\r\nE = 100% CON AUTORIZACIÓN PREVIA");
            entity.Property(e => e.Precio)
                .HasComment("Precio sugerido al público en pesos. (Multiplicado por 100, sin decimales)")
                .HasColumnType("numeric(9, 0)");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(24)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Sifar)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("Marca de cobertura de SIFAR. (N/S)");
            entity.Property(e => e.Tamano)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("1 = Menor,\r\n2 = Siguiente,\r\n3 = Grande (de dos presentaciones),\r\n4 = Gigante,\r\n5 = Grande (de mas de dos presentaciones),\r\n6 = Antibiótico Monodosis,\r\n7 = Antibiótico Multidosis,\r\n8 = Soluciones Parenterales,\r\n9 = Hospitalario, A = No clasificado");
            entity.Property(e => e.TipoVenta)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasComment("1 = Vta. Libre\r\n2 = Vta. Bajo Receta\r\n3 = Vta. Bajo Receta Archivada\r\n4 = Vta. Bajo Receta Oficial\r\n5 = Pendiente\r\n6 = Bajo control médico recomendado\r\n7 = No clasificado");
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Unidades)
                .HasComment("1 = El producto no es divisible.")
                .HasColumnType("numeric(4, 0)");

            entity.HasOne(d => d.MarcaNavigation).WithMany(p => p.AlfaBetaManualDat)
                .HasForeignKey(d => d.Marca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManualDat_Tipo_MarcaAlfaBeta");

            entity.HasOne(d => d.TipoVentaNavigation).WithMany(p => p.AlfaBetaManualDat)
                .HasForeignKey(d => d.TipoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_ManualDat_Tipo_VentaAlfaBeta");
        });

        modelBuilder.Entity<AlfaBetaMonoDro>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_MonoDro_1");

            entity.ToTable("AlfaBeta_MonoDro");

            entity.HasIndex(e => e.Codigo, "IX_MonoDro").IsUnique();

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(32)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlfaBetaMultidro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlfaBeta_Multidro");

            entity.HasIndex(e => e.NroRegistro, "FarmaciaBusqueda");

            entity.HasIndex(e => new { e.NuevaDro, e.NroRegistro }, "_dta_index_AlfaBeta_Multidro_c_6_297820173__K2_K1").IsClustered();

            entity.Property(e => e.NuevaDro).HasComment("Archivo nuevadro.txt");

            entity.HasOne(d => d.NroRegistroNavigation).WithMany()
                .HasForeignKey(d => d.NroRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_Multidro_AlfaBeta_ManualDat");

            entity.HasOne(d => d.NuevaDroNavigation).WithMany()
                .HasForeignKey(d => d.NuevaDro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_Multidro_AlfaBeta_Nuevadro");
        });

        modelBuilder.Entity<AlfaBetaNuevadro>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_Nuevadro_1");

            entity.ToTable("AlfaBeta_Nuevadro");

            entity.HasIndex(e => e.Codigo, "IX_Nuevadro").IsUnique();

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(36)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlfaBetaRegNueva>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlfaBeta_RegNueva");

            entity.Property(e => e.Potencia)
                .HasMaxLength(16)
                .IsFixedLength();
            entity.Property(e => e.UPotenci).HasColumnName("uPotenci");

            entity.HasOne(d => d.MonoDroNavigation).WithMany()
                .HasForeignKey(d => d.MonoDro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_RegNueva_AlfaBeta_Nuevadro");

            entity.HasOne(d => d.NroRegistroNavigation).WithMany()
                .HasForeignKey(d => d.NroRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_RegNueva_AlfaBeta_ManualDat");

            entity.HasOne(d => d.UPotenciNavigation).WithMany()
                .HasForeignKey(d => d.UPotenci)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlfaBeta_RegNueva_AlfaBeta_uPotenci");
        });

        modelBuilder.Entity<AlfaBetaTipoUnid>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_tipoUnid_1");

            entity.ToTable("AlfaBeta_tipoUnid");

            entity.HasIndex(e => e.Codigo, "IX_tipoUnid").IsUnique();

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlfaBetaUPotenci>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_uPotenci_1");

            entity.ToTable("AlfaBeta_uPotenci");

            entity.HasIndex(e => e.Codigo, "IX_uPotenci").IsUnique();

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlfaBetaVias>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_vias_1");

            entity.ToTable("AlfaBeta_vias");

            entity.HasIndex(e => e.Codigo, "IX_vias").IsUnique();

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlfabetaTamanos>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Alfabeta_Tamanos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(32)
                .IsFixedLength();
        });

        modelBuilder.Entity<AlimentacionVia>(entity =>
        {
            entity.Property(e => e.AlimentacionViaId).HasColumnName("AlimentacionViaID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<AnaemnesisGeneral>(entity =>
        {
            entity.HasKey(e => e.AnaemnesisGeneralId).HasName("PK_Anaemnesis_General_1");

            entity.ToTable("Anaemnesis_General");

            entity.Property(e => e.AnaemnesisGeneralId).HasColumnName("AnaemnesisGeneralID");
            entity.Property(e => e.AnaemnesisId).HasColumnName("AnaemnesisID");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(60)
                .IsFixedLength();
            entity.Property(e => e.FamiliarDiabetes).HasColumnName("Familiar_Diabetes");
            entity.Property(e => e.FamiliarGemelares).HasColumnName("Familiar_Gemelares");
            entity.Property(e => e.FamiliarHipertencion).HasColumnName("Familiar_Hipertencion");
            entity.Property(e => e.FamiliarOtros)
                .HasColumnType("ntext")
                .HasColumnName("Familiar_Otros");
            entity.Property(e => e.FamiliarTbc).HasColumnName("Familiar_Tbc");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FisicoGeneralAparatoCardiovascularN).HasColumnName("FisicoGeneral_AparatoCardiovascularN");
            entity.Property(e => e.FisicoGeneralAparatoRespiratorioN).HasColumnName("FisicoGeneral_AparatoRespiratorioN");
            entity.Property(e => e.FisicoGeneralAparatoUrinarioDisuria).HasColumnName("FisicoGeneral_AparatoUrinario_Disuria");
            entity.Property(e => e.FisicoGeneralAparatoUrinarioOtrosOrina)
                .HasColumnType("ntext")
                .HasColumnName("FisicoGeneral_AparatoUrinario_OtrosOrina");
            entity.Property(e => e.FisicoGeneralAparatoUrinarioPprb).HasColumnName("FisicoGeneral_AparatoUrinario_PPRB");
            entity.Property(e => e.FisicoGeneralBeba).HasColumnName("FisicoGeneral_BEBA");
            entity.Property(e => e.FisicoGeneralCabezaCuelloN).HasColumnName("FisicoGeneral_CabezaCuelloN");
            entity.Property(e => e.FisicoGeneralMiembroInferiorN).HasColumnName("FisicoGeneral_MiembroInferiorN");
            entity.Property(e => e.FisicoGeneralMiembroSuperiorN).HasColumnName("FisicoGeneral_MiembroSuperiorN");
            entity.Property(e => e.FisicoGeneralMv).HasColumnName("FisicoGeneral_MV");
            entity.Property(e => e.FisicoGeneralOtros)
                .HasColumnType("ntext")
                .HasColumnName("FisicoGeneral_Otros");
            entity.Property(e => e.FisicoGeneralOtrosCardiologicos)
                .HasColumnType("ntext")
                .HasColumnName("FisicoGeneral_OtrosCardiologicos");
            entity.Property(e => e.FisicoGeneralOtrosDetalle)
                .HasColumnType("ntext")
                .HasColumnName("FisicoGeneral_OtrosDetalle");
            entity.Property(e => e.FisicoGeneralOtrosMiembroInferior)
                .HasColumnType("ntext")
                .HasColumnName("FisicoGeneral_OtrosMiembroInferior");
            entity.Property(e => e.FisicoGeneralOtrosMiembroSuperior)
                .HasColumnType("ntext")
                .HasColumnName("FisicoGeneral_OtrosMiembroSuperior");
            entity.Property(e => e.FisicoGeneralR3).HasColumnName("FisicoGeneral_R3");
            entity.Property(e => e.FisicoGeneralR4).HasColumnName("FisicoGeneral_R4");
            entity.Property(e => e.FisicoGeneralTipoAbdomenBlando).HasColumnName("FisicoGeneral_TipoAbdomen_Blando");
            entity.Property(e => e.FisicoGeneralTipoAbdomenCatarsis).HasColumnName("FisicoGeneral_TipoAbdomen_Catarsis");
            entity.Property(e => e.FisicoGeneralTipoAbdomenDistendido).HasColumnName("FisicoGeneral_TipoAbdomen_Distendido");
            entity.Property(e => e.FisicoGeneralTipoAbdomenDoloroso).HasColumnName("FisicoGeneral_TipoAbdomen_Doloroso");
            entity.Property(e => e.FisicoGeneralTipoAbdomenEliminaGases).HasColumnName("FisicoGeneral_TipoAbdomen_EliminaGases");
            entity.Property(e => e.FisicoGeneralTipoAbdomenEntregoEstudios).HasColumnName("FisicoGeneral_TipoAbdomen_EntregoEstudios");
            entity.Property(e => e.FisicoGeneralTipoAbdomenGestante).HasColumnName("FisicoGeneral_TipoAbdomen_Gestante");
            entity.Property(e => e.FisicoGeneralTipoAbdomenLcf).HasColumnName("FisicoGeneral_TipoAbdomen_Lcf");
            entity.Property(e => e.FisicoGeneralTipoAbdomenMaf).HasColumnName("FisicoGeneral_TipoAbdomen_MAF");
            entity.Property(e => e.FisicoGeneralTipoAbdomenRma).HasColumnName("FisicoGeneral_TipoAbdomen_Rma");
            entity.Property(e => e.FisicoGeneralVv).HasColumnName("FisicoGeneral_VV");
            entity.Property(e => e.PersonalAlfabeta).HasColumnName("Personal_Alfabeta");
            entity.Property(e => e.PersonalAniosMayorNivelEstudios).HasColumnName("Personal_AniosMayorNivelEstudios");
            entity.Property(e => e.PersonalEstadoCivil).HasColumnName("Personal_EstadoCivil");
            entity.Property(e => e.PersonalEtniaId).HasColumnName("Personal_EtniaID");
            entity.Property(e => e.PersonalOcupacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Personal_Ocupacion");
            entity.Property(e => e.PersonalTipoInstruccionId).HasColumnName("Personal_TipoInstruccionID");
            entity.Property(e => e.PersonalViveSola).HasColumnName("Personal_ViveSola");
            entity.Property(e => e.PersonalesAlcohol).HasColumnName("Personales_Alcohol");
            entity.Property(e => e.PersonalesAlergias).HasColumnName("Personales_Alergias");
            entity.Property(e => e.PersonalesAmenorrea).HasColumnName("Personales_Amenorrea");
            entity.Property(e => e.PersonalesAntitetanica).HasColumnName("Personales_Antitetanica");
            entity.Property(e => e.PersonalesCantidadCigarros).HasColumnName("Personales_CantidadCigarros");
            entity.Property(e => e.PersonalesChagas).HasColumnName("Personales_Chagas");
            entity.Property(e => e.PersonalesCirugiaPu).HasColumnName("Personales_CirugiaPU");
            entity.Property(e => e.PersonalesCmv).HasColumnName("Personales_Cmv");
            entity.Property(e => e.PersonalesDiabetes).HasColumnName("Personales_Diabetes");
            entity.Property(e => e.PersonalesFuma).HasColumnName("Personales_Fuma");
            entity.Property(e => e.PersonalesHepatitis).HasColumnName("Personales_Hepatitis");
            entity.Property(e => e.PersonalesHipertencion).HasColumnName("Personales_Hipertencion");
            entity.Property(e => e.PersonalesHiv).HasColumnName("Personales_HIV");
            entity.Property(e => e.PersonalesInfertilidad).HasColumnName("Personales_Infertilidad");
            entity.Property(e => e.PersonalesMedicacion).HasColumnName("Personales_Medicacion");
            entity.Property(e => e.PersonalesOtros)
                .HasColumnType("ntext")
                .HasColumnName("Personales_Otros");
            entity.Property(e => e.PersonalesPeso)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("Personales_Peso");
            entity.Property(e => e.PersonalesPrimeraDosis).HasColumnName("Personales_PrimeraDosis");
            entity.Property(e => e.PersonalesPulso).HasColumnName("Personales_Pulso");
            entity.Property(e => e.PersonalesRubeola).HasColumnName("Personales_Rubeola");
            entity.Property(e => e.PersonalesSegundaDosis).HasColumnName("Personales_SegundaDosis");
            entity.Property(e => e.PersonalesSifilis).HasColumnName("Personales_Sifilis");
            entity.Property(e => e.PersonalesTbc).HasColumnName("Personales_TBC");
            entity.Property(e => e.PersonalesTemperatura)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Personales_Temperatura");
            entity.Property(e => e.PersonalesTensionArterialMaxima).HasColumnName("Personales_TensionArterialMaxima");
            entity.Property(e => e.PersonalesTensionArterialMinima).HasColumnName("Personales_TensionArterialMinima");
            entity.Property(e => e.PersonalesToxoplasmosis).HasColumnName("Personales_Toxoplasmosis");
            entity.Property(e => e.Profesion)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Anaemnesis).WithMany(p => p.AnaemnesisGeneral)
                .HasForeignKey(d => d.AnaemnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anaemnesis_General_Anamnesis");

            entity.HasOne(d => d.FisicoGeneralAparatoCardiovascularNNavigation).WithMany(p => p.AnaemnesisGeneralFisicoGeneralAparatoCardiovascularNNavigation)
                .HasForeignKey(d => d.FisicoGeneralAparatoCardiovascularN)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_NormalAlterado2");

            entity.HasOne(d => d.FisicoGeneralAparatoRespiratorioNNavigation).WithMany(p => p.AnaemnesisGeneralFisicoGeneralAparatoRespiratorioNNavigation)
                .HasForeignKey(d => d.FisicoGeneralAparatoRespiratorioN)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_NormalAlterado1");

            entity.HasOne(d => d.FisicoGeneralCabezaCuelloNNavigation).WithMany(p => p.AnaemnesisGeneralFisicoGeneralCabezaCuelloNNavigation)
                .HasForeignKey(d => d.FisicoGeneralCabezaCuelloN)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_NormalAlterado");

            entity.HasOne(d => d.FisicoGeneralMiembroInferiorNNavigation).WithMany(p => p.AnaemnesisGeneralFisicoGeneralMiembroInferiorNNavigation)
                .HasForeignKey(d => d.FisicoGeneralMiembroInferiorN)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_NormalAlterado4");

            entity.HasOne(d => d.FisicoGeneralMiembroSuperiorNNavigation).WithMany(p => p.AnaemnesisGeneralFisicoGeneralMiembroSuperiorNNavigation)
                .HasForeignKey(d => d.FisicoGeneralMiembroSuperiorN)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_NormalAlterado3");

            entity.HasOne(d => d.FisicoGeneralR3Navigation).WithMany(p => p.AnaemnesisGeneralFisicoGeneralR3Navigation)
                .HasForeignKey(d => d.FisicoGeneralR3)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_Osculta");

            entity.HasOne(d => d.FisicoGeneralR4Navigation).WithMany(p => p.AnaemnesisGeneralFisicoGeneralR4Navigation)
                .HasForeignKey(d => d.FisicoGeneralR4)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_Osculta1");

            entity.HasOne(d => d.PersonalEstadoCivilNavigation).WithMany(p => p.AnaemnesisGeneral)
                .HasForeignKey(d => d.PersonalEstadoCivil)
                .HasConstraintName("FK_Anaemnesis_General_EstadoCivil");

            entity.HasOne(d => d.PersonalEtnia).WithMany(p => p.AnaemnesisGeneral)
                .HasForeignKey(d => d.PersonalEtniaId)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_Etnia");

            entity.HasOne(d => d.PersonalTipoInstruccion).WithMany(p => p.AnaemnesisGeneral)
                .HasForeignKey(d => d.PersonalTipoInstruccionId)
                .HasConstraintName("FK_Anaemnesis_General_Tipo_Instruccion");
        });

        modelBuilder.Entity<AnaemnesisObstetricia>(entity =>
        {
            entity.HasKey(e => e.AnaemnesisObtetriciaId);

            entity.ToTable("Anaemnesis_Obstetricia");

            entity.Property(e => e.AnaemnesisObtetriciaId).HasColumnName("AnaemnesisObtetriciaID");
            entity.Property(e => e.AlturaPesoContracionUterina).HasColumnName("AlturaPeso_ContracionUterina");
            entity.Property(e => e.AlturaPesoDiagnosticoPresuntivo)
                .HasColumnType("ntext")
                .HasColumnName("AlturaPeso_DiagnosticoPresuntivo");
            entity.Property(e => e.AlturaPesoDiagnosticoPresuntivoId).HasColumnName("AlturaPeso_DiagnosticoPresuntivoID");
            entity.Property(e => e.AlturaPesoFrecuenciaCardiacaFetal).HasColumnName("AlturaPeso_FrecuenciaCardiacaFetal");
            entity.Property(e => e.AlturaPesoPresentacionFeto).HasColumnName("AlturaPeso_PresentacionFeto");
            entity.Property(e => e.AlturaPesoTamanoFetal)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("AlturaPeso_TamanoFetal");
            entity.Property(e => e.AlturaPesoTonoNormal).HasColumnName("AlturaPeso_TonoNormal");
            entity.Property(e => e.AnaemnesisGeneralId).HasColumnName("AnaemnesisGeneralID");
            entity.Property(e => e.AntecedentesObstetricosAbortos).HasColumnName("AntecedentesObstetricos_Abortos");
            entity.Property(e => e.AntecedentesObstetricosCesareas).HasColumnName("AntecedentesObstetricos_Cesareas");
            entity.Property(e => e.AntecedentesObstetricosComplicaciones).HasColumnName("AntecedentesObstetricos_Complicaciones");
            entity.Property(e => e.AntecedentesObstetricosEstudios).HasColumnName("AntecedentesObstetricos_Estudios");
            entity.Property(e => e.AntecedentesObstetricosGesta).HasColumnName("AntecedentesObstetricos_Gesta");
            entity.Property(e => e.AntecedentesObstetricosInmaduros).HasColumnName("AntecedentesObstetricos_Inmaduros");
            entity.Property(e => e.AntecedentesObstetricosMuertos).HasColumnName("AntecedentesObstetricos_Muertos");
            entity.Property(e => e.AntecedentesObstetricosObservaciones)
                .HasColumnType("ntext")
                .HasColumnName("AntecedentesObstetricos_Observaciones");
            entity.Property(e => e.AntecedentesObstetricosPap).HasColumnName("AntecedentesObstetricos_PAP");
            entity.Property(e => e.AntecedentesObstetricosPartos).HasColumnName("AntecedentesObstetricos_Partos");
            entity.Property(e => e.AntecedentesObstetricosPelvisNormal).HasColumnName("AntecedentesObstetricos_PelvisNormal");
            entity.Property(e => e.AntecedentesObstetricosVaginales).HasColumnName("AntecedentesObstetricos_Vaginales");
            entity.Property(e => e.AntecedentesObstetricosVivos).HasColumnName("AntecedentesObstetricos_Vivos");
            entity.Property(e => e.AntesEmbarazoFpp).HasColumnName("AntesEmbarazo_FPP");
            entity.Property(e => e.AntesEmbarazoFum).HasColumnName("AntesEmbarazo_FUM");
            entity.Property(e => e.AntesEmbarazoPeso)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("AntesEmbarazo_Peso");
            entity.Property(e => e.AntesEmbarazoTalla).HasColumnName("AntesEmbarazo_Talla");
            entity.Property(e => e.BacteriuriaMayorVeinteN).HasColumnName("Bacteriuria_MayorVeinteN");
            entity.Property(e => e.BacteriuriaMenorVeinteN).HasColumnName("Bacteriuria_MenorVeinteN");
            entity.Property(e => e.ConcejeriaLactancia).HasColumnName("Concejeria_Lactancia");
            entity.Property(e => e.EgconfiableEcoMenor20Semanas).HasColumnName("EGConfiable_Eco_menor20Semanas");
            entity.Property(e => e.EgconfiableFum).HasColumnName("EGConfiable_FUM");
            entity.Property(e => e.EmbarazoAnteriorFin).HasColumnName("EmbarazoAnterior_Fin");
            entity.Property(e => e.EmbarazoAnteriorMenos1anioMax5anios).HasColumnName("EmbarazoAnterior_Menos1anioMax5anios");
            entity.Property(e => e.EmbarazoAnteriorMetodoAnticonceptivo).HasColumnName("EmbarazoAnterior_MetodoAnticonceptivo");
            entity.Property(e => e.EmbarazoAnteriorPlaneado).HasColumnName("EmbarazoAnterior_Planeado");
            entity.Property(e => e.EstreptoB35a37SemanasP).HasColumnName("Estrepto_B35a37SemanasP");
            entity.Property(e => e.GlucemiaMayorTreintaSemanas)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Glucemia_MayorTreintaSemanas");
            entity.Property(e => e.GlucemiaMenosVeinteSemanas)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Glucemia_MenosVeinteSemanas");
            entity.Property(e => e.PreparacionParto).HasColumnName("Preparacion_Parto");
            entity.Property(e => e.PresentacionFetal).HasColumnName("Presentacion_Fetal");

            entity.HasOne(d => d.AlturaPesoDiagnosticoPresuntivoNavigation).WithMany(p => p.AnaemnesisObstetricia)
                .HasForeignKey(d => d.AlturaPesoDiagnosticoPresuntivoId)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Cie10");

            entity.HasOne(d => d.AlturaPesoPresentacionFetoNavigation).WithMany(p => p.AnaemnesisObstetricia)
                .HasForeignKey(d => d.AlturaPesoPresentacionFeto)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Tipo_PresentacionAlturaFeto1");

            entity.HasOne(d => d.AnaemnesisGeneral).WithMany(p => p.AnaemnesisObstetricia)
                .HasForeignKey(d => d.AnaemnesisGeneralId)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Anaemnesis_General1");

            entity.HasOne(d => d.BacteriuriaMayorVeinteNNavigation).WithMany(p => p.AnaemnesisObstetriciaBacteriuriaMayorVeinteNNavigation)
                .HasForeignKey(d => d.BacteriuriaMayorVeinteN)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Tipo_NormalAnormal5");

            entity.HasOne(d => d.BacteriuriaMenorVeinteNNavigation).WithMany(p => p.AnaemnesisObstetriciaBacteriuriaMenorVeinteNNavigation)
                .HasForeignKey(d => d.BacteriuriaMenorVeinteN)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Tipo_NormalAnormal4");

            entity.HasOne(d => d.EmbarazoAnteriorMetodoAnticonceptivoNavigation).WithMany(p => p.AnaemnesisObstetricia)
                .HasForeignKey(d => d.EmbarazoAnteriorMetodoAnticonceptivo)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Metodo_Anticonceptivo");

            entity.HasOne(d => d.EstreptoB35a37SemanasPNavigation).WithMany(p => p.AnaemnesisObstetricia)
                .HasForeignKey(d => d.EstreptoB35a37SemanasP)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Tipo_PositivoNegativo1");

            entity.HasOne(d => d.PresentacionFetalNavigation).WithMany(p => p.AnaemnesisObstetricia)
                .HasForeignKey(d => d.PresentacionFetal)
                .HasConstraintName("FK_Anaemnesis_Obstetricia_Tipo_PresentacionFetal1");
        });

        modelBuilder.Entity<AnaemnesisReducida>(entity =>
        {
            entity.HasKey(e => e.AnaemnesisReducidaId).HasName("PK_Anaemnesis_Reducida_1");

            entity.ToTable("Anaemnesis_Reducida");

            entity.HasIndex(e => e.TurnoId, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.PacienteId, e.Anulado }, "_dta_index_Anaemnesis_Reducida_6_2054350433__K2_K28_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_29_");

            entity.Property(e => e.AnaemnesisReducidaId).HasColumnName("AnaemnesisReducidaID");
            entity.Property(e => e.AntecedentesMadre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CircunferenciaCintura).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.EdadGestacional).HasColumnName("Edad_Gestacional");
            entity.Property(e => e.EmfermeroId).HasColumnName("EmfermeroID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FrecuenciaCardiaca).HasColumnName("Frecuencia_Cardiaca");
            entity.Property(e => e.FrecuenciaRespiratoria).HasColumnName("Frecuencia_Respiratoria");
            entity.Property(e => e.Fumador).HasDefaultValue(false);
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MasaCorporal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.Percentil).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PerimetroCefalico)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("Perimetro_Cefalico");
            entity.Property(e => e.Peso).HasColumnType("decimal(7, 3)");
            entity.Property(e => e.ScoreTal).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ShockRoomRegistroId).HasColumnName("ShockRoomRegistroID");
            entity.Property(e => e.Temperatura).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Internacion).WithMany(p => p.AnaemnesisReducida)
                .HasForeignKey(d => d.InternacionId)
                .HasConstraintName("FK_Anaemnesis_Reducida_Internaciones");
        });

        modelBuilder.Entity<AnalisisLaboratorio>(entity =>
        {
            entity.ToTable("Analisis_Laboratorio");

            entity.Property(e => e.AnalisisLaboratorioId)
                .ValueGeneratedNever()
                .HasColumnName("AnalisisLaboratorioID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<AnalisisSocioEconomico>(entity =>
        {
            entity.HasKey(e => e.SocioEconomicoId);

            entity.ToTable("Analisis_SocioEconomico");

            entity.Property(e => e.SocioEconomicoId)
                .ValueGeneratedNever()
                .HasColumnName("SocioEconomicoID");
            entity.Property(e => e.AdjuntaCetificadoAntecedentesMedicos).HasColumnName("Adjunta_CetificadoAntecedentesMedicos");
            entity.Property(e => e.AdjuntaInformeSocioEconomico).HasColumnName("Adjunta_InformeSocioEconomico");
            entity.Property(e => e.AdjuntaPresupuestosAbiertos).HasColumnName("Adjunta_PresupuestosAbiertos");
            entity.Property(e => e.AdjuntaPresupuestosCerrados).HasColumnName("Adjunta_PresupuestosCerrados");
            entity.Property(e => e.AmbientesBaño).HasColumnName("Ambientes_Baño");
            entity.Property(e => e.AmbientesCocina).HasColumnName("Ambientes_Cocina");
            entity.Property(e => e.AmbientesDormitorio).HasColumnName("Ambientes_Dormitorio");
            entity.Property(e => e.AmbientesOtros)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Ambientes_otros");
            entity.Property(e => e.AnemnesisGeneralId).HasColumnName("AnemnesisGeneralID");
            entity.Property(e => e.AntecedentesSubsidios).HasColumnName("Antecedentes_Subsidios");
            entity.Property(e => e.AutorizacionPolicialPcobrar).HasColumnName("Autorizacion_PolicialPCobrar");
            entity.Property(e => e.CertificadoResidencia).HasColumnName("Certificado_Residencia");
            entity.Property(e => e.ConsideracionesGenerales).HasColumnName("Consideraciones_Generales");
            entity.Property(e => e.ConstanciaCuil).HasColumnName("Constancia_Cuil");
            entity.Property(e => e.ConstanciaObrasSocial)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Constancia_ObrasSocial");
            entity.Property(e => e.DeclaracionJuradaPolicial).HasColumnName("Declaracion_JuradaPolicial");
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.DomicilioReal)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Domicilio_Real");
            entity.Property(e => e.FotocopiaDocumento).HasColumnName("Fotocopia_Documento");
            entity.Property(e => e.NegativaAnses).HasColumnName("Negativa_Anses");
            entity.Property(e => e.ObservacionesCasa)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.OtrosDatos)
                .HasMaxLength(100)
                .HasColumnName("Otros_Datos");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PersonaReferencia)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Persona_Referencia");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServiciosAguaCorriente).HasColumnName("Servicios_AguaCorriente");
            entity.Property(e => e.ServiciosGas).HasColumnName("Servicios_Gas");
            entity.Property(e => e.ServiciosLuzElectrica).HasColumnName("Servicios_luzElectrica");
            entity.Property(e => e.TelefonoReferencia)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Telefono_Referencia");
            entity.Property(e => e.TipoCasaId).HasColumnName("TipoCasaID");
            entity.Property(e => e.TipoMateriaConsId).HasColumnName("Tipo_MateriaConsID");
            entity.Property(e => e.TipoTenenciaVivId).HasColumnName("TipoTenenciaVivID");
            entity.Property(e => e.TipoZonaResidenciaId).HasColumnName("TipoZonaResidenciaID");
            entity.Property(e => e.TotalFolios).HasColumnName("Total_Folios");
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("UsuarioID");

            entity.HasOne(d => d.AnemnesisGeneral).WithMany(p => p.AnalisisSocioEconomico)
                .HasForeignKey(d => d.AnemnesisGeneralId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Analisis_SocioEconomico_Anaemnesis_General");

            entity.HasOne(d => d.TipoCasa).WithMany(p => p.AnalisisSocioEconomico)
                .HasForeignKey(d => d.TipoCasaId)
                .HasConstraintName("FK_Analisis_SocioEconomico_Tipo_Casa");

            entity.HasOne(d => d.TipoMateriaCons).WithMany(p => p.AnalisisSocioEconomico)
                .HasForeignKey(d => d.TipoMateriaConsId)
                .HasConstraintName("FK_Analisis_SocioEconomico_Tipo_MaterialConstruccion");

            entity.HasOne(d => d.TipoTenenciaViv).WithMany(p => p.AnalisisSocioEconomico)
                .HasForeignKey(d => d.TipoTenenciaVivId)
                .HasConstraintName("FK_Analisis_SocioEconomico_Tipo_TenenciaVivienda");

            entity.HasOne(d => d.TipoZonaResidencia).WithMany(p => p.AnalisisSocioEconomico)
                .HasForeignKey(d => d.TipoZonaResidenciaId)
                .HasConstraintName("FK_Analisis_SocioEconomico_Tipo_ZonaResidencia");
        });

        modelBuilder.Entity<Anamnesis>(entity =>
        {
            entity.Property(e => e.AnamnesisId).HasColumnName("AnamnesisID");
            entity.Property(e => e.AnamnesisIdoriginal).HasColumnName("AnamnesisIDOriginal");
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Egreso).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("hora");
            entity.Property(e => e.IdhistoriaClinica).HasColumnName("IDHistoriaClinica");
            entity.Property(e => e.Ingreso).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.Anamnesis)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anamnesis_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.Anamnesis)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anamnesis_Prestadores");

            entity.HasOne(d => d.TipoAnamnesis).WithMany(p => p.Anamnesis)
                .HasForeignKey(d => d.TipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anamnesis_Tipo_Anamnesis");
        });

        modelBuilder.Entity<AnamnesisDetalle>(entity =>
        {
            entity.ToTable("Anamnesis_Detalle");

            entity.Property(e => e.AnamnesisDetalleId).HasColumnName("AnamnesisDetalleID");
            entity.Property(e => e.Pregunta)
                .HasMaxLength(400)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");
            entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");
            entity.Property(e => e.ValorMaximo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("Valor_Maximo");
            entity.Property(e => e.ValorMinimo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("Valor_Minimo");

            entity.HasOne(d => d.TipoAnamnesis).WithMany(p => p.AnamnesisDetalle)
                .HasForeignKey(d => d.TipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anamnesis_Detalle_Tipo_Anamnesis");

            entity.HasOne(d => d.TipoRespuesta).WithMany(p => p.AnamnesisDetalle)
                .HasForeignKey(d => d.TipoRespuestaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anamnesis_Detalle_Tipo_Respuesta");
        });

        modelBuilder.Entity<AnamnesisRecienNacido>(entity =>
        {
            entity.HasKey(e => e.AnamnesisRnid);

            entity.Property(e => e.AnamnesisRnid).HasColumnName("AnamnesisRNID");
            entity.Property(e => e.DiagnosticosConsultasId).HasColumnName("DiagnosticosConsultasID");
            entity.Property(e => e.DispOxigenoId).HasColumnName("DispOxigenoID");
            entity.Property(e => e.EmfermeroId).HasColumnName("EmfermeroID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_hora");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Lactancia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MedicacionPacienteId).HasColumnName("MedicacionPacienteID");
            entity.Property(e => e.ObservacionMedica)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PerCefalico).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Rcp).HasColumnName("RCP");
            entity.Property(e => e.Talla).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoParto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnamnesisRespuestas>(entity =>
        {
            entity.HasKey(e => e.AnamnesisRespuestasId).HasName("PK_dbo.Anamnesis_Respuestas");

            entity.ToTable("Anamnesis_Respuestas");

            entity.Property(e => e.AnamnesisRespuestasId).HasColumnName("Anamnesis_RespuestasID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");
        });

        modelBuilder.Entity<AnemnesisPuerperio>(entity =>
        {
            entity.ToTable("Anemnesis_Puerperio");

            entity.Property(e => e.AnemnesisPuerperioId)
                .ValueGeneratedNever()
                .HasColumnName("AnemnesisPuerperioID");
            entity.Property(e => e.AnaemnesisGeneralId).HasColumnName("AnaemnesisGeneralID");
            entity.Property(e => e.Catarsis)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DiagnosticoPrincipal).HasColumnName("Diagnostico_Principal");
            entity.Property(e => e.DiagnosticoSecundario).HasColumnName("Diagnostico_Secundario");
            entity.Property(e => e.Diuresis)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EgresoHora)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Egreso_hora");
            entity.Property(e => e.EgresoHospital).HasColumnName("Egreso_Hospital");
            entity.Property(e => e.EliminaGases).HasColumnName("Elimina_Gases");
            entity.Property(e => e.HeridaPerineal)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Herida_Perineal");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Lactancia)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Loquios)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Mamas)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.RecienNacido)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Recien_nacido");
            entity.Property(e => e.Responsable)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.ResponsableEgreso)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("Responsable_Egreso");
            entity.Property(e => e.RetraccionUterina)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Retraccion_Uterina");
            entity.Property(e => e.Rha)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("RHA");
            entity.Property(e => e.TransferidoA).HasColumnName("Transferido_A");

            entity.HasOne(d => d.AnaemnesisGeneral).WithMany(p => p.AnemnesisPuerperio)
                .HasForeignKey(d => d.AnaemnesisGeneralId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anemnesis_Puerperio_Anaemnesis_General");

            entity.HasOne(d => d.DiagnosticoPrincipalNavigation).WithMany(p => p.AnemnesisPuerperioDiagnosticoPrincipalNavigation)
                .HasForeignKey(d => d.DiagnosticoPrincipal)
                .HasConstraintName("FK_Anemnesis_Puerperio_Cie10");

            entity.HasOne(d => d.DiagnosticoSecundarioNavigation).WithMany(p => p.AnemnesisPuerperioDiagnosticoSecundarioNavigation)
                .HasForeignKey(d => d.DiagnosticoSecundario)
                .HasConstraintName("FK_Anemnesis_Puerperio_Cie101");

            entity.HasOne(d => d.TransferidoANavigation).WithMany(p => p.AnemnesisPuerperio)
                .HasForeignKey(d => d.TransferidoA)
                .HasConstraintName("FK_Anemnesis_Puerperio_Otros_Centros");
        });

        modelBuilder.Entity<AnestesiaFormulario>(entity =>
        {
            entity.Property(e => e.AnestesiaFormularioId).HasColumnName("AnestesiaFormularioID");
            entity.Property(e => e.Entubacion).HasMaxLength(150);
            entity.Property(e => e.FinAnes).HasColumnType("datetime");
            entity.Property(e => e.HemoOtros).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HemoPlasma).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HemoSangre).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HemoSuero).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InicioAnes).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<AnestesiaMedicacion>(entity =>
        {
            entity.Property(e => e.AnestesiaMedicacionId).HasColumnName("AnestesiaMedicacionID");
            entity.Property(e => e.AnestesiaFormularioId).HasColumnName("AnestesiaFormularioID");
            entity.Property(e => e.ArticuloFarmaciaCisId).HasColumnName("ArticuloFarmaciaCisID");

            entity.HasOne(d => d.AnestesiaFormulario).WithMany(p => p.AnestesiaMedicacion)
                .HasForeignKey(d => d.AnestesiaFormularioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AnestesiaMedicacion_AnestesiaFormulario");

            entity.HasOne(d => d.ArticuloFarmaciaCis).WithMany(p => p.AnestesiaMedicacion)
                .HasForeignKey(d => d.ArticuloFarmaciaCisId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AnestesiaMedicacion_ArticuloFarmacia");
        });

        modelBuilder.Entity<AnestesiaMetodo>(entity =>
        {
            entity.Property(e => e.AnestesiaMetodoId).HasColumnName("AnestesiaMetodoID");
            entity.Property(e => e.AnestesiaFormularioId).HasColumnName("AnestesiaFormularioID");

            entity.HasOne(d => d.AnestesiaFormulario).WithMany(p => p.AnestesiaMetodo)
                .HasForeignKey(d => d.AnestesiaFormularioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AnestesiaMetodo_AnestesiaFormulario");
        });

        modelBuilder.Entity<AnestesiaPulso>(entity =>
        {
            entity.Property(e => e.AnestesiaPulsoId).HasColumnName("AnestesiaPulsoID");
            entity.Property(e => e.AnestesiaFormularioId).HasColumnName("AnestesiaFormularioID");
            entity.Property(e => e.PulsoFrecuencia).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AnestesiaFormulario).WithMany(p => p.AnestesiaPulso)
                .HasForeignKey(d => d.AnestesiaFormularioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AnestesiaPulso_AnestesiaFormulario");
        });

        modelBuilder.Entity<AnestesiaRespiracion>(entity =>
        {
            entity.Property(e => e.AnestesiaRespiracionId).HasColumnName("AnestesiaRespiracionID");
            entity.Property(e => e.AnestesiaFormularioId).HasColumnName("AnestesiaFormularioID");
            entity.Property(e => e.RespiracionFrecuencia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Saturacion).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AnestesiaFormulario).WithMany(p => p.AnestesiaRespiracion)
                .HasForeignKey(d => d.AnestesiaFormularioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AnestesiaRespiracion_AnestesiaFormulario");
        });

        modelBuilder.Entity<ApgarRn>(entity =>
        {
            entity.HasKey(e => e.ApgarId);

            entity.ToTable("ApgarRN");

            entity.Property(e => e.ApgarId).HasColumnName("ApgarID");
            entity.Property(e => e.AnamnesisRnid).HasColumnName("AnamnesisRNID");
            entity.Property(e => e.Valor).HasMaxLength(10);
        });

        modelBuilder.Entity<Articulos>(entity =>
        {
            entity.HasKey(e => e.NroRegistro);

            entity.Property(e => e.Articulo)
                .HasMaxLength(1)
                .HasDefaultValue("1")
                .IsFixedLength();
            entity.Property(e => e.Codbarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.FechaUltCompra).HasColumnName("Fecha_UltCompra");
            entity.Property(e => e.Heladera)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Iva).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(44)
                .IsFixedLength();
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Compra");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(24)
                .IsFixedLength();
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .IsFixedLength();
        });

        modelBuilder.Entity<ArticulosFarmaciaCis>(entity =>
        {
            entity.HasKey(e => e.ArticuloFarmaciaCisId);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_EditMedicamentosHCWeb");
                    tb.HasTrigger("Tr_RegistroMedicamentosHCWeb");
                });

            entity.Property(e => e.ArticuloFarmaciaCisId).HasColumnName("ArticuloFarmaciaCisID");
            entity.Property(e => e.ArticuloIdhc).HasColumnName("ArticuloIDHC");
            entity.Property(e => e.CodigoArticulo)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StockMinimo).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<AsientoXpartida>(entity =>
        {
            entity.ToTable("AsientoXPartida");

            entity.Property(e => e.AsientoXpartidaId).HasColumnName("AsientoXPartidaID");
            entity.Property(e => e.Concepto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CuentaBancariaDetalleMovimientoId).HasColumnName("CuentaBancariaDetalleMovimientoID");
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FondoPermanenteId).HasColumnName("FondoPermanenteID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrdenPagoId).HasColumnName("OrdenPagoID");
            entity.Property(e => e.PresupuestoAnualAfectacionId).HasColumnName("PresupuestoAnualAfectacionID");
            entity.Property(e => e.PresupuestoAnualDetalleId).HasColumnName("PresupuestoAnualDetalleID");
            entity.Property(e => e.PresupuestoAnualMovimientoId).HasColumnName("PresupuestoAnualMovimientoID");
            entity.Property(e => e.PresupuestoCompromisoId).HasColumnName("PresupuestoCompromisoID");
            entity.Property(e => e.PresupuestoResolucionId).HasColumnName("PresupuestoResolucionID");
            entity.Property(e => e.RefAsiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RefAsientoId).HasColumnName("RefAsientoID");
        });

        modelBuilder.Entity<AsistenciaEmpleado>(entity =>
        {
            entity.HasKey(e => e.AsistenciaId);

            entity.Property(e => e.AsistenciaId).HasColumnName("AsistenciaID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.HoraEgreso).HasColumnType("datetime");
            entity.Property(e => e.HoraIngreso).HasColumnType("datetime");
            entity.Property(e => e.PersPlanificacionDetalleId).HasColumnName("PersPlanificacionDetalleID");
            entity.Property(e => e.PersPlanificacionId).HasColumnName("PersPlanificacionID");
        });

        modelBuilder.Entity<AsistenciaMedicos>(entity =>
        {
            entity.HasKey(e => e.AsistenciaMedicoId).HasName("PK_AsistenaciaMedicos");

            entity.Property(e => e.AsistenciaMedicoId).HasColumnName("AsistenciaMedicoID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

            entity.HasOne(d => d.Prestador).WithMany(p => p.AsistenciaMedicos)
                .HasForeignKey(d => d.PrestadorId)
                .HasConstraintName("FK_AsistenaciaMedicos_Prestadores");
        });

        modelBuilder.Entity<AsistenciaMedicosPlanillas>(entity =>
        {
            entity.HasKey(e => e.AsistenciaMedicoPlanillaId);

            entity.Property(e => e.AsistenciaMedicoPlanillaId).HasColumnName("AsistenciaMedicoPlanillaID");
            entity.Property(e => e.AsistenciaMedicoId).HasColumnName("AsistenciaMedicoID");
            entity.Property(e => e.PracticaId).HasColumnName("PracticaID");
        });

        modelBuilder.Entity<AspNetMenu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK_Menu");

            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AspNetMenuRoles>(entity =>
        {
            entity.HasKey(e => e.IdRolesInMenu).HasName("PK_RolesInMenu");

            entity.HasIndex(e => e.IdMenu, "<Name of Missing Index, sysname,>");

            entity.Property(e => e.RoleId).HasMaxLength(128);
        });

        modelBuilder.Entity<AspNetRoles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Deleteable).HasDefaultValue(true);
            entity.Property(e => e.EsCoordinador).HasColumnName("Es_Coordinador");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Observacion).HasColumnType("ntext");
            entity.Property(e => e.RolIdoriginal)
                .HasMaxLength(128)
                .HasColumnName("RolIDOriginal");
        });

        modelBuilder.Entity<AspNetUserClaims>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.ToTable(tb => tb.HasTrigger("Tr_RegistroPrestadoresConUsuariosHCWeb"));

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogins>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserRoles>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId, e.InstitucionId }).HasName("PK_dbo.AspNetUserRoles");

            entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.RoleId).HasMaxLength(128);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetUserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUsers>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.CaduceTokenZismed).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Token).HasMaxLength(200);
            entity.Property(e => e.UserIdoriginal)
                .HasMaxLength(128)
                .HasColumnName("UserIDOriginal");
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.UserNameAbbott).HasMaxLength(100);
        });

        modelBuilder.Entity<Bancos>(entity =>
        {
            entity.HasKey(e => e.BancoId);

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<BancosPersonas>(entity =>
        {
            entity.ToTable("Bancos_Personas");

            entity.Property(e => e.Cbu)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("CBU");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TipoCbancoId).HasColumnName("TipoCBancoId");

            entity.HasOne(d => d.Banco).WithMany(p => p.BancosPersonas)
                .HasForeignKey(d => d.BancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bancos_Personas_Bancos");

            entity.HasOne(d => d.Persona).WithMany(p => p.BancosPersonas)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bancos_Personas_Personas");

            entity.HasOne(d => d.TipoCbanco).WithMany(p => p.BancosPersonas)
                .HasForeignKey(d => d.TipoCbancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bancos_Personas_Tipo_CBancos");
        });

        modelBuilder.Entity<Barrios>(entity =>
        {
            entity.HasKey(e => e.BarrioId).HasName("PK_Zonas");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.Localidad).WithMany(p => p.Barrios)
                .HasForeignKey(d => d.LocalidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Barrios_Localidades");
        });

        modelBuilder.Entity<BaseCisb>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Comentarios)
                .HasMaxLength(255)
                .HasColumnName("COMENTARIOS");
            entity.Property(e => e.Cuil)
                .HasMaxLength(255)
                .HasColumnName("CUIL");
            entity.Property(e => e.DíaLaboral)
                .HasMaxLength(255)
                .HasColumnName("DÍA LABORAL");
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(255)
                .HasColumnName("ESCOLARIDAD");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(255)
                .HasColumnName("ESPECIALIDAD");
            entity.Property(e => e.HorarioLaboral)
                .HasMaxLength(255)
                .HasColumnName("HORARIO LABORAL");
            entity.Property(e => e.LugarDeTrabajo)
                .HasMaxLength(255)
                .HasColumnName("LUGAR DE TRABAJO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.PuestoCargo)
                .HasMaxLength(255)
                .HasColumnName("PUESTO - CARGO");
            entity.Property(e => e.PuestoCargoCambios)
                .HasMaxLength(255)
                .HasColumnName("PUESTO / CARGO - CAMBIOS ");
            entity.Property(e => e.ServicioÁrea)
                .HasMaxLength(255)
                .HasColumnName("SERVICIO/ÁREA");
            entity.Property(e => e.TipoContrataciónReal)
                .HasMaxLength(255)
                .HasColumnName("TIPO CONTRATACIÓN REAL");
            entity.Property(e => e.TipoDeContratación)
                .HasMaxLength(255)
                .HasColumnName("TIPO DE CONTRATACIÓN");
        });

        modelBuilder.Entity<BienPatrimonialMovimientos>(entity =>
        {
            entity.HasKey(e => e.MovimientoId);

            entity.Property(e => e.MovimientoId).HasColumnName("MovimientoID");
            entity.Property(e => e.BienPatrimonialId).HasColumnName("BienPatrimonialID");
            entity.Property(e => e.CuilAutoriza)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.FechaAutoriza).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.MotivoSolicitud).HasMaxLength(500);
            entity.Property(e => e.Observacion).HasMaxLength(500);
            entity.Property(e => e.Solicitante).HasMaxLength(50);
            entity.Property(e => e.UsuarioAutoriza).HasMaxLength(50);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.BienPatrimonial).WithMany(p => p.BienPatrimonialMovimientos)
                .HasForeignKey(d => d.BienPatrimonialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BienPatri__BienP__0CFC7647");

            entity.HasOne(d => d.Sector).WithMany(p => p.BienPatrimonialMovimientos)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BienPatri__Secto__177A04BA");
        });

        modelBuilder.Entity<BienesPatrimoniales>(entity =>
        {
            entity.HasKey(e => e.BienPatrimonialId).HasName("PK_Bien");

            entity.Property(e => e.BienPatrimonialId).HasColumnName("BienPatrimonialID");
            entity.Property(e => e.CodHospital).HasMaxLength(50);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NumeroSerie).HasMaxLength(50);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Sector).WithMany(p => p.BienesPatrimoniales)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BienesPat__Secto__1591BC48");
        });

        modelBuilder.Entity<Bonos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BonoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BonoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Numero).HasMaxLength(20);
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.UserAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga).HasMaxLength(11);
            entity.Property(e => e.UsuarioModifica).HasMaxLength(11);

            entity.HasOne(d => d.ObraSocial).WithMany()
                .HasForeignKey(d => d.ObraSocialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bonos__ObraSocia__5245C4CD");

            entity.HasOne(d => d.Paciente).WithMany()
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bonos__PacienteI__5151A094");

            entity.HasOne(d => d.Prestador).WithMany()
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bonos__Prestador__542E0D3F");

            entity.HasOne(d => d.Servicio).WithMany()
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK__Bonos__ServicioI__5339E906");
        });

        modelBuilder.Entity<Camas>(entity =>
        {
            entity.HasKey(e => e.CamaId);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_EdicionCamasHCWeb");
                    tb.HasTrigger("Tr_RegistroCamasHCWeb");
                });

            entity.HasIndex(e => e.CamaId, "_dta_index_Camas_6_1093683044__K1_2");

            entity.Property(e => e.CamaIdhc).HasColumnName("CamaIDHC");
            entity.Property(e => e.EnMantenimiento).HasColumnName("En_mantenimiento");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.TipoCamaId).HasColumnName("TipoCamaID");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Camas)
                .HasForeignKey(d => d.HabitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Camas_Habitaciones_Hospital");
        });

        modelBuilder.Entity<CambioContingente>(entity =>
        {
            entity.Property(e => e.CambioContingenteId).HasColumnName("CambioContingenteID");
            entity.Property(e => e.AdmisionId).HasColumnName("AdmisionID");
            entity.Property(e => e.FechaMdo).HasColumnType("datetime");
            entity.Property(e => e.MotivoCambioId).HasColumnName("MotivoCambioID");
            entity.Property(e => e.NuevoContingenteId).HasColumnName("NuevoContingenteID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.ViejoContingenteId).HasColumnName("ViejoContingenteID");
        });

        modelBuilder.Entity<Cargos>(entity =>
        {
            entity.HasKey(e => e.CargoId);

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<CategoriaProveedor>(entity =>
        {
            entity.Property(e => e.CategoriaProveedorId).HasColumnName("CategoriaProveedorID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CategoriaTarea>(entity =>
        {
            entity.Property(e => e.CategoriaTareaId).HasColumnName("CategoriaTareaID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<Categorias>(entity =>
        {
            entity.HasKey(e => e.CategoriaId);

            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Centro>(entity =>
        {
            entity.Property(e => e.CentroId).HasColumnName("CentroID");
            entity.Property(e => e.Domicilio).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefonos).HasMaxLength(100);
            entity.Property(e => e.Web).HasMaxLength(30);
        });

        modelBuilder.Entity<CentrosVacunacion>(entity =>
        {
            entity.Property(e => e.CentrosVacunacionId).HasColumnName("CentrosVacunacionID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Centrosprueba>(entity =>
        {
            entity.HasKey(e => e.Centro2id);

            entity.ToTable("centrosprueba");

            entity.Property(e => e.Centro2id).HasColumnName("centro2id");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(300)
                .HasColumnName("domicilio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Cie10>(entity =>
        {
            entity.HasKey(e => e.DiagnosticoId);

            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.Capitulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.DesdeHasta)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Desde_Hasta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<Cie10Capitulos>(entity =>
        {
            entity.HasKey(e => e.CapituloId);

            entity.ToTable("Cie10_Capitulos");

            entity.Property(e => e.CapituloId).HasColumnName("CapituloID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.DesdeHasta)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Desde_Hasta");
            entity.Property(e => e.Nivel)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<CirujiaDetalle>(entity =>
        {
            entity.Property(e => e.CirujiaDetalleId).HasColumnName("CirujiaDetalleID");
            entity.Property(e => e.AnestesiaId).HasColumnName("AnestesiaID");
            entity.Property(e => e.FojaQuirurjicaId).HasColumnName("FojaQuirurjicaID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoProfesionalId).HasColumnName("TipoProfesionalID");
            entity.Property(e => e.TurnoQuirofanoId).HasColumnName("TurnoQuirofanoID");

            entity.HasOne(d => d.FojaQuirurjica).WithMany(p => p.CirujiaDetalle)
                .HasForeignKey(d => d.FojaQuirurjicaId)
                .HasConstraintName("FK_CirujiaDetalle_FojaQuirurjica");

            entity.HasOne(d => d.Prestador).WithMany(p => p.CirujiaDetalle)
                .HasForeignKey(d => d.PrestadorId)
                .HasConstraintName("FK_CirujiaDetalle_Prestadores");
        });

        modelBuilder.Entity<Colores>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.ColorHexa)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Consentimientos>(entity =>
        {
            entity.HasKey(e => e.ConsentimientoId);

            entity.Property(e => e.ConsentimientoId).HasColumnName("ConsentimientoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaFirma).HasColumnType("datetime");
            entity.Property(e => e.FechaImprime).HasColumnType("datetime");
            entity.Property(e => e.FormatoConsentimientoId).HasColumnName("FormatoConsentimientoID");
            entity.Property(e => e.GuardiaId).HasColumnName("GuardiaID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.Urlimagen)
                .HasMaxLength(500)
                .HasColumnName("URLImagen");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Consulta>(entity =>
        {
            entity.ToTable("consulta");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(250)
                .HasColumnName("diagnostico");
            entity.Property(e => e.DocReferencia)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("docReferencia");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("documento");
            entity.Property(e => e.EdadDias).HasColumnName("edadDias");
            entity.Property(e => e.Evolucion).HasColumnName("evolucion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaNac).HasColumnType("datetime");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PerimetroCef)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("perimetroCef");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("peso");
            entity.Property(e => e.Presuntivo)
                .HasMaxLength(256)
                .IsFixedLength()
                .HasColumnName("presuntivo");
            entity.Property(e => e.Servicio)
                .HasMaxLength(250)
                .HasColumnName("servicio");
            entity.Property(e => e.Sexo).HasMaxLength(20);
            entity.Property(e => e.Talla).HasColumnName("talla");
        });

        modelBuilder.Entity<ConsultasAmbulatorias>(entity =>
        {
            entity.HasKey(e => e.ConsultaId);

            entity.ToTable("Consultas_Ambulatorias");

            entity.HasIndex(e => new { e.TurnoId, e.Anulado }, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.GuardiaRegistroId, e.Anulado }, "IndiceListaGuardia");

            entity.HasIndex(e => new { e.PacienteId, e.Anulado, e.InstitucionId }, "Ix_ConsultasAmbulatorias_PacienteIDAnuladoInstitucionID");

            entity.HasIndex(e => new { e.GuardiaRegistroId, e.Anulado, e.ConsultaId, e.PrestadorId }, "_dta_index_Consultas_Ambulatorias_6_502344904__K4_K16_K1_K8");

            entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");
            entity.Property(e => e.ConsultaIdoriginal).HasColumnName("ConsultaIDOriginal");
            entity.Property(e => e.DiagnosticoPrincipalId).HasColumnName("DiagnosticoPrincipalID");
            entity.Property(e => e.DiagnosticoPrincipalVar).HasDefaultValue("");
            entity.Property(e => e.DiagnosticoSecundarioId).HasColumnName("DiagnosticoSecundarioID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.Informe).IsUnicode(false);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InterconsultaId).HasColumnName("InterconsultaID");
            entity.Property(e => e.MotivoAnula)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Presuntivo)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Visible).HasDefaultValue(false);

            entity.HasOne(d => d.Cama).WithMany(p => p.ConsultasAmbulatorias)
                .HasForeignKey(d => d.CamaId)
                .HasConstraintName("FK_Consultas_Ambulatorias_Diagnosticos_Consultas");

            entity.HasOne(d => d.DiagnosticoSecundario).WithMany(p => p.ConsultasAmbulatorias)
                .HasForeignKey(d => d.DiagnosticoSecundarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Consultas_Ambulatorias_Diagnosticos_Consultas1");

            entity.HasOne(d => d.Interconsulta).WithMany(p => p.ConsultasAmbulatorias)
                .HasForeignKey(d => d.InterconsultaId)
                .HasConstraintName("FK_Consultas_Ambulatorias_Interconsulta");

            entity.HasOne(d => d.ObraSocial).WithMany(p => p.ConsultasAmbulatorias)
                .HasForeignKey(d => d.ObraSocialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Consultas_Ambulatorias_ObraSocial");
        });

        modelBuilder.Entity<Consultorios>(entity =>
        {
            entity.HasKey(e => e.ConsultorioId);

            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TvMonitorId).HasColumnName("TvMonitorID");

            entity.HasOne(d => d.TvMonitor).WithMany(p => p.Consultorios)
                .HasForeignKey(d => d.TvMonitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Consultorios_TvMonitor");
        });

        modelBuilder.Entity<ContableGastos>(entity =>
        {
            entity.ToTable("Contable_Gastos");

            entity.Property(e => e.AfectacionDefinitiva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Afectacion_Definitiva");
            entity.Property(e => e.AfectacionPreventiva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Afectacion_Preventiva");
            entity.Property(e => e.FechaAmpliacion).HasColumnName("Fecha_Ampliacion");
            entity.Property(e => e.FechaAprobacion).HasColumnName("Fecha_Aprobacion");
            entity.Property(e => e.ImporteAmpliacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Ampliacion");
            entity.Property(e => e.ImporteComprometido)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Comprometido");
            entity.Property(e => e.ImporteCredito)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Credito");
            entity.Property(e => e.MandadoApagar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Mandado_APagar");

            entity.HasOne(d => d.CuentaContable).WithMany(p => p.ContableGastos)
                .HasForeignKey(d => d.CuentaContableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contable_Gastos_Cuentas_Contables");
        });

        modelBuilder.Entity<ContableRecursos>(entity =>
        {
            entity.ToTable("Contable_Recursos");

            entity.Property(e => e.FechaAmpliacion).HasColumnName("Fecha_Ampliacion");
            entity.Property(e => e.FechaAprobacion).HasColumnName("Fecha_Aprobacion");
            entity.Property(e => e.ImporteAmpliacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Ampliacion");
            entity.Property(e => e.ImporteDiferencias)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Diferencias");
            entity.Property(e => e.ImporteEfectivo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Efectivo");
            entity.Property(e => e.ImporteEstimado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Estimado");

            entity.HasOne(d => d.CuentaContable).WithMany(p => p.ContableRecursos)
                .HasForeignKey(d => d.CuentaContableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contable_Recursos_Cuentas_Contables");
        });

        modelBuilder.Entity<Contactos>(entity =>
        {
            entity.HasKey(e => e.ContactoId);

            entity.Property(e => e.NombreContacto)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Nombre_Contacto");
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Telefono_Contacto");

            entity.HasOne(d => d.Persona).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contactos_Personas");

            entity.HasOne(d => d.TipoContacto).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.TipoContactoId)
                .HasConstraintName("FK_Contactos_Tipo_Contactos");
        });

        modelBuilder.Entity<ContactosEstrechos>(entity =>
        {
            entity.HasKey(e => e.ContactoEstrechoId).HasName("PK_CasosEstrechos");

            entity.Property(e => e.ContactoEstrechoId).HasColumnName("ContactoEstrechoID");
            entity.Property(e => e.ApellidoNombre).HasMaxLength(100);
            entity.Property(e => e.Documento).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(100);
            entity.Property(e => e.NotificacionId).HasColumnName("NotificacionID");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Notificacion).WithMany(p => p.ContactosEstrechos)
                .HasForeignKey(d => d.NotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactosEstrechos_NotificacionesCovid");
        });

        modelBuilder.Entity<Coseguro>(entity =>
        {
            entity.Property(e => e.CoseguroId).HasColumnName("CoseguroID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CovidInstituciones>(entity =>
        {
            entity.HasKey(e => e.IdInstitucion);

            entity.Property(e => e.Ciudad).HasMaxLength(25);
            entity.Property(e => e.Domicilio).HasMaxLength(200);
            entity.Property(e => e.Latitud).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Longitud).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Provincia).HasMaxLength(25);
            entity.Property(e => e.Tipo).HasMaxLength(20);
        });

        modelBuilder.Entity<CovidReportes>(entity =>
        {
            entity.HasKey(e => e.IdReporte);

            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
        });

        modelBuilder.Entity<CovidTipoReporte>(entity =>
        {
            entity.HasKey(e => e.IdTipoReporte);

            entity.Property(e => e.Tipo).HasMaxLength(20);
        });

        modelBuilder.Entity<CovidUsuario>(entity =>
        {
            entity.HasKey(e => e.IdCovidUsuario).HasName("PK_CovidColaborador");

            entity.Property(e => e.Email).HasMaxLength(75);
            entity.Property(e => e.InstitucionIdoriginal).HasColumnName("InstitucionIDOriginal");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Palabra).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(25);
        });

        modelBuilder.Entity<CuentaBancaria>(entity =>
        {
            entity.Property(e => e.CuentaBancariaId).HasColumnName("CuentaBancariaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Banco).WithMany(p => p.CuentaBancaria)
                .HasForeignKey(d => d.BancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaBancaria_Bancos");
        });

        modelBuilder.Entity<CuentaBancariaDetalleMovimiento>(entity =>
        {
            entity.Property(e => e.CuentaBancariaDetalleMovimientoId).HasColumnName("CuentaBancariaDetalleMovimientoID");
            entity.Property(e => e.CuentaBancariaId).HasColumnName("CuentaBancariaID");
            entity.Property(e => e.CuentaMovConceptoId).HasColumnName("CuentaMovConceptoID");
            entity.Property(e => e.CuentaTipoMovimientoId).HasColumnName("CuentaTipoMovimientoID");
            entity.Property(e => e.Egreso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Ingreso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NroCheque)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NroTransaccion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrdenPagoDetalleId).HasColumnName("OrdenPagoDetalleID");
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.CuentaBancaria).WithMany(p => p.CuentaBancariaDetalleMovimiento)
                .HasForeignKey(d => d.CuentaBancariaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaBancariaDetalleMovimiento_CuentaBancaria");

            entity.HasOne(d => d.CuentaMovConcepto).WithMany(p => p.CuentaBancariaDetalleMovimiento)
                .HasForeignKey(d => d.CuentaMovConceptoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaBancariaDetalleMovimiento_CuentaMovConcepto");

            entity.HasOne(d => d.CuentaTipoMovimiento).WithMany(p => p.CuentaBancariaDetalleMovimiento)
                .HasForeignKey(d => d.CuentaTipoMovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaBancariaDetalleMovimiento_CuentaTipoMovimiento");

            entity.HasOne(d => d.OrdenPagoDetalle).WithMany(p => p.CuentaBancariaDetalleMovimiento)
                .HasForeignKey(d => d.OrdenPagoDetalleId)
                .HasConstraintName("FK_CuentaBancariaDetalleMovimiento_OrdenPagoDetalle");
        });

        modelBuilder.Entity<CuentaMovConcepto>(entity =>
        {
            entity.Property(e => e.CuentaMovConceptoId).HasColumnName("CuentaMovConceptoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CuentaTipoMovimiento>(entity =>
        {
            entity.Property(e => e.CuentaTipoMovimientoId).HasColumnName("CuentaTipoMovimientoID");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CuentasBancos>(entity =>
        {
            entity.HasKey(e => e.CuentaBancoId);

            entity.ToTable("Cuentas_Bancos");

            entity.Property(e => e.Cuenta)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Sucursal)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.Banco).WithMany(p => p.CuentasBancos)
                .HasForeignKey(d => d.BancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuentas_Bancos_Bancos");
        });

        modelBuilder.Entity<CuentasContables>(entity =>
        {
            entity.HasKey(e => e.CuentaContableId);

            entity.ToTable("Cuentas_Contables");

            entity.Property(e => e.CodReferencia)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Cod_Referencia");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsFixedLength();

            entity.HasOne(d => d.TipoCuentaContable).WithMany(p => p.CuentasContables)
                .HasForeignKey(d => d.TipoCuentaContableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuentas_Contables_Tipo_CuentaContable");
        });

        modelBuilder.Entity<CuestionarioTipoRespuesta>(entity =>
        {
            entity.Property(e => e.CuestionarioTipoRespuestaId).HasColumnName("CuestionarioTipoRespuestaID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ddjjdetalle>(entity =>
        {
            entity.ToTable("DDJJDetalle");

            entity.Property(e => e.DdjjdetalleId).HasColumnName("DDJJDetalleID");
            entity.Property(e => e.Cuil)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("CUIL");
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.OperAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OperCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Ddjjempleados>(entity =>
        {
            entity.HasKey(e => e.DdjjempleadoId);

            entity.ToTable("DDJJEmpleados");

            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaConfirma).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioConfirma)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Delegaciones>(entity =>
        {
            entity.HasKey(e => e.IdDelegacion);

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.ConsultasInf).HasDefaultValue(false);
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Informatizada).HasColumnName("informatizada");
            entity.Property(e => e.MonodrogasInf).HasDefaultValue(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PracticasInf).HasDefaultValue(false);
            entity.Property(e => e.TrabajaComoIosepsalud).HasColumnName("TrabajaComoIOSEPSalud");
        });

        modelBuilder.Entity<Departamentos>(entity =>
        {
            entity.HasKey(e => e.DepartamentoId).HasName("PK_Departamentos_1");

            entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
        });

        modelBuilder.Entity<DepositoDetalle>(entity =>
        {
            entity.HasKey(e => e.DetalleId);

            entity.ToTable("Deposito_Detalle");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Encabezado).WithMany(p => p.DepositoDetalle)
                .HasForeignKey(d => d.EncabezadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deposito_Detalle_Deposito_Encabezado");

            entity.HasOne(d => d.NroRegistroNavigation).WithMany(p => p.DepositoDetalle)
                .HasForeignKey(d => d.NroRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deposito_Detalle_Articulos");
        });

        modelBuilder.Entity<DepositoEncabezado>(entity =>
        {
            entity.HasKey(e => e.EncabezadoId).HasName("PK_Deposito_Encabezado_1");

            entity.ToTable("Deposito_Encabezado");

            entity.Property(e => e.FechaCarga)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaMovimiento).HasColumnName("Fecha_Movimiento");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.NumeroReferencia)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.Operador)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Proveedor).WithMany(p => p.DepositoEncabezado)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deposito_Encabezado_Proveedores");

            entity.HasOne(d => d.SectorDestino).WithMany(p => p.DepositoEncabezado)
                .HasForeignKey(d => d.SectorDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deposito_Encabezado_Sectores_Hospital");

            entity.HasOne(d => d.TipoMovimiento).WithMany(p => p.DepositoEncabezado)
                .HasForeignKey(d => d.TipoMovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deposito_Encabezado_Deposito_TipoMovimiento");
        });

        modelBuilder.Entity<DepositoIeestado>(entity =>
        {
            entity.ToTable("DepositoIEEstado");

            entity.Property(e => e.DepositoIeestadoId).HasColumnName("DepositoIEEstadoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DepositoIeestadoHistorico>(entity =>
        {
            entity.ToTable("DepositoIEEstadoHistorico");

            entity.Property(e => e.DepositoIeestadoHistoricoId).HasColumnName("DepositoIEEstadoHistoricoID");
            entity.Property(e => e.DepositoIeestadoId).HasColumnName("DepositoIEEstadoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IngresoEgresoId).HasColumnName("IngresoEgresoID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.DepositoIeestado).WithMany(p => p.DepositoIeestadoHistorico)
                .HasForeignKey(d => d.DepositoIeestadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositoIEEstadoHistorico_DepositoIEEstado");

            entity.HasOne(d => d.IngresoEgreso).WithMany(p => p.DepositoIeestadoHistorico)
                .HasForeignKey(d => d.IngresoEgresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositoIEEstadoHistorico_DepositoIngresoEgreso");
        });

        modelBuilder.Entity<DepositoIngresoEgreso>(entity =>
        {
            entity.HasKey(e => e.IngresoEgresoId);

            entity.Property(e => e.IngresoEgresoId).HasColumnName("IngresoEgresoID");
            entity.Property(e => e.DepositoId).HasColumnName("DepositoID");
            entity.Property(e => e.DepositoIeestadoId).HasColumnName("DepositoIEEstadoID");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IngresoOegreso).HasColumnName("IngresoOEgreso");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ncomprobante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NComprobante");
            entity.Property(e => e.Nexpediente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NExpediente");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OrdenCompraId).HasColumnName("OrdenCompraID");
            entity.Property(e => e.PedidoInternoId).HasColumnName("PedidoInternoID");
            entity.Property(e => e.PedidoSectorId).HasColumnName("PedidoSectorID");
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(150)
                .HasColumnName("UsuarioID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.DepositoIngresoEgreso)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_DepositoIngresoEgreso_Empleados_Hospital");

            entity.HasOne(d => d.PedidoSector).WithMany(p => p.DepositoIngresoEgreso)
                .HasForeignKey(d => d.PedidoSectorId)
                .HasConstraintName("FK_DepositoIngresoEgreso_PedidoSector");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.DepositoIngresoEgreso)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_DepositoIngresoEgreso_Proveedores");
        });

        modelBuilder.Entity<DepositoServicio>(entity =>
        {
            entity.Property(e => e.DepositoServicioId).HasColumnName("DepositoServicioID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DepositoTipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.TipoMovimientoId);

            entity.ToTable("Deposito_TipoMovimiento");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<Depositos>(entity =>
        {
            entity.HasKey(e => e.DepositoId);

            entity.Property(e => e.DepositoId).HasColumnName("DepositoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioAnula).HasMaxLength(11);
        });

        modelBuilder.Entity<DerivacionDetalleGuardia>(entity =>
        {
            entity.Property(e => e.DerivacionDetalleGuardiaId).HasColumnName("DerivacionDetalleGuardiaID");
            entity.Property(e => e.DerivacionesEnviosId).HasColumnName("DerivacionesEnviosID");
            entity.Property(e => e.ShockRoomRegistroId).HasColumnName("ShockRoomRegistroID");
            entity.Property(e => e.ShockRoomTipoAnamnesisId).HasColumnName("ShockRoom_TipoAnamnesisID");

            entity.HasOne(d => d.DerivacionesEnvios).WithMany(p => p.DerivacionDetalleGuardia)
                .HasForeignKey(d => d.DerivacionesEnviosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DerivacionDetalleGuardia_Derivaciones_Envios");

            entity.HasOne(d => d.ShockRoomRegistro).WithMany(p => p.DerivacionDetalleGuardia)
                .HasForeignKey(d => d.ShockRoomRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DerivacionDetalleGuardia_ShockRoom_Registro");

            entity.HasOne(d => d.ShockRoomTipoAnamnesis).WithMany(p => p.DerivacionDetalleGuardia)
                .HasForeignKey(d => d.ShockRoomTipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DerivacionDetalleGuardia_ShockRoom_Tipo_Anamnesis");
        });

        modelBuilder.Entity<DerivacionesDesde>(entity =>
        {
            entity.Property(e => e.DerivacionesDesdeId).HasColumnName("DerivacionesDesdeID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TablaExterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TablaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TablaID");
        });

        modelBuilder.Entity<DerivacionesEnvios>(entity =>
        {
            entity.ToTable("Derivaciones_Envios");

            entity.Property(e => e.DerivacionesEnviosId).HasColumnName("DerivacionesEnviosID");
            entity.Property(e => e.AnamnesisId).HasColumnName("AnamnesisID");
            entity.Property(e => e.FechaRecepcion).HasColumnName("Fecha_Recepcion");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.HoraRecepcion)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Hora_Recepcion");
            entity.Property(e => e.MotivoTraslado)
                .IsUnicode(false)
                .HasColumnName("Motivo_Traslado");
            entity.Property(e => e.MovilHospitalId).HasColumnName("MovilHospitalID");
            entity.Property(e => e.OtroMedioTraslado)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OtrosCentrosId).HasColumnName("OtrosCentrosID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.OtrosCentros).WithMany(p => p.DerivacionesEnvios)
                .HasForeignKey(d => d.OtrosCentrosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Derivaciones_Envios_Otros_Centros");

            entity.HasOne(d => d.Paciente).WithMany(p => p.DerivacionesEnvios)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Derivaciones_Envios_Pacientes");
        });

        modelBuilder.Entity<DetalleAutorizaciones>(entity =>
        {
            entity.HasKey(e => e.DetalleId);

            entity.ToTable("Detalle_Autorizaciones");

            entity.Property(e => e.DetalleId).HasColumnName("DetalleID");
            entity.Property(e => e.CantidadAutorizada).HasColumnName("Cantidad_Autorizada");
            entity.Property(e => e.CantidadSolicitada).HasColumnName("Cantidad_Solicitada");
            entity.Property(e => e.CoseguroGastos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Coseguro_Gastos");
            entity.Property(e => e.CoseguroHonorarios)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Coseguro_Honorarios");
            entity.Property(e => e.EstadoAutorizacion)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("P - ' ' Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada");
            entity.Property(e => e.FacturaGastos)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Factura_Gastos");
            entity.Property(e => e.FacturaHonorarios)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Factura_Honorarios");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MotivoRechazo)
                .IsUnicode(false)
                .HasColumnName("Motivo_Rechazo");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.OperAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.ReconoceGastos)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Reconoce_Gastos");
            entity.Property(e => e.ReconoceHonorarios)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Reconoce_Honorarios");

            entity.HasOne(d => d.Autorizaciones).WithMany(p => p.DetalleAutorizaciones)
                .HasForeignKey(d => d.AutorizacionesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Detalle_Autorizaciones_Encabezado_Autorizaciones");
        });

        modelBuilder.Entity<DetalleImagenes>(entity =>
        {
            entity.ToTable("Detalle_Imagenes");

            entity.Property(e => e.DetalleImagenesId)
                .ValueGeneratedNever()
                .HasColumnName("DetalleImagenesID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<DetalleIngresoEgreso>(entity =>
        {
            entity.HasKey(e => e.DetalleId);

            entity.Property(e => e.DetalleId).HasColumnName("DetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DepositoId).HasColumnName("DepositoID");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.IngresoEgresoId).HasColumnName("IngresoEgresoID");
            entity.Property(e => e.PedIntDetalleRetirarId).HasColumnName("PedIntDetalleRetirarID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.UsuarioEntrega)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IngresoEgreso).WithMany(p => p.DetalleIngresoEgreso)
                .HasForeignKey(d => d.IngresoEgresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleIngresoEgreso_DepositoIngresoEgreso");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleIngresoEgreso)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleIngresoEgreso_Productos");
        });

        modelBuilder.Entity<DetalleTipoRespuesta>(entity =>
        {
            entity.ToTable("Detalle_TipoRespuesta");

            entity.Property(e => e.DetalleTipoRespuestaId).HasColumnName("Detalle_TipoRespuestaID");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");
            entity.Property(e => e.TipoValorId).HasColumnName("TipoValorID");
            entity.Property(e => e.ValorMaximo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ValorMinimo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ValoraAlmacenar)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.TipoRespuesta).WithMany(p => p.DetalleTipoRespuesta)
                .HasForeignKey(d => d.TipoRespuestaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Detalle_TipoRespuesta_Tipo_Respuesta");

            entity.HasOne(d => d.TipoValor).WithMany(p => p.DetalleTipoRespuesta)
                .HasForeignKey(d => d.TipoValorId)
                .HasConstraintName("FK_Detalle_TipoRespuesta_Tipo_Valor");
        });

        modelBuilder.Entity<DiagnosticosConsultas>(entity =>
        {
            entity.ToTable("Diagnosticos_Consultas");

            entity.Property(e => e.DiagnosticosConsultasId).HasColumnName("DiagnosticosConsultasID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DiagnosticosConsultasIdoriginal).HasColumnName("DiagnosticosConsultasIDOriginal");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<DiagnosticosInternado>(entity =>
        {
            entity.ToTable("Diagnosticos_Internado");

            entity.Property(e => e.DiagnosticosInternadoId).HasColumnName("DiagnosticosInternadoID");
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.DiagnosticoPrincipal).HasColumnName("Diagnostico_Principal");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.IngresoAlta)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("Ingreso_Alta");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");

            entity.HasOne(d => d.Diagnostico).WithMany(p => p.DiagnosticosInternado)
                .HasForeignKey(d => d.DiagnosticoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Diagnosticos_Internado_Cie10");

            entity.HasOne(d => d.Internacion).WithMany(p => p.DiagnosticosInternado)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Diagnosticos_Internado_Internaciones");
        });

        modelBuilder.Entity<DiagnosticosIosep>(entity =>
        {
            entity.HasKey(e => e.IdDiagnostico);

            entity.ToTable("DiagnosticosIOSEP");

            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dias>(entity =>
        {
            entity.HasKey(e => e.DiaId);

            entity.Property(e => e.DiaId).HasColumnName("DiaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        modelBuilder.Entity<DietasNodo>(entity =>
        {
            entity.HasKey(e => e.DietaId).HasName("PK_Nodo_Dieta");

            entity.Property(e => e.DietaId).HasColumnName("DietaID");
            entity.Property(e => e.Detalle).HasMaxLength(500);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.OpAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<DispositivoOxigeno>(entity =>
        {
            entity.HasKey(e => e.DispOxigenoId);

            entity.Property(e => e.DispOxigenoId).HasColumnName("DispOxigenoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Domicilios>(entity =>
        {
            entity.HasKey(e => e.DomicilioId);

            entity.Property(e => e.Departamento)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Km)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.NroPuerta)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.Piso)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Torre)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Persona).WithMany(p => p.Domicilios)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Domicilios_Personas");

            entity.HasOne(d => d.TipoDomicilio).WithMany(p => p.Domicilios)
                .HasForeignKey(d => d.TipoDomicilioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Domicilios_Tipo_Domicilio");
        });

        modelBuilder.Entity<Emfermeros>(entity =>
        {
            entity.HasKey(e => e.EmfermeroId);

            entity.Property(e => e.EmfermeroId).HasColumnName("EmfermeroID");
            entity.Property(e => e.Documento).HasMaxLength(50);
            entity.Property(e => e.EmfermeroIdoriginal).HasColumnName("EmfermeroIDOriginal");
            entity.Property(e => e.EnfermeroIdhc).HasColumnName("EnfermeroIDHC");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Usuario).HasMaxLength(20);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
        });

        modelBuilder.Entity<EmfermerosXinstituciones>(entity =>
        {
            entity.ToTable("EmfermerosXInstituciones");

            entity.Property(e => e.EmfermerosXinstitucionesId).HasColumnName("EmfermerosXInstitucionesID");
            entity.Property(e => e.EmfermeroId).HasColumnName("EmfermeroID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmpleadoCapacitacion>(entity =>
        {
            entity.Property(e => e.EmpleadoCapacitacionId).HasColumnName("EmpleadoCapacitacionID");
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.EntidadOtorgante).HasMaxLength(300);
            entity.Property(e => e.EntidadOtorganteId).HasColumnName("EntidadOtorganteID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipoCapacitacionId).HasColumnName("TipoCapacitacionID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Empleado).WithMany(p => p.EmpleadoCapacitacion)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadoCapacitacion_Empleados_Hospital");
        });

        modelBuilder.Entity<EmpleadoCategorias>(entity =>
        {
            entity.HasKey(e => e.EmpleadoCategoriaId);

            entity.Property(e => e.EmpleadoCategoriaId).HasColumnName("EmpleadoCategoriaID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmpleadoDatoEducacion>(entity =>
        {
            entity.Property(e => e.EmpleadoDatoEducacionId).HasColumnName("EmpleadoDatoEducacionID");
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.EspecialidadId)
                .HasDefaultValue(0)
                .HasColumnName("EspecialidadID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.NroMatriculaProfesional).HasMaxLength(50);
            entity.Property(e => e.ProfesionId).HasColumnName("ProfesionID");
            entity.Property(e => e.TipoInstruccionId).HasColumnName("TipoInstruccionID");
            entity.Property(e => e.TituloId).HasColumnName("TituloID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmpleadoDatoLaboral>(entity =>
        {
            entity.Property(e => e.EmpleadoDatoLaboralId).HasColumnName("EmpleadoDatoLaboralID");
            entity.Property(e => e.Basico).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CargaHsExtrasSemanal).HasDefaultValue(0);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.EmpleadoTipoContratoId).HasColumnName("EmpleadoTipoContratoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FuncionId).HasColumnName("FuncionID");
            entity.Property(e => e.MinisterioId).HasColumnName("MinisterioID");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.MotivoEgresoId).HasColumnName("MotivoEgresoID");
            entity.Property(e => e.NroAdmision).HasMaxLength(50);
            entity.Property(e => e.NroControl).HasMaxLength(50);
            entity.Property(e => e.NroLegajo).HasMaxLength(50);
            entity.Property(e => e.SectorId).HasColumnName("SectorID");
            entity.Property(e => e.TipoAdmisionId).HasColumnName("TipoAdmisionID");
            entity.Property(e => e.TipoEmpleadoId).HasColumnName("TipoEmpleadoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmpleadoDomicilio>(entity =>
        {
            entity.Property(e => e.EmpleadoDomicilioId).HasColumnName("EmpleadoDomicilioID");
            entity.Property(e => e.BarrioId).HasColumnName("BarrioID");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.LocalidadId).HasColumnName("LocalidadID");
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Manzana)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NroPuerta).HasMaxLength(50);
            entity.Property(e => e.Piso)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
            entity.Property(e => e.TelefonoCelular).HasMaxLength(50);
            entity.Property(e => e.TelefonoFijo).HasMaxLength(50);
            entity.Property(e => e.Torre)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmpleadoGrupoConvivencia>(entity =>
        {
            entity.Property(e => e.EmpleadoGrupoConvivenciaId).HasColumnName("EmpleadoGrupoConvivenciaID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DdjjempleadoId)
                .HasDefaultValue(0)
                .HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.Discapacidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EnfermedadCronica)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EnfermedadCronicaId).HasColumnName("EnfermedadCronicaID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OcupacionId).HasColumnName("OcupacionID");
            entity.Property(e => e.TelefonoCelular).HasMaxLength(50);
            entity.Property(e => e.TelefonoFijo).HasMaxLength(50);
            entity.Property(e => e.TipoDiscapacidadId).HasColumnName("TipoDiscapacidadID");
            entity.Property(e => e.TipoParentezcoId).HasColumnName("TipoParentezcoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.ObraSocial).WithMany(p => p.EmpleadoGrupoConvivencia)
                .HasForeignKey(d => d.ObraSocialId)
                .HasConstraintName("FK_EmpleadoGrupoConvivencia_ObraSocial");

            entity.HasOne(d => d.TipoParentezco).WithMany(p => p.EmpleadoGrupoConvivencia)
                .HasForeignKey(d => d.TipoParentezcoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadoGrupoConvivencia_Tipo_Parentezco");
        });

        modelBuilder.Entity<EmpleadoInstitucion>(entity =>
        {
            entity.Property(e => e.EmpleadoInstitucionId).HasColumnName("EmpleadoInstitucionID");
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaColocacion).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.MotivoAnula).IsUnicode(false);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmpleadoIntumizacion>(entity =>
        {
            entity.Property(e => e.EmpleadoIntumizacionId).HasColumnName("EmpleadoIntumizacionID");
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaColocacion).HasColumnType("datetime");
            entity.Property(e => e.IntumizacionId).HasColumnName("IntumizacionID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Empleado).WithMany(p => p.EmpleadoIntumizacion)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadoIntumizacion_Empleados_Hospital");

            entity.HasOne(d => d.Intumizacion).WithMany(p => p.EmpleadoIntumizacion)
                .HasForeignKey(d => d.IntumizacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadoIntumizacion_EmpleadoIntumizacion");
        });

        modelBuilder.Entity<EmpleadoTipoContrato>(entity =>
        {
            entity.Property(e => e.EmpleadoTipoContratoId).HasColumnName("EmpleadoTipoContratoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpleadosHospital>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId);

            entity.ToTable("Empleados_Hospital");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BarrioId).HasColumnName("BarrioID");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cuil)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("CUIL");
            entity.Property(e => e.DdjjempleadoId).HasColumnName("DDJJEmpleadoID");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpleadoCategoriaId).HasColumnName("EmpleadoCategoriaID");
            entity.Property(e => e.EmpleadoTipoContratoId).HasColumnName("EmpleadoTipoContratoID");
            entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaEgreso).HasColumnName("Fecha_Egreso");
            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.FotoRuta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Funcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FuncionId).HasColumnName("FuncionID");
            entity.Property(e => e.IdReloj).HasColumnName("idReloj");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Lote).HasMaxLength(50);
            entity.Property(e => e.Manzana).HasMaxLength(50);
            entity.Property(e => e.MinisterioPertenece)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreConyuge)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Conyuge");
            entity.Property(e => e.NroAdmision)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NroControl)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NroLegajo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NroMatriculaProfesional)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NroPuerta).HasMaxLength(50);
            entity.Property(e => e.PersIdenReloj).HasColumnName("PersIDEnReloj");
            entity.Property(e => e.Piso).HasMaxLength(50);
            entity.Property(e => e.ProfesionId).HasColumnName("ProfesionID");
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
            entity.Property(e => e.SectorPlanificacionId).HasColumnName("SectorPlanificacionID");
            entity.Property(e => e.TelefonoCelular)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Telefono_Celular");
            entity.Property(e => e.TelefonoConyuge)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Telefono_Conyuge");
            entity.Property(e => e.TelefonoFijo)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Telefono_Fijo");
            entity.Property(e => e.TipoAdmisionHospitalId).HasColumnName("TipoAdmisionHospitalID");
            entity.Property(e => e.TipoEmpleadoId).HasColumnName("TipoEmpleadoID");
            entity.Property(e => e.TipoInstruccionId).HasColumnName("TipoInstruccionID");
            entity.Property(e => e.Titulo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.TituloId).HasColumnName("TituloID");
            entity.Property(e => e.Torre).HasMaxLength(50);
            entity.Property(e => e.UsuarioBaja)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Especialidad).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.EspecialidadId)
                .HasConstraintName("FK_Empleados_Hospital_Especialidades");

            entity.HasOne(d => d.IdEstadoCivilNavigation).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.IdEstadoCivil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleados_Hospital_EstadoCivil");

            entity.HasOne(d => d.IdLocalidadNavigation).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.IdLocalidad)
                .HasConstraintName("FK_Empleados_Hospital_Localidades");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("FK_Empleados_Hospital_Paises");

            entity.HasOne(d => d.IdSexoNavigation).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.IdSexo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleados_Hospital_Sexo");

            entity.HasOne(d => d.Sector).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.SectorId)
                .HasConstraintName("FK_Empleados_Hospital_Sectores_Hospital");

            entity.HasOne(d => d.TipoAdmisionHospital).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.TipoAdmisionHospitalId)
                .HasConstraintName("FK_Empleados_Hospital_TipoAdmisionHospital");

            entity.HasOne(d => d.TipoEmpleado).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.TipoEmpleadoId)
                .HasConstraintName("FK_Empleados_Hospital_TipoEmpleado");

            entity.HasOne(d => d.TipoInstruccion).WithMany(p => p.EmpleadosHospital)
                .HasForeignKey(d => d.TipoInstruccionId)
                .HasConstraintName("FK_Empleados_Hospital_Tipo_Instruccion");
        });

        modelBuilder.Entity<EmpleadosSectoresPlanificado>(entity =>
        {
            entity.HasKey(e => e.IdEmplaedoSectorPlanificado);

            entity.Property(e => e.SectorPlanificacionId).HasColumnName("SectorPlanificacionID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.EmpleadosSectoresPlanificado)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_EmpleadosSectoresPlanificado_Empleados_Hospital");

            entity.HasOne(d => d.SectorPlanificacion).WithMany(p => p.EmpleadosSectoresPlanificado)
                .HasForeignKey(d => d.SectorPlanificacionId)
                .HasConstraintName("FK_EmpleadosSectoresPlanificado_SectorPlanificacion");
        });

        modelBuilder.Entity<EmpresasColectivos>(entity =>
        {
            entity.HasKey(e => e.EmpresaColectivoId);

            entity.Property(e => e.EmpresaColectivoId).HasColumnName("EmpresaColectivoID");
            entity.Property(e => e.Cuit)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EncabezadoAutorizaciones>(entity =>
        {
            entity.HasKey(e => e.AutorizacionesId);

            entity.ToTable("Encabezado_Autorizaciones");

            entity.Property(e => e.CartaPresentacionId).HasColumnName("CartaPresentacionID");
            entity.Property(e => e.EstadoAutorizacion)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("P - ' ' Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada");
            entity.Property(e => e.FechaEmision)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Emision");
            entity.Property(e => e.FechaImprime).HasColumnType("datetime");
            entity.Property(e => e.FechaPrescripcion).HasColumnName("Fecha_Prescripcion");
            entity.Property(e => e.FechaRemiso).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.IdCentroAfiliado).HasDefaultValue(0);
            entity.Property(e => e.IdCentroImpresion).HasDefaultValue(0);
            entity.Property(e => e.IdGrupoPractica).HasDefaultValue(0);
            entity.Property(e => e.IdMedicoPrescriptor).HasColumnName("IdMedico_Prescriptor");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Marca).HasDefaultValue(false);
            entity.Property(e => e.Modifica).HasColumnType("datetime");
            entity.Property(e => e.MotivoRechazo)
                .IsUnicode(false)
                .HasColumnName("Motivo_Rechazo");
            entity.Property(e => e.Numero)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.NumeroInternacion)
                .HasMaxLength(14)
                .IsFixedLength()
                .HasColumnName("Numero_Internacion");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.OperAnula)
                .HasMaxLength(11)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.OperRemiso)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Operador)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Remiso).HasDefaultValue(false);
            entity.Property(e => e.RemisoCobrado).HasDefaultValue(false);
            entity.Property(e => e.UsuarioImprime)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EncabezadoResultado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EncabezadoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EncabezadoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ImagenPedidoId).HasColumnName("ImagenPedidoID");
            entity.Property(e => e.InformeGeneralId).HasColumnName("informeGeneralID");
            entity.Property(e => e.UsuarioCarga).HasMaxLength(128);

            entity.HasOne(d => d.ImagenPedido).WithMany()
                .HasForeignKey(d => d.ImagenPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EncabezadoResultado_ImagenPedido");
        });

        modelBuilder.Entity<EncuestasBot>(entity =>
        {
            entity.HasKey(e => e.IdEncuesta).HasName("PK_aaa");

            entity.Property(e => e.IdEncuesta).HasColumnName("idEncuesta");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha");
            entity.Property(e => e.InstitucionId).HasColumnName("institucionID");
            entity.Property(e => e.Usuario).HasMaxLength(250);
        });

        modelBuilder.Entity<EnfermedadCronica>(entity =>
        {
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Enfermeria>(entity =>
        {
            entity.Property(e => e.EnfermeriaId).HasColumnName("EnfermeriaID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MedicacionPacienteId).HasColumnName("MedicacionPacienteID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.MedicacionPaciente).WithMany(p => p.Enfermeria)
                .HasForeignKey(d => d.MedicacionPacienteId)
                .HasConstraintName("FK_Enfermeria_MedicacionPaciente");
        });

        modelBuilder.Entity<EntidadesCapacitadoras>(entity =>
        {
            entity.HasKey(e => e.EntidadCapacitadoraId);

            entity.Property(e => e.EntidadCapacitadoraId).HasColumnName("EntidadCapacitadoraID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.TelefonoCelular).HasMaxLength(50);
            entity.Property(e => e.TelefonoFijo).HasMaxLength(50);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EnvioEntreDeposito>(entity =>
        {
            entity.Property(e => e.EnvioEntreDepositoId).HasColumnName("EnvioEntreDepositoID");
            entity.Property(e => e.DepositoDestinoId).HasColumnName("DepositoDestinoID");
            entity.Property(e => e.DepositoOrigenId).HasColumnName("DepositoOrigenID");
            entity.Property(e => e.FechaRecibe).HasColumnType("datetime");
            entity.Property(e => e.NumeroEnvio)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.TipoEstadoEnvioDepositoId).HasColumnName("TipoEstadoEnvioDepositoID");
            entity.Property(e => e.UsuarioRecibe)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EnvioEntreDepositoDetalle>(entity =>
        {
            entity.Property(e => e.EnvioEntreDepositoDetalleId).HasColumnName("EnvioEntreDepositoDetalleID");
            entity.Property(e => e.EnvioEntreDepositoId).HasColumnName("EnvioEntreDepositoID");
            entity.Property(e => e.FarTipoEstadoRecepcionDepositoId).HasColumnName("FarTipoEstadoRecepcionDepositoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Epicrisis>(entity =>
        {
            entity.Property(e => e.EpicrisisId).HasColumnName("EpicrisisID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaEpicrisis).HasColumnType("datetime");
            entity.Property(e => e.FechaHospital).HasColumnType("datetime");
            entity.Property(e => e.FechaUpa)
                .HasColumnType("datetime")
                .HasColumnName("FechaUPA");
            entity.Property(e => e.Hospital).HasMaxLength(300);
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Upa)
                .HasMaxLength(300)
                .HasColumnName("UPA");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Internacion).WithMany(p => p.Epicrisis)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Epicrisis_Internaciones");

            entity.HasOne(d => d.Prestador).WithMany(p => p.Epicrisis)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Epicrisis_Prestadores");
        });

        modelBuilder.Entity<EpicrisisDetalle>(entity =>
        {
            entity.Property(e => e.EpicrisisDetalleId).HasColumnName("EpicrisisDetalleID");
            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.Dosis).HasMaxLength(100);
            entity.Property(e => e.EpicrisisId).HasColumnName("EpicrisisID");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Medicamento).HasMaxLength(300);
            entity.Property(e => e.Tiempo).HasMaxLength(50);
            entity.Property(e => e.Via).HasMaxLength(50);

            entity.HasOne(d => d.Epicrisis).WithMany(p => p.EpicrisisDetalle)
                .HasForeignKey(d => d.EpicrisisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpicrisisDetalle_Epicrisis");
        });

        modelBuilder.Entity<EpicrisisPendiente>(entity =>
        {
            entity.Property(e => e.EpicrisisPendienteId).HasColumnName("EpicrisisPendienteID");
            entity.Property(e => e.EpicrisisId).HasColumnName("EpicrisisID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<EquipoPrestadores>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Tr_EquipoPrestadores"));

            entity.Property(e => e.EquipoPrestadoresId).HasColumnName("EquipoPrestadoresID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Cuil)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaCreaUsuario).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.LocalidadId).HasColumnName("LocalidadID");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TituloId).HasColumnName("TituloID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<EquipoPrestadoresHistorial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EquipoPrestadoresHistorial_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Cuil)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EquipoPrestadoresId).HasColumnName("EquipoPrestadoresID");
            entity.Property(e => e.FechaAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaCreaUsuario).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.LocalidadId).HasColumnName("LocalidadID");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TituloId).HasColumnName("TituloID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Especialidades>(entity =>
        {
            entity.HasKey(e => e.EspecialidadId);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_EdicionEspecialidadesHCWeb");
                    tb.HasTrigger("Tr_RegistroEspecialidadesHCWeb");
                });

            entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");
            entity.Property(e => e.EspecialidadIdhc).HasColumnName("EspecialidadIDHC");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<EstadoCivil>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCivil);

            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<EstadoEquipo>(entity =>
        {
            entity.Property(e => e.EstadoEquipoId).HasColumnName("EstadoEquipoID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<EventoDetalle>(entity =>
        {
            entity.ToTable("Evento_Detalle");

            entity.Property(e => e.EventoDetalleId).HasColumnName("EventoDetalleID");
            entity.Property(e => e.AnamnesisDetalleId).HasColumnName("AnamnesisDetalleID");
            entity.Property(e => e.EventoDetalleIdoriginal).HasColumnName("EventoDetalleIDOriginal");
            entity.Property(e => e.EventoEncabezadoId).HasColumnName("EventoEncabezadoID");
            entity.Property(e => e.ValorId).HasColumnName("ValorID");

            entity.HasOne(d => d.AnamnesisDetalle).WithMany(p => p.EventoDetalle)
                .HasForeignKey(d => d.AnamnesisDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evento_Detalle_Anamnesis_Detalle");

            entity.HasOne(d => d.EventoEncabezado).WithMany(p => p.EventoDetalle)
                .HasForeignKey(d => d.EventoEncabezadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evento_Detalle_Evento_Encabezado");
        });

        modelBuilder.Entity<EventoEncabezado>(entity =>
        {
            entity.HasKey(e => e.EventoEncabezadoId);

            entity.ToTable("Evento_Encabezado");

            entity.Property(e => e.EventoEncabezadoId).HasColumnName("EventoEncabezadoID");
            entity.Property(e => e.Crea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.EventoEncabezadoIdoriginal).HasColumnName("EventoEncabezadoIDOriginal");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdhistoriaClinica).HasColumnName("IDHistoriaClinica");
            entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");

            entity.HasOne(d => d.TipoAnamnesis).WithMany(p => p.EventoEncabezado)
                .HasForeignKey(d => d.TipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evento_Encabezado_Tipo_Anamnesis");
        });

        modelBuilder.Entity<Evolucion>(entity =>
        {
            entity.Property(e => e.EvolucionId).HasColumnName("EvolucionID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaEvolucion).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MovimientoInternadoId).HasColumnName("MovimientoInternadoID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Internacion).WithMany(p => p.Evolucion)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evolucion_Evolucion");

            entity.HasOne(d => d.Prestador).WithMany(p => p.Evolucion)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evolucion_Prestadores");
        });

        modelBuilder.Entity<EvolucionZismedIosep>(entity =>
        {
            entity.ToTable("EvolucionZismedIOSEP");

            entity.HasIndex(e => new { e.InternacionId, e.Anulado }, "EvolucionInternacionID");

            entity.Property(e => e.EvolucionZismedIosepid).HasColumnName("EvolucionZismedIOSEPID");
            entity.Property(e => e.EvolucionHcwebId).HasColumnName("EvolucionHCWebID");
            entity.Property(e => e.EvolucionIosepid).HasColumnName("EvolucionIOSEPID");
            entity.Property(e => e.FechaActualiza).HasColumnType("datetime");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.UsuarioActualiza)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Expediente>(entity =>
        {
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.NroAsunto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NroExpediente)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RefExpediente)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarDetalleCompras>(entity =>
        {
            entity.HasKey(e => e.IdDetalleCompra).HasName("PK_Far_Detalle_Compras_1");

            entity.ToTable("Far_Detalle_Compras");

            entity.Property(e => e.IdDetalleCompra).HasColumnName("IdDetalle_compra");
            entity.Property(e => e.Articulo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Codbarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.Crea).HasColumnType("datetime");
            entity.Property(e => e.Gtin)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.IdEncabezadoCompra).HasColumnName("IdEncabezado_compra");
            entity.Property(e => e.Impuestos).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Modi).HasColumnType("datetime");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PrecioCosto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Precio_Costo");
            entity.Property(e => e.Vence)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<FarDetalleVentas>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVentas);

            entity.ToTable("Far_Detalle_Ventas");

            entity.Property(e => e.IdDetalleVentas).HasColumnName("IdDetalle_Ventas");
            entity.Property(e => e.Articulo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CodBarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Crea).HasColumnType("datetime");
            entity.Property(e => e.Gtin)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.IdEncabezadoVenta).HasColumnName("IdEncabezado_venta");
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Modi).HasColumnType("datetime");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_venta");
            entity.Property(e => e.Reconoce).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Vence)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<FarEncabezadoCompras>(entity =>
        {
            entity.HasKey(e => e.IdEncabezadoCompras).HasName("PK_Far_Encabezado_Compras_1");

            entity.ToTable("Far_Encabezado_Compras");

            entity.Property(e => e.IdEncabezadoCompras).HasColumnName("IdEncabezado_Compras");
            entity.Property(e => e.CaiComprobante)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("CAI_Comprobante");
            entity.Property(e => e.Crea).HasColumnType("datetime");
            entity.Property(e => e.FechaRecepcion).HasColumnName("Fecha_Recepcion");
            entity.Property(e => e.Gnl)
                .HasMaxLength(14)
                .IsFixedLength()
                .HasColumnName("GNL");
            entity.Property(e => e.HoraRecepcion)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Hora_Recepcion");
            entity.Property(e => e.IdTipoComprobante).HasColumnName("IdTipo_Comprobante");
            entity.Property(e => e.Modi).HasColumnType("datetime");
            entity.Property(e => e.NumeroComprobante)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("Numero_Comprobante");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.SucursalId).HasColumnName("SucursalID");

            entity.HasOne(d => d.IdTipoComprobanteNavigation).WithMany(p => p.FarEncabezadoCompras)
                .HasForeignKey(d => d.IdTipoComprobante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_Encabezado_Compras_Far_Tipo_Movimiento1");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.FarEncabezadoCompras)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_Encabezado_Compras_Proveedores");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.FarEncabezadoCompras)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK_Far_Encabezado_Compras_Far_Sucursales");
        });

        modelBuilder.Entity<FarEncabezadoVenta>(entity =>
        {
            entity.HasKey(e => e.IdEncabezadoVenta);

            entity.ToTable("Far_Encabezado_Venta");

            entity.Property(e => e.IdEncabezadoVenta).HasColumnName("IdEncabezado_Venta");
            entity.Property(e => e.Cobra).HasColumnType("datetime");
            entity.Property(e => e.Crea).HasColumnType("datetime");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.IdTipoComprobante).HasColumnName("IdTipo_Comprobante");
            entity.Property(e => e.Modi).HasColumnType("datetime");
            entity.Property(e => e.NumeroComprobante)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("Numero_Comprobante");
            entity.Property(e => e.OpCobra)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
        });

        modelBuilder.Entity<FarIdentificacionCompras>(entity =>
        {
            entity.HasKey(e => e.IdIdentificacionCompras);

            entity.ToTable("Far_Identificacion_Compras");

            entity.Property(e => e.IdIdentificacionCompras).HasColumnName("IdIdentificacion_Compras");
            entity.Property(e => e.IdDetalleCompras).HasColumnName("IdDetalle_Compras");
            entity.Property(e => e.IdDetalleVentas).HasColumnName("IdDetalle_ventas");
            entity.Property(e => e.NroLote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NroSerie)
                .HasMaxLength(20)
                .IsFixedLength();

            entity.HasOne(d => d.IdDetalleVentasNavigation).WithMany(p => p.FarIdentificacionCompras)
                .HasForeignKey(d => d.IdDetalleVentas)
                .HasConstraintName("FK_Far_Identificacion_Compras_Far_Detalle_Ventas");
        });

        modelBuilder.Entity<FarMedicamento>(entity =>
        {
            entity.ToTable("Far_Medicamento");

            entity.Property(e => e.FarMedicamentoId).HasColumnName("Far_MedicamentoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FarTipoMedicamentoId).HasColumnName("Far_TipoMedicamentoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Presentacion)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.FarTipoMedicamento).WithMany(p => p.FarMedicamento)
                .HasForeignKey(d => d.FarTipoMedicamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_Medicamento_Far_TipoMedicamento");
        });

        modelBuilder.Entity<FarRemitoTemporalDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalleTemporal);

            entity.ToTable("Far_RemitoTemporal_Detalle");

            entity.Property(e => e.Articulo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CantidadRecibida)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Cantidad_Recibida");
            entity.Property(e => e.CodBarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.Gtin)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RemitoNumero)
                .HasMaxLength(14)
                .IsFixedLength()
                .HasColumnName("Remito_Numero");
            entity.Property(e => e.Vence)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.IdEncabezadoTemporalNavigation).WithMany(p => p.FarRemitoTemporalDetalle)
                .HasForeignKey(d => d.IdEncabezadoTemporal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_RemitoTemporal_Detalle_Far_RemitoTemporal_Encabezado");
        });

        modelBuilder.Entity<FarRemitoTemporalDetalleLoteVto>(entity =>
        {
            entity.HasKey(e => e.IdDetalleTemporalLoteVto);

            entity.ToTable("Far_RemitoTemporal_Detalle_LoteVto");

            entity.Property(e => e.CantidadRecibida)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Cantidad_Recibida");
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Vence)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.IdDetalleTemporalNavigation).WithMany(p => p.FarRemitoTemporalDetalleLoteVto)
                .HasForeignKey(d => d.IdDetalleTemporal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_RemitoTemporal_Detalle_LoteVto_Far_RemitoTemporal_Detalle");
        });

        modelBuilder.Entity<FarRemitoTemporalEncabezado>(entity =>
        {
            entity.HasKey(e => e.IdEncabezadoTemporal);

            entity.ToTable("Far_RemitoTemporal_Encabezado");

            entity.Property(e => e.Crea).HasColumnType("datetime");
            entity.Property(e => e.FechaRecibido).HasColumnName("Fecha_Recibido");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.HoraRecibido)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Hora_Recibido");
            entity.Property(e => e.Modi).HasColumnType("datetime");
            entity.Property(e => e.Numero)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("OpMOdi");
            entity.Property(e => e.RecibidoFaltantes)
                .HasDefaultValue(false)
                .HasColumnName("Recibido_Faltantes");

            entity.HasOne(d => d.Estado).WithMany(p => p.FarRemitoTemporalEncabezado)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_RemitoTemporal_Encabezado_EstadoId");

            entity.HasOne(d => d.SucursalDestino).WithMany(p => p.FarRemitoTemporalEncabezadoSucursalDestino)
                .HasForeignKey(d => d.SucursalDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_RemitoTemporal_Encabezado_SucursalDestinoId");

            entity.HasOne(d => d.SucursalOrigen).WithMany(p => p.FarRemitoTemporalEncabezadoSucursalOrigen)
                .HasForeignKey(d => d.SucursalOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_RemitoTemporal_Encabezado_SucursalOrigenId");
        });

        modelBuilder.Entity<FarSucursales>(entity =>
        {
            entity.HasKey(e => e.SucursalId);

            entity.ToTable("Far_Sucursales");

            entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuntoVenta)
                .HasMaxLength(4)
                .IsFixedLength();
        });

        modelBuilder.Entity<FarTipoComprobante>(entity =>
        {
            entity.Property(e => e.FarTipoComprobanteId).HasColumnName("FarTipoComprobanteID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.CreaUsuario)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarTipoEgreso>(entity =>
        {
            entity.Property(e => e.FarTipoEgresoId).HasColumnName("FarTipoEgresoID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.CreaUsuario)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarTipoEstadoEnvioDeposito>(entity =>
        {
            entity.Property(e => e.FarTipoEstadoEnvioDepositoId).HasColumnName("FarTipoEstadoEnvioDepositoID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.CreaUsuario)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarTipoEstadoRecepcionDeposito>(entity =>
        {
            entity.Property(e => e.FarTipoEstadoRecepcionDepositoId).HasColumnName("FarTipoEstadoRecepcionDepositoID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.CreaUsuario)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarTipoIngreso>(entity =>
        {
            entity.Property(e => e.FarTipoIngresoId).HasColumnName("FarTipoIngresoID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.CreaUsuario)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarTipoMedicamento>(entity =>
        {
            entity.ToTable("Far_TipoMedicamento");

            entity.Property(e => e.FarTipoMedicamentoId).HasColumnName("Far_TipoMedicamentoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarTipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.IdTipoMovimiento).HasName("PK_Far_Tipo_Movimiento_1");

            entity.ToTable("Far_Tipo_Movimiento");

            entity.Property(e => e.IdTipoMovimiento).HasColumnName("IdTipo_Movimiento");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VentaCompra)
                .HasMaxLength(1)
                .HasDefaultValue("A")
                .IsFixedLength()
                .HasColumnName("Venta_Compra");
        });

        modelBuilder.Entity<FarVentasPagos>(entity =>
        {
            entity.HasKey(e => e.IdExtraPagos);

            entity.ToTable("Far_Ventas_Pagos");

            entity.Property(e => e.IdExtraPagos).HasColumnName("IdExtra_Pagos");
            entity.Property(e => e.IdEncabezadoVenta).HasColumnName("IdEncabezado_venta");
            entity.Property(e => e.ValorCuota).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdEncabezadoVentaNavigation).WithMany(p => p.FarVentasPagos)
                .HasForeignKey(d => d.IdEncabezadoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Far_Ventas_Pagos_Far_Encabezado_Venta");
        });

        modelBuilder.Entity<FarmaciaArticulo>(entity =>
        {
            entity.HasIndex(e => e.NroRegistro, "FarmaciaBusqueda");

            entity.HasIndex(e => new { e.BajaAlfabeta, e.Anulado, e.NroRegistro }, "_dta_index_FarmaciaArticulo_6_1702349179__K9_K15_K2_1");

            entity.Property(e => e.FarmaciaArticuloId).HasColumnName("FarmaciaArticuloID");
            entity.Property(e => e.CodigoArticulo)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.CodigoBarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.FechaBajaAlfabeta).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Presentacion).HasMaxLength(100);
            entity.Property(e => e.StockMinimo).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<FarmaciaArticuloDeposito>(entity =>
        {
            entity.Property(e => e.FarmaciaArticuloDepositoId).HasColumnName("FarmaciaArticuloDepositoID");
            entity.Property(e => e.FarmaciaArticuloAnteriorId).HasColumnName("FarmaciaArticuloAnteriorID");
            entity.Property(e => e.FarmaciaArticuloId).HasColumnName("FarmaciaArticuloID");
            entity.Property(e => e.FarmaciaDepositoId).HasColumnName("FarmaciaDepositoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarmaciaArticulo).WithMany(p => p.FarmaciaArticuloDeposito)
                .HasForeignKey(d => d.FarmaciaArticuloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaArticuloDeposito_FarmaciaArticulo");

            entity.HasOne(d => d.FarmaciaDeposito).WithMany(p => p.FarmaciaArticuloDeposito)
                .HasForeignKey(d => d.FarmaciaDepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaArticuloDeposito_FarmaciaDeposito");
        });

        modelBuilder.Entity<FarmaciaArticuloDepositoLoteVto>(entity =>
        {
            entity.Property(e => e.FarmaciaArticuloDepositoLoteVtoId).HasColumnName("FarmaciaArticuloDepositoLoteVtoID");
            entity.Property(e => e.FarmaciaArticuloAnteriorId).HasColumnName("FarmaciaArticuloAnteriorID");
            entity.Property(e => e.FarmaciaArticuloDepositoId).HasColumnName("FarmaciaArticuloDepositoID");
            entity.Property(e => e.FarmaciaArticuloId).HasColumnName("FarmaciaArticuloID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Lote).HasMaxLength(30);
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarmaciaArticuloDeposito).WithMany(p => p.FarmaciaArticuloDepositoLoteVto)
                .HasForeignKey(d => d.FarmaciaArticuloDepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaArticuloDepositoLoteVto_FarmaciaArticuloDeposito");

            entity.HasOne(d => d.FarmaciaArticulo).WithMany(p => p.FarmaciaArticuloDepositoLoteVto)
                .HasForeignKey(d => d.FarmaciaArticuloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaArticuloDepositoLoteVto_FarmaciaArticulo");
        });

        modelBuilder.Entity<FarmaciaDeposito>(entity =>
        {
            entity.Property(e => e.FarmaciaDepositoId).HasColumnName("FarmaciaDepositoID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<FarmaciaEgreso>(entity =>
        {
            entity.Property(e => e.FarmaciaEgresoId).HasColumnName("FarmaciaEgresoID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FarTipoEgresoId).HasColumnName("FarTipoEgresoID");
            entity.Property(e => e.FarmaciaDepositoId).HasColumnName("FarmaciaDepositoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.MedicacionPacienteId).HasColumnName("MedicacionPacienteID");
            entity.Property(e => e.NumeroEgreso)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.Observaciones).HasMaxLength(300);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PedidoInternoFarmaciaId).HasColumnName("PedidoInternoFarmaciaID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarTipoEgreso).WithMany(p => p.FarmaciaEgreso)
                .HasForeignKey(d => d.FarTipoEgresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEgreso_FarTipoEgreso");

            entity.HasOne(d => d.FarmaciaDeposito).WithMany(p => p.FarmaciaEgreso)
                .HasForeignKey(d => d.FarmaciaDepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEgreso_FarmaciaDeposito");
        });

        modelBuilder.Entity<FarmaciaEgresoDetalle>(entity =>
        {
            entity.Property(e => e.FarmaciaEgresoDetalleId).HasColumnName("FarmaciaEgresoDetalleID");
            entity.Property(e => e.ArticuloFarmaciaCisId).HasColumnName("ArticuloFarmaciaCisID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CodBarras).HasMaxLength(30);
            entity.Property(e => e.FarmaciaEgresoId).HasColumnName("FarmaciaEgresoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Gtin).HasMaxLength(30);
            entity.Property(e => e.Lote).HasMaxLength(30);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.ArticuloFarmaciaCis).WithMany(p => p.FarmaciaEgresoDetalle)
                .HasForeignKey(d => d.ArticuloFarmaciaCisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEgresoDetalle_ArticulosFarmaciaCis");

            entity.HasOne(d => d.FarmaciaEgreso).WithMany(p => p.FarmaciaEgresoDetalle)
                .HasForeignKey(d => d.FarmaciaEgresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEgresoDetalle_FarmaciaEgreso");
        });

        modelBuilder.Entity<FarmaciaEnvioDeposito>(entity =>
        {
            entity.Property(e => e.FarmaciaEnvioDepositoId).HasColumnName("FarmaciaEnvioDepositoID");
            entity.Property(e => e.FarTipoEstadoEnvioDepositoId).HasColumnName("FarTipoEstadoEnvioDepositoID");
            entity.Property(e => e.FarmaciaDepositoDestinoId).HasColumnName("FarmaciaDepositoDestinoID");
            entity.Property(e => e.FarmaciaDepositoOrigenId).HasColumnName("FarmaciaDepositoOrigenID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaRecibe).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.NumeroEnvio)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioRecibe)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarTipoEstadoEnvioDeposito).WithMany(p => p.FarmaciaEnvioDeposito)
                .HasForeignKey(d => d.FarTipoEstadoEnvioDepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDeposito_FarTipoEstadoEnvioDeposito");

            entity.HasOne(d => d.FarmaciaDepositoDestino).WithMany(p => p.FarmaciaEnvioDepositoFarmaciaDepositoDestino)
                .HasForeignKey(d => d.FarmaciaDepositoDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDeposito_FarmaciaDeposito1");

            entity.HasOne(d => d.FarmaciaDepositoOrigen).WithMany(p => p.FarmaciaEnvioDepositoFarmaciaDepositoOrigen)
                .HasForeignKey(d => d.FarmaciaDepositoOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDeposito_FarmaciaDeposito");
        });

        modelBuilder.Entity<FarmaciaEnvioDepositoDetalle>(entity =>
        {
            entity.Property(e => e.FarmaciaEnvioDepositoDetalleId).HasColumnName("FarmaciaEnvioDepositoDetalleID");
            entity.Property(e => e.CantidadEnviada).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CantidadRecibida).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CodBarras).HasMaxLength(30);
            entity.Property(e => e.FarTipoEstadoRecepcionDepositoId).HasColumnName("FarTipoEstadoRecepcionDepositoID");
            entity.Property(e => e.FarmaciaArticuloId).HasColumnName("FarmaciaArticuloID");
            entity.Property(e => e.FarmaciaEnvioDepositoId).HasColumnName("FarmaciaEnvioDepositoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Gtin).HasMaxLength(30);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarTipoEstadoRecepcionDeposito).WithMany(p => p.FarmaciaEnvioDepositoDetalle)
                .HasForeignKey(d => d.FarTipoEstadoRecepcionDepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDepositoDetalle_FarTipoEstadoRecepcionDeposito");

            entity.HasOne(d => d.FarmaciaArticulo).WithMany(p => p.FarmaciaEnvioDepositoDetalle)
                .HasForeignKey(d => d.FarmaciaArticuloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDepositoDetalle_FarmaciaArticulo");

            entity.HasOne(d => d.FarmaciaEnvioDeposito).WithMany(p => p.FarmaciaEnvioDepositoDetalle)
                .HasForeignKey(d => d.FarmaciaEnvioDepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDepositoDetalle_FarmaciaEnvioDeposito");
        });

        modelBuilder.Entity<FarmaciaEnvioDepositoDetalleLoteVto>(entity =>
        {
            entity.Property(e => e.FarmaciaEnvioDepositoDetalleLoteVtoId).HasColumnName("FarmaciaEnvioDepositoDetalleLoteVtoID");
            entity.Property(e => e.CantidadEnviada).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CantidadRecibida).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FarmaciaArticuloId).HasColumnName("FarmaciaArticuloID");
            entity.Property(e => e.FarmaciaEnvioDepositoDetalleId).HasColumnName("FarmaciaEnvioDepositoDetalleID");
            entity.Property(e => e.Lote).HasMaxLength(30);

            entity.HasOne(d => d.FarmaciaArticulo).WithMany(p => p.FarmaciaEnvioDepositoDetalleLoteVto)
                .HasForeignKey(d => d.FarmaciaArticuloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDepositoDetalleLoteVto_FarmaciaArticulo");

            entity.HasOne(d => d.FarmaciaEnvioDepositoDetalle).WithMany(p => p.FarmaciaEnvioDepositoDetalleLoteVto)
                .HasForeignKey(d => d.FarmaciaEnvioDepositoDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaEnvioDepositoDetalleLoteVto_FarmaciaEnvioDepositoDetalle");
        });

        modelBuilder.Entity<FarmaciaIngreso>(entity =>
        {
            entity.Property(e => e.FarmaciaIngresoId).HasColumnName("FarmaciaIngresoID");
            entity.Property(e => e.Caicomprobante)
                .HasMaxLength(30)
                .HasColumnName("CAIComprobante");
            entity.Property(e => e.FarTipoComprobanteId).HasColumnName("FarTipoComprobanteID");
            entity.Property(e => e.FarTipoIngresoId).HasColumnName("FarTipoIngresoID");
            entity.Property(e => e.FarmaciaDepositoId).HasColumnName("FarmaciaDepositoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraRecepcion).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Gnl)
                .HasMaxLength(30)
                .HasColumnName("GNL");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.NumeroComprobante)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.NumeroIngreso)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarTipoComprobante).WithMany(p => p.FarmaciaIngreso)
                .HasForeignKey(d => d.FarTipoComprobanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaIngreso_FarTipoComprobante");

            entity.HasOne(d => d.FarTipoIngreso).WithMany(p => p.FarmaciaIngreso)
                .HasForeignKey(d => d.FarTipoIngresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaIngreso_FarTipoIngreso");

            entity.HasOne(d => d.FarmaciaDeposito).WithMany(p => p.FarmaciaIngreso)
                .HasForeignKey(d => d.FarmaciaDepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaIngreso_FarmaciaDeposito");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.FarmaciaIngreso)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_FarmaciaIngreso_Proveedores");
        });

        modelBuilder.Entity<FarmaciaIngresoDetalle>(entity =>
        {
            entity.Property(e => e.FarmaciaIngresoDetalleId).HasColumnName("FarmaciaIngresoDetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CodBarras).HasMaxLength(30);
            entity.Property(e => e.FarmaciaArticuloAnteriorId).HasColumnName("FarmaciaArticuloAnteriorID");
            entity.Property(e => e.FarmaciaArticuloId).HasColumnName("FarmaciaArticuloID");
            entity.Property(e => e.FarmaciaIngresoId).HasColumnName("FarmaciaIngresoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Gtin).HasMaxLength(30);
            entity.Property(e => e.Impuestos).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Lote).HasMaxLength(30);
            entity.Property(e => e.PrecioCosto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarmaciaArticulo).WithMany(p => p.FarmaciaIngresoDetalle)
                .HasForeignKey(d => d.FarmaciaArticuloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaIngresoDetalle_ArticulosFarmaciaCis");

            entity.HasOne(d => d.FarmaciaIngreso).WithMany(p => p.FarmaciaIngresoDetalle)
                .HasForeignKey(d => d.FarmaciaIngresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaIngresoDetalle_FarmaciaIngreso");
        });

        modelBuilder.Entity<FarmaciaPresentacionesBusqueda>(entity =>
        {
            entity.Property(e => e.FarmaciaPresentacionesBusquedaId).HasColumnName("FarmaciaPresentacionesBusquedaID");
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FarmaciaSucursalXusuario>(entity =>
        {
            entity.ToTable("FarmaciaSucursalXUsuario");

            entity.Property(e => e.FarmaciaSucursalXusuarioId).HasColumnName("FarmaciaSucursalXUsuarioID");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.FarmaciaSucursalXusuario)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaSucursalXUsuario_FarmaciaSucursal");

            entity.HasOne(d => d.User).WithMany(p => p.FarmaciaSucursalXusuario)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FarmaciaSucursalXUsuario_AspNetUsers");
        });

        modelBuilder.Entity<Feriado>(entity =>
        {
            entity.Property(e => e.FeriadoId).HasColumnName("FeriadoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FeriadoFecha).HasColumnType("datetime");
            entity.Property(e => e.FeriadoHoraDesde)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.FeriadoHoraHasta)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.TipoFeriadoId).HasColumnName("TipoFeriadoID");
        });

        modelBuilder.Entity<FeriadosAsuetos>(entity =>
        {
            entity.HasKey(e => e.IdFeriadoAsueto);

            entity.Property(e => e.Detalle).HasMaxLength(300);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.UsuarioBorra)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioBorra");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCrea");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioModifica");
        });

        modelBuilder.Entity<FojaQuirurjica>(entity =>
        {
            entity.Property(e => e.FojaQuirurjicaId).HasColumnName("FojaQuirurjicaID");
            entity.Property(e => e.Diagnostico).HasMaxLength(300);
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.DiagnosticoPostoperatorio).HasMaxLength(300);
            entity.Property(e => e.DiagnosticoPreoperatorio).HasMaxLength(300);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.HoraFin)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HoraInicio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MovimientoId).HasColumnName("MovimientoID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.DiagnosticoNavigation).WithMany(p => p.FojaQuirurjica)
                .HasForeignKey(d => d.DiagnosticoId)
                .HasConstraintName("FK_FojaQuirurjica_Cie10");

            entity.HasOne(d => d.Internacion).WithMany(p => p.FojaQuirurjica)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FojaQuirurjica_Internaciones");
        });

        modelBuilder.Entity<FondoPermanente>(entity =>
        {
            entity.Property(e => e.FondoPermanenteId).HasColumnName("FondoPermanenteID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FondoPermanenteEstadoId).HasColumnName("FondoPermanenteEstadoID");
            entity.Property(e => e.ImporteTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NroComprobante)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FondoPermanenteEstado).WithMany(p => p.FondoPermanente)
                .HasForeignKey(d => d.FondoPermanenteEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FondoPermanente_FondoPermanenteEstado");
        });

        modelBuilder.Entity<FondoPermanenteDetalle>(entity =>
        {
            entity.Property(e => e.FondoPermanenteDetalleId).HasColumnName("FondoPermanenteDetalleID");
            entity.Property(e => e.FondoPermanenteId).HasColumnName("FondoPermanenteID");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
        });

        modelBuilder.Entity<FondoPermanenteEstado>(entity =>
        {
            entity.Property(e => e.FondoPermanenteEstadoId).HasColumnName("FondoPermanenteEstadoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FormatoConsentimiento>(entity =>
        {
            entity.Property(e => e.FormatoConsentimientoId).HasColumnName("FormatoConsentimientoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.TipoConsentimientoId).HasColumnName("TipoConsentimientoID");
            entity.Property(e => e.UsuarioAnula).HasMaxLength(11);
            entity.Property(e => e.UsuarioCrea).HasMaxLength(11);
        });

        modelBuilder.Entity<Funcion>(entity =>
        {
            entity.Property(e => e.FuncionId).HasColumnName("FuncionID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<GrupoFamiliar>(entity =>
        {
            entity.ToTable("Grupo_Familiar");

            entity.Property(e => e.GrupoFamiliarId)
                .ValueGeneratedNever()
                .HasColumnName("GrupoFamiliarID");
            entity.Property(e => e.FamiliarId).HasColumnName("FamiliarID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.TipoParentezcoId).HasColumnName("TipoParentezcoID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.GrupoFamiliar)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grupo_Familiar_Pacientes");

            entity.HasOne(d => d.TipoParentezco).WithMany(p => p.GrupoFamiliar)
                .HasForeignKey(d => d.TipoParentezcoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grupo_Familiar_Tipo_Parentezco");
        });

        modelBuilder.Entity<Grupos>(entity =>
        {
            entity.HasKey(e => e.GrupoId);

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GruposPersonas>(entity =>
        {
            entity.HasKey(e => e.GrupoPersonaId);

            entity.ToTable("Grupos_Personas");

            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_Ingreso");

            entity.HasOne(d => d.Grupo).WithMany(p => p.GruposPersonas)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grupos_Personas_Grupos");

            entity.HasOne(d => d.Persona).WithMany(p => p.GruposPersonas)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grupos_Personas_Personas");
        });

        modelBuilder.Entity<GuardiaAnamnesis>(entity =>
        {
            entity.Property(e => e.GuardiaAnamnesisId).HasColumnName("GuardiaAnamnesisID");
            entity.Property(e => e.EmfermeroId).HasColumnName("EmfermeroID");
            entity.Property(e => e.FechaAnamneisis).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.GuardiaTipoCuestionarioId).HasColumnName("GuardiaTipoCuestionarioID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.GuardiaRegistro).WithMany(p => p.GuardiaAnamnesis)
                .HasForeignKey(d => d.GuardiaRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaAnamnesis_GuardiaRegistro");

            entity.HasOne(d => d.GuardiaTipoCuestionario).WithMany(p => p.GuardiaAnamnesis)
                .HasForeignKey(d => d.GuardiaTipoCuestionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaAnamnesis_GuardiaTipoCuestionario");

            entity.HasOne(d => d.Prestador).WithMany(p => p.GuardiaAnamnesis)
                .HasForeignKey(d => d.PrestadorId)
                .HasConstraintName("FK_GuardiaAnamnesis_Prestadores");
        });

        modelBuilder.Entity<GuardiaCama>(entity =>
        {
            entity.Property(e => e.GuardiaCamaId).HasColumnName("GuardiaCamaID");
            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GuardiaDerivacionExterna>(entity =>
        {
            entity.HasIndex(e => e.GuardiaRegistroId, "Ix_GuardiaDerivacionExterna_GuardiaRegistroID");

            entity.Property(e => e.GuardiaDerivacionExternaId).HasColumnName("GuardiaDerivacionExternaID");
            entity.Property(e => e.Antecedentes).HasMaxLength(500);
            entity.Property(e => e.CentroId).HasColumnName("CentroID");
            entity.Property(e => e.EstudiosComp).HasMaxLength(500);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.MedicacionSum).HasMaxLength(500);
            entity.Property(e => e.Motivo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MovilId).HasColumnName("MovilID");
            entity.Property(e => e.OtroCentro).HasMaxLength(100);
            entity.Property(e => e.OtroMedioTraslado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.SectorInternadoId).HasColumnName("SectorInternadoID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.GuardiaRegistro).WithMany(p => p.GuardiaDerivacionExterna)
                .HasForeignKey(d => d.GuardiaRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaDerivacionExterna_GuardiaRegistro");

            entity.HasOne(d => d.GuardiaSector).WithMany(p => p.GuardiaDerivacionExterna)
                .HasForeignKey(d => d.GuardiaSectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaDerivacionExterna_GuardiaSector");

            entity.HasOne(d => d.Movil).WithMany(p => p.GuardiaDerivacionExterna)
                .HasForeignKey(d => d.MovilId)
                .HasConstraintName("FK_GuardiaDerivacionExterna_MovilHospital");

            entity.HasOne(d => d.Prestador).WithMany(p => p.GuardiaDerivacionExterna)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaDerivacionExterna_Prestadores");

            entity.HasOne(d => d.SectorInternado).WithMany(p => p.GuardiaDerivacionExterna)
                .HasForeignKey(d => d.SectorInternadoId)
                .HasConstraintName("FK_GuardiaDerivacionExterna_Habitaciones_Hospital");

            entity.HasOne(d => d.Servicio).WithMany(p => p.GuardiaDerivacionExterna)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK_GuardiaDerivacionExterna_Servicios");
        });

        modelBuilder.Entity<GuardiaDerivacionInterna>(entity =>
        {
            entity.HasIndex(e => e.GuardiaRegistroId, "Ix_GuardiaDerivacionInterna_GuardiaRegistroID");

            entity.HasIndex(e => new { e.GuardiaRegistroId, e.GuardiaDerivacionInternaId, e.GuardiaCamaId }, "_dta_index_GuardiaDerivacionInterna_6_2113494658__K2_K1_K6");

            entity.Property(e => e.GuardiaDerivacionInternaId).HasColumnName("GuardiaDerivacionInternaID");
            entity.Property(e => e.ConsultorioDesdeId).HasColumnName("ConsultorioDesdeID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.GuardiaCamaId).HasColumnName("GuardiaCamaID");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorDesdeId).HasColumnName("GuardiaSectorDesdeID");
            entity.Property(e => e.GuardiaSectorHastaId).HasColumnName("GuardiaSectorHastaID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Prestador).WithMany(p => p.GuardiaDerivacionInterna)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaDerivacionInterna_Prestadores");
        });

        modelBuilder.Entity<GuardiaRegistro>(entity =>
        {
            entity.HasIndex(e => new { e.PacienteId, e.FechaIngreso }, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.FechaEgreso, e.Anulado }, "IX_GuardiaRegistro_FechaEgreso_Anulado");

            entity.HasIndex(e => new { e.Anulado, e.FechaIngreso }, "Ix_GuardiaRegistro_Anulado_FechaIngreso");

            entity.HasIndex(e => new { e.FechaEgreso, e.Anulado, e.GuardiaSectorId, e.SectorAnterior, e.PrestadorIngresoId, e.GuardiaRegistroId, e.PacienteId }, "_dta_index_GuardiaRegistro_6_1296827782__K10_K16_K3_K24_K7_K1_K2_4_9");

            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.AltaObservacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaEgreso).HasColumnType("datetime");
            entity.Property(e => e.FechaForza).HasColumnName("Fecha_Forza");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.GuardiaTipoIngresoId).HasColumnName("GuardiaTipoIngresoID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Llamado).HasColumnType("datetime");
            entity.Property(e => e.Orden)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorEgresoId).HasColumnName("PrestadorEgresoID");
            entity.Property(e => e.PrestadorIngresoId).HasColumnName("PrestadorIngresoID");
            entity.Property(e => e.TipoAltaId).HasColumnName("TipoAltaID");
            entity.Property(e => e.TipoCuracionId).HasColumnName("TipoCuracionID");
            entity.Property(e => e.TipoIngresoId).HasColumnName("TipoIngresoID");
            entity.Property(e => e.UsuarioEgreso)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioForza)
                .HasMaxLength(100)
                .HasColumnName("Usuario_Forza");
            entity.Property(e => e.UsuarioIngreso)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.GuardiaSector).WithMany(p => p.GuardiaRegistro)
                .HasForeignKey(d => d.GuardiaSectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaRegistro_GuardiaSector");

            entity.HasOne(d => d.GuardiaTipoIngreso).WithMany(p => p.GuardiaRegistro)
                .HasForeignKey(d => d.GuardiaTipoIngresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaRegistro_GuardiaTipoIngreso");

            entity.HasOne(d => d.Paciente).WithMany(p => p.GuardiaRegistro)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaRegistro_Pacientes");

            entity.HasOne(d => d.PrestadorEgreso).WithMany(p => p.GuardiaRegistroPrestadorEgreso)
                .HasForeignKey(d => d.PrestadorEgresoId)
                .HasConstraintName("FK_GuardiaRegistro_Prestadores1");

            entity.HasOne(d => d.PrestadorIngreso).WithMany(p => p.GuardiaRegistroPrestadorIngreso)
                .HasForeignKey(d => d.PrestadorIngresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaRegistro_Prestadores");

            entity.HasOne(d => d.TipoAlta).WithMany(p => p.GuardiaRegistro)
                .HasForeignKey(d => d.TipoAltaId)
                .HasConstraintName("FK_GuardiaRegistro_Tipo_AltaIntenado");

            entity.HasOne(d => d.TipoCuracion).WithMany(p => p.GuardiaRegistro)
                .HasForeignKey(d => d.TipoCuracionId)
                .HasConstraintName("FK_GuardiaRegistro_TipoCuracion");
        });

        modelBuilder.Entity<GuardiaSector>(entity =>
        {
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.AdmisionGral).HasDefaultValue(false);
            entity.Property(e => e.Anamnesis).HasDefaultValue(false);
            entity.Property(e => e.Balance).HasDefaultValue(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Consentimientos).HasDefaultValue(false);
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.GuardiaSectorIdoriginal).HasColumnName("GuardiaSectorIDOriginal");
            entity.Property(e => e.Imagenes).HasDefaultValue(false);
            entity.Property(e => e.InformeCci)
                .HasDefaultValue(false)
                .HasColumnName("InformeCCI");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NotificacionesCovid).HasDefaultValue(false);
            entity.Property(e => e.SalidaDirecta).HasDefaultValue(false);
            entity.Property(e => e.SexoId).HasColumnName("SexoID");
            entity.Property(e => e.TvMonitorId).HasColumnName("TvMonitorID");
        });

        modelBuilder.Entity<GuardiaSectoresDestino>(entity =>
        {
            entity.Property(e => e.GuardiaSectoresDestinoId).HasColumnName("GuardiaSectoresDestinoID");
            entity.Property(e => e.GuardiaSectorIddestino).HasColumnName("GuardiaSectorIDDestino");
            entity.Property(e => e.GuardiaSectorIdorigen).HasColumnName("GuardiaSectorIDOrigen");

            entity.HasOne(d => d.GuardiaSectorIddestinoNavigation).WithMany(p => p.GuardiaSectoresDestinoGuardiaSectorIddestinoNavigation)
                .HasForeignKey(d => d.GuardiaSectorIddestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaSectoresDestino_GuardiaSector1");

            entity.HasOne(d => d.GuardiaSectorIdorigenNavigation).WithMany(p => p.GuardiaSectoresDestinoGuardiaSectorIdorigenNavigation)
                .HasForeignKey(d => d.GuardiaSectorIdorigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaSectoresDestino_GuardiaSector");
        });

        modelBuilder.Entity<GuardiaTipoCuestionario>(entity =>
        {
            entity.Property(e => e.GuardiaTipoCuestionarioId).HasColumnName("GuardiaTipoCuestionarioID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GuardiaTipoCuestionarioLista>(entity =>
        {
            entity.Property(e => e.GuardiaTipoCuestionarioListaId).HasColumnName("GuardiaTipoCuestionarioListaID");
            entity.Property(e => e.GuardiaTipoCuestionarioPreguntaId).HasColumnName("GuardiaTipoCuestionarioPreguntaID");
            entity.Property(e => e.TextoRespuesta)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.GuardiaTipoCuestionarioPregunta).WithMany(p => p.GuardiaTipoCuestionarioLista)
                .HasForeignKey(d => d.GuardiaTipoCuestionarioPreguntaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaTipoCuestionarioLista_GuardiaTipoCuestionarioPregunta");
        });

        modelBuilder.Entity<GuardiaTipoCuestionarioPregunta>(entity =>
        {
            entity.Property(e => e.GuardiaTipoCuestionarioPreguntaId).HasColumnName("GuardiaTipoCuestionarioPreguntaID");
            entity.Property(e => e.CuestionarioTipoRespuestaId).HasColumnName("CuestionarioTipoRespuestaID");
            entity.Property(e => e.GuardiaTipoCuestionarioId).HasColumnName("GuardiaTipoCuestionarioID");
            entity.Property(e => e.Pregunta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValorMaximo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorMinimo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.GuardiaTipoCuestionario).WithMany(p => p.GuardiaTipoCuestionarioPregunta)
                .HasForeignKey(d => d.GuardiaTipoCuestionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaTipoCuestionarioPregunta_GuardiaTipoCuestionario");
        });

        modelBuilder.Entity<GuardiaTipoCuestionarioResultado>(entity =>
        {
            entity.Property(e => e.GuardiaTipoCuestionarioResultadoId).HasColumnName("GuardiaTipoCuestionarioResultadoID");
            entity.Property(e => e.GuardiaAnamnesisId).HasColumnName("GuardiaAnamnesisID");
            entity.Property(e => e.GuardiaTipoCuestionarioPreguntaId).HasColumnName("GuardiaTipoCuestionarioPreguntaID");
            entity.Property(e => e.Resultado)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.GuardiaTipoCuestionarioPregunta).WithMany(p => p.GuardiaTipoCuestionarioResultado)
                .HasForeignKey(d => d.GuardiaTipoCuestionarioPreguntaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaTipoCuestionarioResultado_GuardiaTipoCuestionarioPregunta");
        });

        modelBuilder.Entity<GuardiaTipoCuestionarioXsector>(entity =>
        {
            entity.ToTable("GuardiaTipoCuestionarioXSector");

            entity.Property(e => e.GuardiaTipoCuestionarioXsectorId).HasColumnName("GuardiaTipoCuestionarioXSectorID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.GuardiaTipoCuestionarioId).HasColumnName("GuardiaTipoCuestionarioID");

            entity.HasOne(d => d.GuardiaTipoCuestionario).WithMany(p => p.GuardiaTipoCuestionarioXsector)
                .HasForeignKey(d => d.GuardiaTipoCuestionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuardiaTipoCuestionarioXSector_GuardiaTipoCuestionario");
        });

        modelBuilder.Entity<GuardiaTipoIngreso>(entity =>
        {
            entity.Property(e => e.GuardiaTipoIngresoId).HasColumnName("GuardiaTipoIngresoID");
            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GyO>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Detalle)
                .HasMaxLength(150)
                .IsFixedLength();
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.GyOId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GyO_ID");
            entity.Property(e => e.Ioa).HasColumnName("IOA");
            entity.Property(e => e.Ioe).HasColumnName("IOE");
            entity.Property(e => e.Men)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Rm)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<HabitacionXhabitacionPase>(entity =>
        {
            entity.HasKey(e => e.IdHabitacionXhabitacionPase).HasName("PK_HabitacioXHabitacioPase");

            entity.ToTable("HabitacionXHabitacionPase");

            entity.Property(e => e.IdHabitacionXhabitacionPase).HasColumnName("IdHabitacionXHabitacionPase");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdHabitacionDerivaNavigation).WithMany(p => p.HabitacionXhabitacionPase)
                .HasForeignKey(d => d.IdHabitacionDeriva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HabitacionXHabitacionPase_Habitaciones_Hospital");
        });

        modelBuilder.Entity<HabitacionesHospital>(entity =>
        {
            entity.HasKey(e => e.HabitacionId);

            entity.ToTable("Habitaciones_Hospital", tb =>
                {
                    tb.HasTrigger("Tr_EdicionSector/HabitacionHCWeb");
                    tb.HasTrigger("Tr_RegistroSector/HabitacionHCWeb");
                });

            entity.HasIndex(e => e.HabitacionId, "_dta_index_Habitaciones_Hospital_6_1964638142__K1_2");

            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.ColorSala)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HabitacionIdhc).HasColumnName("HabitacionIDHC");
            entity.Property(e => e.InicioServicio)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.SectorId).HasColumnName("SectorID");
            entity.Property(e => e.SectorIdhc).HasColumnName("SectorIDHC");
            entity.Property(e => e.SectorIosepId).HasColumnName("SectorIosepID");
            entity.Property(e => e.TipoInternacionId).HasColumnName("TipoInternacionID");

            entity.HasOne(d => d.Piso).WithMany(p => p.HabitacionesHospital)
                .HasForeignKey(d => d.PisoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Habitaciones_Hospital_Pisos_hospital");

            entity.HasOne(d => d.Sector).WithMany(p => p.HabitacionesHospital)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Habitaciones_Hospital_Sectores_Hospital");
        });

        modelBuilder.Entity<HabitacionesHospitalXusuario>(entity =>
        {
            entity.ToTable("HabitacionesHospitalXUsuario", tb =>
                {
                    tb.HasTrigger("Tr_ActualizarSectorUsuarioHCWeb");
                    tb.HasTrigger("Tr_RegistrarSectorUsuarioHCWeb");
                });

            entity.HasIndex(e => new { e.UserId, e.Anulado }, "<Name of Missing Index, sysname,>");

            entity.Property(e => e.HabitacionesHospitalXusuarioId).HasColumnName("HabitacionesHospitalXUsuarioID");
            entity.Property(e => e.FechaAnulado).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.IdHabitacionUsuarioHcweb).HasColumnName("IdHabitacionUsuarioHCWEB");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UsuarioAnulado)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Hcsnomed>(entity =>
        {
            entity.HasKey(e => e.IdTerminoSnomed);

            entity.ToTable("HCSnomed");

            entity.Property(e => e.IdTerminoSnomed).HasColumnName("idTerminoSnomed");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.IdConceptSnomed).HasColumnName("idConceptSnomed");
            entity.Property(e => e.IdConsulta).HasColumnName("idConsulta");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");

            entity.HasOne(d => d.IdConsultaNavigation).WithMany(p => p.Hcsnomed)
                .HasForeignKey(d => d.IdConsulta)
                .HasConstraintName("FK_HCSnomed_HCSnomedConcept");
        });

        modelBuilder.Entity<HcsnomedConcept>(entity =>
        {
            entity.HasKey(e => e.IdConceptSnomed);

            entity.ToTable("HCSnomedConcept");

            entity.Property(e => e.IdConceptSnomed).HasColumnName("idConceptSnomed");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.ConceptId)
                .HasMaxLength(50)
                .HasColumnName("conceptId");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.Term)
                .HasMaxLength(300)
                .HasColumnName("term");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");
        });

        modelBuilder.Entity<HistorialCama>(entity =>
        {
            entity.Property(e => e.HistorialCamaId).HasColumnName("HistorialCamaID");
            entity.Property(e => e.CamaId).HasColumnName("CamaID");
            entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.MovimientoInternadoId).HasColumnName("MovimientoInternadoID");
        });

        modelBuilder.Entity<HistorialDiagDetalle>(entity =>
        {
            entity.Property(e => e.HistorialDiagDetalleId).HasColumnName("HistorialDiagDetalleID");
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaRetirado).HasColumnType("datetime");
            entity.Property(e => e.HistorialDiagInternacionId).HasColumnName("HistorialDiagInternacionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<HistorialDiagnosticosInternacion>(entity =>
        {
            entity.HasKey(e => e.HistorialDiagInternacionId);

            entity.Property(e => e.HistorialDiagInternacionId).HasColumnName("HistorialDiagInternacionID");
            entity.Property(e => e.DetalleDiag)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DiagId).HasColumnName("DiagID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<HistorialEmpleadoHospital>(entity =>
        {
            entity.HasKey(e => e.HistorialEmpleadoId);

            entity.ToTable("HistorialEmpleado_Hospital");

            entity.Property(e => e.HistorialEmpleadoId).HasColumnName("HistorialEmpleadoID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cuil)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("CUIL");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpleadoTipoContratoId).HasColumnName("EmpleadoTipoContratoID");
            entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaEgreso).HasColumnName("Fecha_Egreso");
            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.FotoRuta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Funcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MinisterioPertenece)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreConyuge)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Conyuge");
            entity.Property(e => e.NroAdmision)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NroControl)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NroLegajo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NroMatriculaProfesional)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PersIdenReloj).HasColumnName("PersIDEnReloj");
            entity.Property(e => e.SectorPlanificacionId).HasColumnName("SectorPlanificacionID");
            entity.Property(e => e.TelefonoCelular)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Telefono_Celular");
            entity.Property(e => e.TelefonoConyuge)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Telefono_Conyuge");
            entity.Property(e => e.TelefonoFijo)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("Telefono_Fijo");
            entity.Property(e => e.TipoAdmisionHospitalId).HasColumnName("TipoAdmisionHospitalID");
            entity.Property(e => e.TipoEmpleadoId).HasColumnName("TipoEmpleadoID");
            entity.Property(e => e.TipoInstruccionId).HasColumnName("TipoInstruccionID");
            entity.Property(e => e.Titulo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioBaja)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<HistorialdeActualizacionInternaciones>(entity =>
        {
            entity.HasKey(e => e.HistorialdeActualizacionInternacion);

            entity.Property(e => e.Detalle)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.RegistroId).HasColumnName("RegistroID");
            entity.Property(e => e.Tabla).HasMaxLength(100);
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Hl7MensajesEnviados>(entity =>
        {
            entity.HasKey(e => e.Hl7MensajeId).HasName("PK__HL7_Mens__A1BA02C9EB527E77");

            entity.ToTable("HL7_MensajesEnviados");

            entity.Property(e => e.Hl7MensajeId).HasColumnName("HL7_MensajeID");
            entity.Property(e => e.ContenidoHl7)
                .HasColumnType("text")
                .HasColumnName("ContenidoHL7");
            entity.Property(e => e.ControlIdMensaje)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaEnvio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TipoMensaje)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hl7MensajesRecibidos>(entity =>
        {
            entity.HasKey(e => e.MensajeId).HasName("PK__HL7_Mens__FEA0557F030AE649");

            entity.ToTable("HL7_MensajesRecibidos");

            entity.Property(e => e.MensajeId).HasColumnName("MensajeID");
            entity.Property(e => e.ContenidoHl7)
                .HasColumnType("text")
                .HasColumnName("ContenidoHL7");
            entity.Property(e => e.ControlIdMensaje).HasMaxLength(50);
            entity.Property(e => e.FechaRecepcion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TipoMensaje).HasMaxLength(20);
        });

        modelBuilder.Entity<Hospital>(entity =>
        {
            entity.Property(e => e.HospitalId).HasColumnName("HospitalID");
            entity.Property(e => e.Jurisdiccion)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Programa)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ProgramaDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HospitalActividad>(entity =>
        {
            entity.Property(e => e.HospitalActividadId).HasColumnName("HospitalActividadID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.HospitalId).HasColumnName("HospitalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Hospital).WithMany(p => p.HospitalActividad)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HospitalActividad_Hospital");
        });

        modelBuilder.Entity<HospitalPartida>(entity =>
        {
            entity.HasKey(e => e.HospitalPartidaId).HasName("PK_HosptalPartida");

            entity.Property(e => e.HospitalPartidaId).HasColumnName("HospitalPartidaID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.HospitalActividadId).HasColumnName("HospitalActividadID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.HospitalActividad).WithMany(p => p.HospitalPartida)
                .HasForeignKey(d => d.HospitalActividadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HosptalPartida_HospitalActividad");
        });

        modelBuilder.Entity<HospitalProyecto>(entity =>
        {
            entity.Property(e => e.HospitalProyectoId).HasColumnName("HospitalProyectoID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HospitalId).HasColumnName("HospitalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProyectoEstadoId).HasColumnName("ProyectoEstadoID");

            entity.HasOne(d => d.Hospital).WithMany(p => p.HospitalProyecto)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HospitalProyecto_Hospital");

            entity.HasOne(d => d.ProyectoEstado).WithMany(p => p.HospitalProyecto)
                .HasForeignKey(d => d.ProyectoEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HospitalProyecto_ProyectoEstado");
        });

        modelBuilder.Entity<HospitalSubPrograma>(entity =>
        {
            entity.Property(e => e.HospitalSubProgramaId).HasColumnName("HospitalSubProgramaID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HospitalId).HasColumnName("HospitalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Hospital).WithMany(p => p.HospitalSubPrograma)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HospitalSubPrograma_Hospital");
        });

        modelBuilder.Entity<Hospitalizacion>(entity =>
        {
            entity.HasKey(e => e.IdHospitalizacion);

            entity.Property(e => e.IdHospitalizacion).HasColumnName("idHospitalizacion");
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .HasColumnName("barrio");
            entity.Property(e => e.Calle)
                .HasMaxLength(200)
                .HasColumnName("calle");
            entity.Property(e => e.CantDias).HasColumnName("cantDias");
            entity.Property(e => e.DescOtrasCircuns)
                .HasMaxLength(300)
                .HasColumnName("descOtrasCircuns");
            entity.Property(e => e.DescProcedimiento)
                .HasMaxLength(300)
                .HasColumnName("descProcedimiento");
            entity.Property(e => e.DiagCie10)
                .HasMaxLength(10)
                .HasColumnName("diagCie10");
            entity.Property(e => e.DiagOtroCie10)
                .HasMaxLength(10)
                .HasColumnName("diagOtroCie10");
            entity.Property(e => e.DiasOtrasCircuns).HasColumnName("diasOtrasCircuns");
            entity.Property(e => e.DocumentoMama)
                .HasMaxLength(50)
                .HasColumnName("documentoMama");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaEgreso).HasColumnName("fechaEgreso");
            entity.Property(e => e.FechaIngreso).HasColumnName("fechaIngreso");
            entity.Property(e => e.FechaModificaAlta).HasColumnType("datetime");
            entity.Property(e => e.IdDepto).HasColumnName("idDepto");
            entity.Property(e => e.IdInternado).HasColumnName("idInternado");
            entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");
            entity.Property(e => e.IdMetodoAnticon)
                .HasMaxLength(20)
                .HasColumnName("idMetodoAnticon");
            entity.Property(e => e.IdNivelInstruccion).HasColumnName("idNivelInstruccion");
            entity.Property(e => e.IdPais).HasColumnName("idPais");
            entity.Property(e => e.IdPrestadorAlta).HasColumnName("idPrestadorAlta");
            entity.Property(e => e.IdProcedencia).HasColumnName("idProcedencia");
            entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");
            entity.Property(e => e.IdSectorIngreso).HasColumnName("idSectorIngreso");
            entity.Property(e => e.IdSexo).HasColumnName("idSexo");
            entity.Property(e => e.IdSistemaSalud).HasColumnName("idSistemaSalud");
            entity.Property(e => e.IdSituacionLaboral).HasColumnName("idSituacionLaboral");
            entity.Property(e => e.IdTipoDocMama).HasColumnName("idTipoDocMama");
            entity.Property(e => e.IdTipoEgreso).HasColumnName("idTipoEgreso");
            entity.Property(e => e.LugarOtrasCircuns)
                .HasMaxLength(20)
                .HasColumnName("lugarOtrasCircuns");
            entity.Property(e => e.MotivoOtrasCircuns)
                .HasMaxLength(20)
                .HasColumnName("motivoOtrasCircuns");
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(300)
                .HasColumnName("ocupacion");
            entity.Property(e => e.OtrasCircunstancias)
                .HasMaxLength(300)
                .HasColumnName("otrasCircunstancias");
            entity.Property(e => e.Procedimiento).HasColumnName("procedimiento");
            entity.Property(e => e.TotalDias).HasColumnName("totalDias");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModificaAlta)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<HospitalizacionObstetrica>(entity =>
        {
            entity.HasKey(e => e.IdHospitalizacionObst);

            entity.ToTable("Hospitalizacion_Obstetrica");

            entity.Property(e => e.IdHospitalizacionObst).HasColumnName("idHospitalizacionObst");
            entity.Property(e => e.EdadGestacional).HasColumnName("edadGestacional");
            entity.Property(e => e.FechaTermEmbarazo).HasColumnName("fechaTermEmbarazo");
            entity.Property(e => e.IdHospitalizacion).HasColumnName("idHospitalizacion");
            entity.Property(e => e.MalformCongenita)
                .HasMaxLength(300)
                .HasColumnName("malformCongenita");
            entity.Property(e => e.MalformGeneticaSinDet)
                .HasMaxLength(300)
                .HasColumnName("malformGeneticaSinDet");
            entity.Property(e => e.MalformGeneticaSinIndet)
                .HasMaxLength(300)
                .HasColumnName("malformGeneticaSinIndet");
            entity.Property(e => e.Paridad).HasColumnName("paridad");
            entity.Property(e => e.TipoParto).HasColumnName("tipoParto");

            entity.HasOne(d => d.IdHospitalizacionNavigation).WithMany(p => p.HospitalizacionObstetrica)
                .HasForeignKey(d => d.IdHospitalizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hospitalizacion_Obstetrica_Hospitalizacion");
        });

        modelBuilder.Entity<HospitalizacionObstetricaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdHospitalizacionObstDet);

            entity.ToTable("Hospitalizacion_ObstetricaDetalle");

            entity.Property(e => e.IdHospitalizacionObstDet).HasColumnName("idHospitalizacionObstDet");
            entity.Property(e => e.CondicionAlNacer).HasColumnName("condicionAlNacer");
            entity.Property(e => e.IdHospitalizacionObst).HasColumnName("idHospitalizacionObst");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("peso");
            entity.Property(e => e.Sexo).HasColumnName("sexo");
            entity.Property(e => e.Terminacion).HasColumnName("terminacion");

            entity.HasOne(d => d.IdHospitalizacionObstNavigation).WithMany(p => p.HospitalizacionObstetricaDetalle)
                .HasForeignKey(d => d.IdHospitalizacionObst)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hospitalizacion_ObstetricaDetalle_Hospitalizacion_Obstetrica");
        });

        modelBuilder.Entity<HospitalizacionPases>(entity =>
        {
            entity.HasKey(e => e.IdHospitalizacionPases);

            entity.Property(e => e.IdHospitalizacionPases).HasColumnName("idHospitalizacionPases");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.CantidadDias).HasColumnName("cantidadDias");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdHospitalizacion).HasColumnName("idHospitalizacion");
            entity.Property(e => e.IdPase).HasColumnName("idPase");
            entity.Property(e => e.IdSector).HasColumnName("idSector");

            entity.HasOne(d => d.IdHospitalizacionNavigation).WithMany(p => p.HospitalizacionPases)
                .HasForeignKey(d => d.IdHospitalizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HospitalizacionPases_Hospitalizacion");
        });

        modelBuilder.Entity<HuellasDigitales>(entity =>
        {
            entity.HasKey(e => e.IdhuellaDigital);

            entity.Property(e => e.IdhuellaDigital).HasColumnName("IDHuellaDigital");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
        });

        modelBuilder.Entity<Iconos>(entity =>
        {
            entity.HasKey(e => e.IconoId);

            entity.Property(e => e.IconoId).HasColumnName("IconoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImagenPedido>(entity =>
        {
            entity.HasIndex(e => new { e.InformeObligatorio, e.Anulado, e.ImagenRegistroId }, "_dta_index_ImagenPedido_6_304108224__K13_K3_K4_1");

            entity.HasIndex(e => new { e.ImagenRegistroId, e.Anulado, e.InformeObligatorio }, "_dta_index_ImagenPedido_6_304108224__K4_K3_K13");

            entity.Property(e => e.ImagenPedidoId).HasColumnName("ImagenPedidoID");
            entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaMarcaRealiza).HasColumnType("datetime");
            entity.Property(e => e.ImagenPracticaId).HasColumnName("ImagenPracticaID");
            entity.Property(e => e.ImagenRegistroId).HasColumnName("ImagenRegistroID");
            entity.Property(e => e.InformeObligatorio).HasDefaultValue(false);
            entity.Property(e => e.OpAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpCarga).HasMaxLength(11);
            entity.Property(e => e.PracticasEstadoId).HasColumnName("PracticasEstadoID");
            entity.Property(e => e.UsuarioMarcaRealiza)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.ImagenPractica).WithMany(p => p.ImagenPedido)
                .HasForeignKey(d => d.ImagenPracticaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenPedido_ImagenPractica");

            entity.HasOne(d => d.ImagenRegistro).WithMany(p => p.ImagenPedido)
                .HasForeignKey(d => d.ImagenRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenPedido_ImagenRegistro");
        });

        modelBuilder.Entity<ImagenPedidoEstado>(entity =>
        {
            entity.HasIndex(e => e.Anulado, "_dta_index_ImagenPedidoEstado_6_1411588167__K5_2");

            entity.Property(e => e.ImagenPedidoEstadoId).HasColumnName("ImagenPedidoEstadoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaMarcaRealizado).HasColumnType("datetime");
            entity.Property(e => e.ImagenPedidoId).HasColumnName("ImagenPedidoID");
            entity.Property(e => e.TecnicoId).HasColumnName("TecnicoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMarcaRealizado)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<ImagenPractica>(entity =>
        {
            entity.Property(e => e.ImagenPracticaId).HasColumnName("ImagenPracticaID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImagenTipoPracticaId).HasColumnName("ImagenTipoPracticaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ImagenTipoPractica).WithMany(p => p.ImagenPractica)
                .HasForeignKey(d => d.ImagenTipoPracticaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenPractica_ImagenTipoPractica");
        });

        modelBuilder.Entity<ImagenRegistro>(entity =>
        {
            entity.HasIndex(e => new { e.InterconsultaId, e.PacienteId, e.ImagenRegistroId }, "_dta_index_ImagenRegistro_6_1790017508__K16_K7_K1_10_21");

            entity.Property(e => e.ImagenRegistroId).HasColumnName("ImagenRegistroID");
            entity.Property(e => e.DetalleSolicitud).HasDefaultValue("");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.GuardiaId).HasColumnName("GuardiaID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InterconsultaId).HasColumnName("InterconsultaID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MotivoAnulado).HasMaxLength(300);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PracticasEstadoId).HasColumnName("PracticasEstadoID");
            entity.Property(e => e.PracticasOrigenId).HasColumnName("PracticasOrigenID");
            entity.Property(e => e.SectorId).HasColumnName("SectorID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Internacion).WithMany(p => p.ImagenRegistro)
                .HasForeignKey(d => d.InternacionId)
                .HasConstraintName("FK_ImagenRegistro_Internaciones");

            entity.HasOne(d => d.Paciente).WithMany(p => p.ImagenRegistro)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenRegistro_Pacientes");

            entity.HasOne(d => d.PracticasOrigen).WithMany(p => p.ImagenRegistro)
                .HasForeignKey(d => d.PracticasOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenRegistro_PracticasOrigen");

            entity.HasOne(d => d.PrestadorRealizaNavigation).WithMany(p => p.ImagenRegistroPrestadorRealizaNavigation)
                .HasForeignKey(d => d.PrestadorRealiza)
                .HasConstraintName("FK_ImagenRegistro_Prestadores1");

            entity.HasOne(d => d.PrestadorSolicitaNavigation).WithMany(p => p.ImagenRegistroPrestadorSolicitaNavigation)
                .HasForeignKey(d => d.PrestadorSolicita)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenRegistro_Prestadores");

            entity.HasOne(d => d.Turno).WithMany(p => p.ImagenRegistro)
                .HasForeignKey(d => d.TurnoId)
                .HasConstraintName("FK_ImagenRegistro_Turnos");
        });

        modelBuilder.Entity<ImagenRegistroXestado>(entity =>
        {
            entity.ToTable("ImagenRegistroXEstado");

            entity.Property(e => e.ImagenRegistroXestadoId).HasColumnName("ImagenRegistroXEstadoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.ImagenRegistroId).HasColumnName("ImagenRegistroID");
            entity.Property(e => e.PracticasEstadoId).HasColumnName("PracticasEstadoID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.ImagenRegistro).WithMany(p => p.ImagenRegistroXestado)
                .HasForeignKey(d => d.ImagenRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenRegistroXEstado_ImagenRegistro");
        });

        modelBuilder.Entity<ImagenResultado>(entity =>
        {
            entity.Property(e => e.ImagenResultadoId).HasColumnName("ImagenResultadoID");
            entity.Property(e => e.ActividadCardiaca).HasMaxLength(200);
            entity.Property(e => e.Anulado).HasDefaultValue(false);
            entity.Property(e => e.AortaDescendente).HasMaxLength(200);
            entity.Property(e => e.ArteriaAorta).HasMaxLength(100);
            entity.Property(e => e.ArteriaPulmonar).HasMaxLength(100);
            entity.Property(e => e.AuriculaDerecha).HasMaxLength(100);
            entity.Property(e => e.AuriculaIzquierda).HasMaxLength(100);
            entity.Property(e => e.Biometria).HasMaxLength(300);
            entity.Property(e => e.CabezaFemoral).HasMaxLength(200);
            entity.Property(e => e.CantLiquidoAmniotico).HasMaxLength(100);
            entity.Property(e => e.CavidadAbdominal).HasMaxLength(300);
            entity.Property(e => e.CavidadEndometrial).HasMaxLength(300);
            entity.Property(e => e.Ccef)
                .HasMaxLength(100)
                .HasColumnName("CCEF");
            entity.Property(e => e.ConcordanciaAv).HasColumnName("ConcordanciaAV");
            entity.Property(e => e.ConcordanciaVa).HasColumnName("ConcordanciaVA");
            entity.Property(e => e.Corazon).HasMaxLength(200);
            entity.Property(e => e.CuelloUterino).HasMaxLength(300);
            entity.Property(e => e.DetallesUtero).HasMaxLength(300);
            entity.Property(e => e.Ductus).HasMaxLength(200);
            entity.Property(e => e.EdadEcografica).HasMaxLength(300);
            entity.Property(e => e.EdadGestacional).HasMaxLength(200);
            entity.Property(e => e.EdadMensual).HasMaxLength(300);
            entity.Property(e => e.Epidimio).HasMaxLength(200);
            entity.Property(e => e.EspaciosExtracerebrales).HasMaxLength(300);
            entity.Property(e => e.Feto).HasMaxLength(500);
            entity.Property(e => e.Fum)
                .HasMaxLength(100)
                .HasColumnName("FUM");
            entity.Property(e => e.Grado).HasMaxLength(100);
            entity.Property(e => e.Ilcf)
                .HasMaxLength(100)
                .HasColumnName("ILCF");
            entity.Property(e => e.ImagenPedidoId).HasColumnName("ImagenPedidoID");
            entity.Property(e => e.ImagenPracticaId).HasColumnName("ImagenPracticaID");
            entity.Property(e => e.Inestabilidad).HasMaxLength(200);
            entity.Property(e => e.Internos).HasMaxLength(200);
            entity.Property(e => e.Iracmed)
                .HasMaxLength(100)
                .HasColumnName("IRACMED");
            entity.Property(e => e.Iraumb)
                .HasMaxLength(100)
                .HasColumnName("IRAUMB");
            entity.Property(e => e.LongCefalo).HasMaxLength(100);
            entity.Property(e => e.Metrias).HasMaxLength(100);
            entity.Property(e => e.MovimientoActivos).HasMaxLength(200);
            entity.Property(e => e.MovimientosRespiratorios).HasMaxLength(200);
            entity.Property(e => e.NucleosOsificacion).HasMaxLength(200);
            entity.Property(e => e.Parenquima).HasMaxLength(300);
            entity.Property(e => e.Pericardio).HasMaxLength(200);
            entity.Property(e => e.Peso).HasMaxLength(300);
            entity.Property(e => e.Placenta).HasMaxLength(300);
            entity.Property(e => e.Postmiccional).HasMaxLength(300);
            entity.Property(e => e.Prostata).HasMaxLength(300);
            entity.Property(e => e.SeptumInterventricular).HasMaxLength(200);
            entity.Property(e => e.SeptumIntrauricular).HasMaxLength(100);
            entity.Property(e => e.SistemaExcrecion).HasMaxLength(300);
            entity.Property(e => e.SistemaVentricular).HasMaxLength(300);
            entity.Property(e => e.SitusAuricular).HasMaxLength(100);
            entity.Property(e => e.TechoCartilaginosos).HasMaxLength(200);
            entity.Property(e => e.TechoOseo).HasMaxLength(200);
            entity.Property(e => e.Torax).HasMaxLength(200);
            entity.Property(e => e.ValvulaMitral).HasMaxLength(100);
            entity.Property(e => e.ValvulaTricuspide).HasMaxLength(100);
            entity.Property(e => e.Vascularizacion).HasMaxLength(300);
            entity.Property(e => e.Vejiga).HasMaxLength(300);
            entity.Property(e => e.VentriculoDerecho).HasMaxLength(100);
            entity.Property(e => e.VentriculoIzquierdo).HasMaxLength(100);
            entity.Property(e => e.ViaBiliar).HasMaxLength(300);
            entity.Property(e => e.Vitalidad).HasMaxLength(100);

            entity.HasOne(d => d.ImagenPedido).WithMany(p => p.ImagenResultado)
                .HasForeignKey(d => d.ImagenPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenResultado_ImagenPedido");
        });

        modelBuilder.Entity<ImagenResultadoDetalle>(entity =>
        {
            entity.Property(e => e.ImagenResultadoDetalleId).HasColumnName("ImagenResultadoDetalleID");
            entity.Property(e => e.Anulado).HasDefaultValue(false);
            entity.Property(e => e.Bordes).HasMaxLength(300);
            entity.Property(e => e.ImagenResultadoId).HasColumnName("ImagenResultadoID");
            entity.Property(e => e.ImagenTipoOrganoId).HasColumnName("ImagenTipoOrganoID");
            entity.Property(e => e.Observacion).HasMaxLength(300);
            entity.Property(e => e.Paredes).HasMaxLength(300);
            entity.Property(e => e.Parenquima).HasMaxLength(300);
            entity.Property(e => e.Tamaño)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.ImagenResultado).WithMany(p => p.ImagenResultadoDetalle)
                .HasForeignKey(d => d.ImagenResultadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenResultadoDetalle_ImagenResultado");
        });

        modelBuilder.Entity<ImagenTipoOrgano>(entity =>
        {
            entity.HasKey(e => e.ImagenTipoOrganoId).HasName("PK_ImagenTipoOrgano_1");

            entity.Property(e => e.ImagenTipoOrganoId).HasColumnName("ImagenTipoOrganoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<ImagenTipoPractica>(entity =>
        {
            entity.Property(e => e.ImagenTipoPracticaId).HasColumnName("ImagenTipoPracticaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImagenesXservicio>(entity =>
        {
            entity.HasKey(e => new { e.ImagenPracticaId, e.ServicioId }).HasName("PK__Imagenes__C394E599CC2E9F27");

            entity.ToTable("ImagenesXServicio");

            entity.Property(e => e.ImagenPracticaId).HasColumnName("ImagenPracticaID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.Anulado).HasDefaultValue(false);
        });

        modelBuilder.Entity<IndicacionesDieta>(entity =>
        {
            entity.ToTable("Indicaciones_Dieta");

            entity.Property(e => e.IndicacionesDietaId).HasColumnName("Indicaciones_DietaID");
            entity.Property(e => e.FechaIndica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoDietaId).HasColumnName("TipoDietaID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.IndicacionesDieta)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Dieta_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.IndicacionesDieta)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Dieta_Prestadores");

            entity.HasOne(d => d.TipoDieta).WithMany(p => p.IndicacionesDieta)
                .HasForeignKey(d => d.TipoDietaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Dieta_TipoDieta");
        });

        modelBuilder.Entity<IndicacionesKinesiologia>(entity =>
        {
            entity.ToTable("Indicaciones_Kinesiologia");

            entity.Property(e => e.IndicacionesKinesiologiaId).HasColumnName("Indicaciones_KinesiologiaID");
            entity.Property(e => e.FechaIndica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoKinesiologiaId).HasColumnName("TipoKinesiologiaID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.IndicacionesKinesiologia)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Kinesiologia_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.IndicacionesKinesiologia)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Kinesiologia_Prestadores");

            entity.HasOne(d => d.TipoKinesiologia).WithMany(p => p.IndicacionesKinesiologia)
                .HasForeignKey(d => d.TipoKinesiologiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Kinesiologia_TipoKinesiologia");
        });

        modelBuilder.Entity<IndicacionesObservacionesGrales>(entity =>
        {
            entity.ToTable("Indicaciones_ObservacionesGrales");

            entity.Property(e => e.IndicacionesObservacionesGralesId).HasColumnName("Indicaciones_ObservacionesGralesID");
            entity.Property(e => e.FechaIndica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.IndicacionesObservacionesGrales)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_ObservacionesGrales_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.IndicacionesObservacionesGrales)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_ObservacionesGrales_Prestadores");
        });

        modelBuilder.Entity<IndicacionesPosicion>(entity =>
        {
            entity.ToTable("Indicaciones_Posicion");

            entity.Property(e => e.IndicacionesPosicionId).HasColumnName("Indicaciones_PosicionID");
            entity.Property(e => e.FechaIndica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoPosicionId).HasColumnName("TipoPosicionID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.IndicacionesPosicion)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Posicion_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.IndicacionesPosicion)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Posicion_Prestadores");

            entity.HasOne(d => d.TipoPosicion).WithMany(p => p.IndicacionesPosicion)
                .HasForeignKey(d => d.TipoPosicionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_Posicion_TipoPosicion");
        });

        modelBuilder.Entity<IndicacionesRegistroAplicacion>(entity =>
        {
            entity.ToTable("Indicaciones_RegistroAplicacion");

            entity.Property(e => e.IndicacionesRegistroAplicacionId).HasColumnName("Indicaciones_RegistroAplicacionID");
            entity.Property(e => e.FechaAplica).HasColumnType("datetime");
            entity.Property(e => e.IndicacionesDietaId).HasColumnName("Indicaciones_DietaID");
            entity.Property(e => e.IndicacionesKinesiologiaId).HasColumnName("Indicaciones_KinesiologiaID");
            entity.Property(e => e.IndicacionesPosicionId).HasColumnName("Indicaciones_PosicionID");
            entity.Property(e => e.IndicacionesVentilacionMecanicaId).HasColumnName("Indicaciones_VentilacionMecanicaID");
            entity.Property(e => e.MedicacionDiscretaId).HasColumnName("MedicacionDiscretaID");
            entity.Property(e => e.MedicacionInfusionContinuaId).HasColumnName("MedicacionInfusionContinuaID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IndicacionesDieta).WithMany(p => p.IndicacionesRegistroAplicacion)
                .HasForeignKey(d => d.IndicacionesDietaId)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_Indicaciones_Dieta");

            entity.HasOne(d => d.IndicacionesKinesiologia).WithMany(p => p.IndicacionesRegistroAplicacion)
                .HasForeignKey(d => d.IndicacionesKinesiologiaId)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_Indicaciones_Kinesiologia");

            entity.HasOne(d => d.IndicacionesPosicion).WithMany(p => p.IndicacionesRegistroAplicacion)
                .HasForeignKey(d => d.IndicacionesPosicionId)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_Indicaciones_Posicion");

            entity.HasOne(d => d.IndicacionesVentilacionMecanica).WithMany(p => p.IndicacionesRegistroAplicacion)
                .HasForeignKey(d => d.IndicacionesVentilacionMecanicaId)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_Indicaciones_VentilacionMecanica");

            entity.HasOne(d => d.MedicacionDiscreta).WithMany(p => p.IndicacionesRegistroAplicacion)
                .HasForeignKey(d => d.MedicacionDiscretaId)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_MedicacionDiscreta");

            entity.HasOne(d => d.MedicacionInfusionContinua).WithMany(p => p.IndicacionesRegistroAplicacion)
                .HasForeignKey(d => d.MedicacionInfusionContinuaId)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_MedicacionInfusionContinua");
        });

        modelBuilder.Entity<IndicacionesRegistroAplicacionDescartables>(entity =>
        {
            entity.ToTable("Indicaciones_RegistroAplicacion_Descartables");

            entity.Property(e => e.IndicacionesRegistroAplicacionDescartablesId).HasColumnName("Indicaciones_RegistroAplicacion_DescartablesID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.FarMedicamentoId).HasColumnName("Far_MedicamentoID");
            entity.Property(e => e.IdicacionesRegistroAplicacionId).HasColumnName("Idicaciones_RegistroAplicacionID");

            entity.HasOne(d => d.FarMedicamento).WithMany(p => p.IndicacionesRegistroAplicacionDescartables)
                .HasForeignKey(d => d.FarMedicamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_Descartables_Far_Medicamento");

            entity.HasOne(d => d.IdicacionesRegistroAplicacion).WithMany(p => p.IndicacionesRegistroAplicacionDescartables)
                .HasForeignKey(d => d.IdicacionesRegistroAplicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_RegistroAplicacion_Descartables_Indicaciones_RegistroAplicacion");
        });

        modelBuilder.Entity<IndicacionesVentilacionMecanica>(entity =>
        {
            entity.ToTable("Indicaciones_VentilacionMecanica");

            entity.Property(e => e.IndicacionesVentilacionMecanicaId).HasColumnName("Indicaciones_VentilacionMecanicaID");
            entity.Property(e => e.FechaIndica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoVentilacionId).HasColumnName("TipoVentilacionID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.IndicacionesVentilacionMecanica)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_VentilacionMecanica_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.IndicacionesVentilacionMecanica)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_VentilacionMecanica_Prestadores");

            entity.HasOne(d => d.TipoVentilacion).WithMany(p => p.IndicacionesVentilacionMecanica)
                .HasForeignKey(d => d.TipoVentilacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicaciones_VentilacionMecanica_TipoVentilacion");
        });

        modelBuilder.Entity<InformeCci>(entity =>
        {
            entity.ToTable("InformeCCI");

            entity.Property(e => e.InformeCciid).HasColumnName("InformeCCIID");
            entity.Property(e => e.AnaemnesisReducidaId).HasColumnName("AnaemnesisReducidaID");
            entity.Property(e => e.Curb65).HasColumnName("CURB65");
            entity.Property(e => e.Dbt).HasColumnName("DBT");
            entity.Property(e => e.DerivaDe).HasMaxLength(50);
            entity.Property(e => e.Epoc).HasColumnName("EPOC");
            entity.Property(e => e.Erc).HasColumnName("ERC");
            entity.Property(e => e.Hisopado).HasMaxLength(50);
            entity.Property(e => e.Hta).HasColumnName("HTA");
            entity.Property(e => e.Imc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMC");
            entity.Property(e => e.InternacionDerivacion).HasMaxLength(50);
            entity.Property(e => e.News2).HasColumnName("NEWS2");
            entity.Property(e => e.NivelConciencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionNexoEpidem).HasMaxLength(300);
            entity.Property(e => e.ObservacionesDefinicionCaso).HasMaxLength(300);
            entity.Property(e => e.OtrasEnfermedades).HasMaxLength(300);
            entity.Property(e => e.OtrosSintomas).HasMaxLength(300);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoCaso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoContacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<InformeDigital>(entity =>
        {
            entity.HasKey(e => e.InformeDigitalId).HasName("PK_InformeDigital_1");

            entity.Property(e => e.InformeDigitalId).HasColumnName("InformeDigitalID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(200);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.TipoInformeDigitalId).HasColumnName("TipoInformeDigitalID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.TipoInformeDigital).WithMany(p => p.InformeDigital)
                .HasForeignKey(d => d.TipoInformeDigitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__InformeDi__TipoI__6EE2037B");
        });

        modelBuilder.Entity<InformeGeneral>(entity =>
        {
            entity.Property(e => e.InformeGeneralId).HasColumnName("InformeGeneralID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Idp).HasColumnName("IDP");
            entity.Property(e => e.ImagenPracticaId).HasColumnName("ImagenPracticaID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Titulo).HasMaxLength(200);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<InstitucionTipoAislamientos>(entity =>
        {
            entity.HasKey(e => e.InstitucionTiposAislamientosId);

            entity.Property(e => e.InstitucionTiposAislamientosId).HasColumnName("InstitucionTiposAislamientosID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.TipoAislamientoId).HasColumnName("TipoAislamientoID");
        });

        modelBuilder.Entity<Instituciones>(entity =>
        {
            entity.HasKey(e => e.InstitucionId).HasName("PK_Instittuciones");

            entity.ToTable(tb => tb.HasTrigger("Tr_InstitucionCreate"));

            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Abreviatura).HasMaxLength(50);
            entity.Property(e => e.Aplicacion).HasMaxLength(50);
            entity.Property(e => e.CodigoHospital).HasMaxLength(100);
            entity.Property(e => e.CodigoRefes).HasMaxLength(100);
            entity.Property(e => e.Cuit).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.DireccionCompleta).HasMaxLength(200);
            entity.Property(e => e.Hpgd).HasColumnName("HPGD");
            entity.Property(e => e.IdInstitucionHc).HasColumnName("IdInstitucionHC");
            entity.Property(e => e.InstitucionIdiosep).HasColumnName("InstitucionIDIosep");
            entity.Property(e => e.InstitucionIdlab).HasColumnName("InstitucionIDLab");
            entity.Property(e => e.InstitucionIdmed).HasColumnName("InstitucionIDMed");
            entity.Property(e => e.InstitucionIdmenu).HasColumnName("InstitucionIDMenu");
            entity.Property(e => e.Logo).HasMaxLength(200);
            entity.Property(e => e.LogoInforme).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.NombreInforme).HasMaxLength(200);
            entity.Property(e => e.RequiereControles).HasDefaultValue(false);
            entity.Property(e => e.Telefono).HasMaxLength(50);
            entity.Property(e => e.Terminos).HasDefaultValue(false);

            entity.HasOne(d => d.IdTipoConsumirBonoNavigation).WithMany(p => p.Instituciones)
                .HasForeignKey(d => d.IdTipoConsumirBono)
                .HasConstraintName("FK_Instituciones_TipoConsumirBono");
        });

        modelBuilder.Entity<Interconsulta>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Tr_GrabarInterconsultaHCWEB"));

            entity.HasIndex(e => new { e.InstitucionId, e.ServicioId, e.FechaRealiza, e.Anulado, e.InterconsultaId, e.NoAtendido, e.FechaPedido, e.GuardiaSectorId, e.GuardiaRegistroId }, "_dta_index_Interconsulta_6_722869692__K15_K16_K8_K10_K1_K11_K7_K4_K3_6_17_18");

            entity.HasIndex(e => new { e.InstitucionId, e.ServicioId, e.FechaRealiza, e.Anulado, e.FechaPedido, e.InternacionId, e.InterconsultaId, e.PrestadorId, e.GuardiaSectorId, e.GuardiaRegistroId, e.TurnoId, e.NoAtendido }, "_dta_index_Interconsulta_6_722869692__K15_K16_K8_K10_K7_K2_K1_K5_K4_K3_K18_K11_6_17");

            entity.HasIndex(e => new { e.InstitucionId, e.PrestadorId, e.FechaPedido, e.Anulado, e.FechaRealiza, e.InterconsultaId, e.InternacionId, e.NoAtendido, e.GuardiaSectorId, e.GuardiaRegistroId, e.ServicioId, e.TurnoId }, "_dta_index_Interconsulta_6_722869692__K15_K5_K7_K10_K8_K1_K2_K11_K4_K3_K16_K18_6_17");

            entity.Property(e => e.InterconsultaId).HasColumnName("InterconsultaID");
            entity.Property(e => e.DetalleSolicitud).HasMaxLength(500);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.FechaRealiza).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MotivoNoAtiende).HasMaxLength(300);
            entity.Property(e => e.NoAtendido).HasColumnType("datetime");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Internacion).WithMany(p => p.Interconsulta)
                .HasForeignKey(d => d.InternacionId)
                .HasConstraintName("FK_Interconsulta_Internaciones");

            entity.HasOne(d => d.Prestador).WithMany(p => p.Interconsulta)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Interconsulta_Prestadores");
        });

        modelBuilder.Entity<InternacionAcompanantes>(entity =>
        {
            entity.HasKey(e => e.IdAcompananteInternado);

            entity.Property(e => e.IdAcompananteInternado).HasColumnName("idAcompananteInternado");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.DomicilioAcompanante)
                .HasMaxLength(200)
                .HasColumnName("domicilioAcompanante");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.FechaFin).HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.IdAcompanante).HasColumnName("idAcompanante");
            entity.Property(e => e.IdTipoParentezco).HasColumnName("idTipoParentezco");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.TelefonoAcompanante)
                .HasMaxLength(50)
                .HasColumnName("telefonoAcompanante");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCrea");

            entity.HasOne(d => d.IdAcompananteNavigation).WithMany(p => p.InternacionAcompanantes)
                .HasForeignKey(d => d.IdAcompanante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InternacionAcompanantes_Pacientes");

            entity.HasOne(d => d.Internacion).WithMany(p => p.InternacionAcompanantes)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InternacionAcompanantes_Internaciones");
        });

        modelBuilder.Entity<Internaciones>(entity =>
        {
            entity.HasKey(e => e.InternacionId);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Tr_EdicionInternadoHCWeb");
                    tb.HasTrigger("Tr_RegistroInternadoHCWeb");
                });

            entity.HasIndex(e => e.PrestadorIngresoId, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.FechaAlta, e.InternacionReferenciaId, e.CompartenCama }, "IndiceConsulta");

            entity.HasIndex(e => new { e.FechaAlta, e.IdinternacionHc }, "InterFecAltaIdHC");

            entity.HasIndex(e => new { e.Anulado, e.InternacionReferenciaId, e.CompartenCama }, "InternacionCamaCuna");

            entity.HasIndex(e => new { e.TipoAltaId, e.HabitacionId, e.InternacionId, e.InstitucionId, e.PacienteId, e.CamaId }, "_dta_index_Internaciones_6_1904113924__K18_K4_K1_K42_K2_K5_41_53_56_58");

            entity.HasIndex(e => new { e.Anulado, e.FechaAlta, e.InternacionReferenciaId, e.CompartenCama, e.InternacionId, e.PacienteId, e.FechaCrea }, "_dta_index_Internaciones_6_1904113924__K22_K15_K28_K29_K1_K2_K25_11_12_45_53");

            entity.HasIndex(e => new { e.PacienteId, e.Anulado, e.InternacionId }, "_dta_index_Internaciones_6_1904113924__K2_K22_K1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_23_24_25_26_27_28_29_30_31_");

            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.CamaId).HasColumnName("CamaID");
            entity.Property(e => e.CentroId).HasColumnName("CentroID");
            entity.Property(e => e.DerivadoA)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Derivado_A");
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.DiagnosticoIosepId).HasColumnName("DiagnosticoIosepID");
            entity.Property(e => e.EpicrisisSinCargar).HasDefaultValue(true);
            entity.Property(e => e.FamiliarReferente)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Familiar_Referente");
            entity.Property(e => e.FechaAlta).HasColumnName("Fecha_Alta");
            entity.Property(e => e.FechaAltaAdmin).HasColumnName("Fecha_Alta_Admin");
            entity.Property(e => e.FechaAnulaIosep).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaForza).HasColumnName("Fecha_Forza");
            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_ingreso");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistraAlta).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.HijoNombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.HoraAlta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Hora_alta");
            entity.Property(e => e.HoraIngreso)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Hora_Ingreso");
            entity.Property(e => e.IdinternacionHc).HasColumnName("IDInternacionHC");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionIdmod).HasColumnName("InternacionIDMod");
            entity.Property(e => e.InternacionReferenciaId).HasColumnName("InternacionReferenciaID");
            entity.Property(e => e.MotivoIngresoId).HasColumnName("MotivoIngresoID");
            entity.Property(e => e.MovilId).HasColumnName("MovilID");
            entity.Property(e => e.NomExpedienteId).HasColumnName("NomExpedienteID");
            entity.Property(e => e.NumeroFamiliar).HasMaxLength(50);
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.OcupacionHabitual)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Ocupacion_Habitual");
            entity.Property(e => e.OtroCentro).HasMaxLength(100);
            entity.Property(e => e.OtroMedioTraslado).HasMaxLength(200);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PacienteReferenciaId).HasColumnName("PacienteReferenciaID");
            entity.Property(e => e.PrestadorAltaId).HasColumnName("PrestadorAltaID");
            entity.Property(e => e.PrestadorIngresoId).HasColumnName("PrestadorIngresoID");
            entity.Property(e => e.TelefonoReferente)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Telefono_Referente");
            entity.Property(e => e.TipoAltaId).HasColumnName("TipoAltaID");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioForza)
                .HasMaxLength(100)
                .HasColumnName("Usuario_Forza");
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Internaciones)
                .HasForeignKey(d => d.HabitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Internaciones_Habitaciones_Hospital");

            entity.HasOne(d => d.MotivoIngreso).WithMany(p => p.Internaciones)
                .HasForeignKey(d => d.MotivoIngresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Internaciones_Tipo_Ingresos");

            entity.HasOne(d => d.ObraSocial).WithMany(p => p.Internaciones)
                .HasForeignKey(d => d.ObraSocialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Internaciones_ObraSocial");

            entity.HasOne(d => d.Paciente).WithMany(p => p.Internaciones)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Internaciones_Pacientes");

            entity.HasOne(d => d.PrestadorAlta).WithMany(p => p.InternacionesPrestadorAlta)
                .HasForeignKey(d => d.PrestadorAltaId)
                .HasConstraintName("FK_Internaciones_Prestadores1");

            entity.HasOne(d => d.PrestadorIngreso).WithMany(p => p.InternacionesPrestadorIngreso)
                .HasForeignKey(d => d.PrestadorIngresoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Internaciones_Prestadores");

            entity.HasOne(d => d.TipoAlta).WithMany(p => p.Internaciones)
                .HasForeignKey(d => d.TipoAltaId)
                .HasConstraintName("FK_Internaciones_Tipo_AltaIntenado");
        });

        modelBuilder.Entity<InternadoAislamiento>(entity =>
        {
            entity.HasKey(e => e.IdInternadoAislamiento);

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.UserAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UserCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UserModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<InternadosAfeccion>(entity =>
        {
            entity.HasKey(e => e.AfeccionInternacionId);

            entity.Property(e => e.AfeccionInternacionId).HasColumnName("AfeccionInternacionID");
            entity.Property(e => e.CodigoAfeccion).HasMaxLength(50);
            entity.Property(e => e.FechaHoraAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraModifica).HasColumnType("datetime");
            entity.Property(e => e.IdAfeccionIosep).HasColumnName("IdAfeccionIOSEP");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MotivoAnula)
                .HasMaxLength(150)
                .IsFixedLength();
            entity.Property(e => e.NombreAfeccion).HasMaxLength(200);
            entity.Property(e => e.OpAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
        });

        modelBuilder.Entity<InternadosControl>(entity =>
        {
            entity.HasKey(e => e.ControlInternacionId);

            entity.Property(e => e.ControlInternacionId).HasColumnName("ControlInternacionID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.IdControlIosep).HasColumnName("IdControlIOSEP");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.OpAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.SectorId).HasColumnName("SectorID");
            entity.Property(e => e.UserCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<InternadosSectorIosep>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.SectorId).HasColumnName("SectorID");
        });

        modelBuilder.Entity<Intumizacion>(entity =>
        {
            entity.Property(e => e.IntumizacionId).HasColumnName("IntumizacionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IosepDatosIngreso>(entity =>
        {
            entity.HasKey(e => e.IosepDatoaIngresoId);

            entity.Property(e => e.IosepDatoaIngresoId).HasColumnName("IosepDatoaIngresoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FrecuenciaCardiaca).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FrecuenciaRespiratoria).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Saturacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Temperatura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TensionArterial).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TestOlfato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LabGrupoPractica>(entity =>
        {
            entity.Property(e => e.LabGrupoPracticaId).HasColumnName("LabGrupoPracticaID");
            entity.Property(e => e.LaboratorioMetodoId).HasColumnName("LaboratorioMetodoID");
            entity.Property(e => e.LaboratorioPracticasId).HasColumnName("LaboratorioPracticasID");
            entity.Property(e => e.LaboratorioPracticasIdgrupo).HasColumnName("LaboratorioPracticasIDGrupo");
            entity.Property(e => e.LaboratorioSeccionId).HasColumnName("LaboratorioSeccionID");
            entity.Property(e => e.OrdenGrupo).HasDefaultValue(0);
            entity.Property(e => e.SexoId).HasColumnName("SexoID");

            entity.HasOne(d => d.LaboratorioPracticas).WithMany(p => p.LabGrupoPracticaLaboratorioPracticas)
                .HasForeignKey(d => d.LaboratorioPracticasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LabGrupoPractica_LaboratorioPracticas1");

            entity.HasOne(d => d.LaboratorioPracticasIdgrupoNavigation).WithMany(p => p.LabGrupoPracticaLaboratorioPracticasIdgrupoNavigation)
                .HasForeignKey(d => d.LaboratorioPracticasIdgrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LabGrupoPractica_LaboratorioPracticas");
        });

        modelBuilder.Entity<LabRegistroDetalle>(entity =>
        {
            entity.HasIndex(e => e.LaboratorioRegistroId, "LabRegyDetColor");

            entity.HasIndex(e => new { e.LabGrupoPralPracticaId, e.LaboratorioRegistroId }, "_dta_index_LabRegistroDetalle_6_800826015__K14_K2");

            entity.HasIndex(e => new { e.LaboratorioRegistroId, e.FechaCarga }, "_dta_index_LabRegistroDetalle_6_800826015__K2_K10");

            entity.HasIndex(e => new { e.LaboratorioRegistroId, e.LabGrupoPralPracticaId }, "_dta_index_LabRegistroDetalle_6_800826015__K2_K14");

            entity.HasIndex(e => new { e.LaboratorioRegistroId, e.LaboratorioPracticasId }, "_dta_index_LabRegistroDetalle_6_800826015__K2_K4");

            entity.Property(e => e.LabRegistroDetalleId).HasColumnName("LabRegistroDetalleID");
            entity.Property(e => e.CodigoTubo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaCargaCodigoTubo).HasColumnType("datetime");
            entity.Property(e => e.LabGrupoPracticaId).HasColumnName("LabGrupoPracticaID");
            entity.Property(e => e.LabGrupoPralPracticaId).HasColumnName("LabGrupoPralPracticaID");
            entity.Property(e => e.LaboratorioPracticasId).HasColumnName("LaboratorioPracticasID");
            entity.Property(e => e.LaboratorioRegistroId).HasColumnName("LaboratorioRegistroID");
            entity.Property(e => e.OrdenImprimir).HasDefaultValue(0);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Resultado)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCargaCodigoTubo)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LabRegistroResultadosLog>(entity =>
        {
            entity.Property(e => e.LabRegistroResultadosLogId).HasColumnName("LabRegistroResultadosLogID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaConfirma).HasColumnType("datetime");
            entity.Property(e => e.LabRegistroDetalleId).HasColumnName("LabRegistroDetalleID");
            entity.Property(e => e.Resultado).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.LabRegistroDetalle).WithMany(p => p.LabRegistroResultadosLog)
                .HasForeignKey(d => d.LabRegistroDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LabRegistroResultadosLog_LabRegistroDetalle");
        });

        modelBuilder.Entity<LabRegistroXestado>(entity =>
        {
            entity.ToTable("LabRegistroXEstado");

            entity.HasIndex(e => e.LaboratorioRegistroId, "_dta_index_LabRegistroXEstado_6_382676461__K2_1_3_4_5");

            entity.Property(e => e.LabRegistroXestadoId).HasColumnName("LabRegistroXEstadoID");
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.LaboratorioRegistroId).HasColumnName("LaboratorioRegistroID");
            entity.Property(e => e.PracticasEstadoId).HasColumnName("PracticasEstadoID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.LaboratorioRegistro).WithMany(p => p.LabRegistroXestado)
                .HasForeignKey(d => d.LaboratorioRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LabRegistroXEstado_LaboratorioRegistro");
        });

        modelBuilder.Entity<LabTipoMuestra>(entity =>
        {
            entity.HasKey(e => e.LabTipoMuestraId).HasName("PK__LabTipoM__5E074E7A4842A82E");

            entity.Property(e => e.LabTipoMuestraId).HasColumnName("LabTipoMuestraID");
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(80);
            entity.Property(e => e.Sufijo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LabTipoPractica>(entity =>
        {
            entity.Property(e => e.LabTipoPracticaId).HasColumnName("LabTipoPracticaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LabUnidadMedida>(entity =>
        {
            entity.Property(e => e.LabUnidadMedidaId).HasColumnName("LabUnidadMedidaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LaboratorioAgrupaSuma>(entity =>
        {
            entity.Property(e => e.LaboratorioAgrupaSumaId).HasColumnName("LaboratorioAgrupaSumaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SumaTotal).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<LaboratorioFormulaDetalle>(entity =>
        {
            entity.Property(e => e.LaboratorioFormulaDetalleId).HasColumnName("LaboratorioFormulaDetalleID");
            entity.Property(e => e.LaboratorioFormulaId).HasColumnName("LaboratorioFormulaID");
            entity.Property(e => e.LaboratorioOperadorId).HasColumnName("LaboratorioOperadorID");
            entity.Property(e => e.LaboratorioPracticasId).HasColumnName("LaboratorioPracticasID");
        });

        modelBuilder.Entity<LaboratorioFormulas>(entity =>
        {
            entity.HasKey(e => e.LaboratorioFormulaId);

            entity.Property(e => e.LaboratorioFormulaId).HasColumnName("LaboratorioFormulaID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LaboratorioMetodos>(entity =>
        {
            entity.HasKey(e => e.LaboratorioMetodoId);

            entity.Property(e => e.LaboratorioMetodoId).HasColumnName("LaboratorioMetodoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LaboratorioOperadores>(entity =>
        {
            entity.HasKey(e => e.LaboratorioOperadorId);

            entity.Property(e => e.LaboratorioOperadorId).HasColumnName("LaboratorioOperadorID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Signo)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<LaboratorioPracticaListaResultado>(entity =>
        {
            entity.Property(e => e.LaboratorioPracticaListaResultadoId).HasColumnName("LaboratorioPracticaListaResultadoID");
            entity.Property(e => e.LaboratorioPracticasId).HasColumnName("LaboratorioPracticasID");
            entity.Property(e => e.TextoRespuesta)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.LaboratorioPracticas).WithMany(p => p.LaboratorioPracticaListaResultado)
                .HasForeignKey(d => d.LaboratorioPracticasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaboratorioPracticaListaResultado_LaboratorioPracticas");
        });

        modelBuilder.Entity<LaboratorioPracticaMuestra>(entity =>
        {
            entity.HasKey(e => e.LaboratorioPracticaMuestraId).HasName("PK__Laborato__4358A3A1AD4A5C97");

            entity.Property(e => e.LaboratorioPracticaMuestraId).HasColumnName("LaboratorioPracticaMuestraID");
            entity.Property(e => e.LabTipoMuestraId).HasColumnName("LabTipoMuestraID");
            entity.Property(e => e.LaboratorioPracticasId).HasColumnName("LaboratorioPracticasID");

            entity.HasOne(d => d.LabTipoMuestra).WithMany(p => p.LaboratorioPracticaMuestra)
                .HasForeignKey(d => d.LabTipoMuestraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaboratorioPracticaMuestra_LabTipoMuestra");

            entity.HasOne(d => d.LaboratorioPracticas).WithMany(p => p.LaboratorioPracticaMuestra)
                .HasForeignKey(d => d.LaboratorioPracticasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaboratorioPracticaMuestra_LaboratorioPracticas");
        });

        modelBuilder.Entity<LaboratorioPracticas>(entity =>
        {
            entity.HasIndex(e => new { e.Anulado, e.InstitucionId, e.LaboratorioPracticasId }, "Ix-LaboratorioPracticas-Andulado_InstitucionID_LabPracID");

            entity.HasIndex(e => new { e.LaboratorioPracticasId, e.LaboratorioSeccionId }, "_dta_index_LaboratorioPracticas_6_1671781113__K1_K24");

            entity.HasIndex(e => new { e.Privado, e.LaboratorioPracticasId }, "_dta_index_LaboratorioPracticas_6_1671781113__K21_K1");

            entity.HasIndex(e => e.LaboratorioSeccionId, "_dta_index_LaboratorioPracticas_6_1671781113__K24_1");

            entity.Property(e => e.LaboratorioPracticasId).HasColumnName("LaboratorioPracticasID");
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.LabTipoMuestraId).HasColumnName("LabTipoMuestraID");
            entity.Property(e => e.LabTipoPracticaId).HasColumnName("LabTipoPracticaID");
            entity.Property(e => e.LaboratorioAgrupaSumaId).HasColumnName("LaboratorioAgrupaSumaID");
            entity.Property(e => e.LaboratorioFormulaId).HasColumnName("LaboratorioFormulaID");
            entity.Property(e => e.LaboratorioMetodoId).HasColumnName("LaboratorioMetodoID");
            entity.Property(e => e.LaboratorioPracticasIdoriginal).HasColumnName("LaboratorioPracticasIDOriginal");
            entity.Property(e => e.LaboratorioSeccionId).HasColumnName("LaboratorioSeccionID");
            entity.Property(e => e.Liscode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LISCODE");
            entity.Property(e => e.Liscoderecepcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LISCODERECEPCION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Realizandose).HasDefaultValue(true);
            entity.Property(e => e.SexoId).HasColumnName("SexoID");
            entity.Property(e => e.TipoValorResultado)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ValorMaximo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("valorMaximo");
            entity.Property(e => e.ValorMinimo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("valorMinimo");
            entity.Property(e => e.ValorNormal)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.LabTipoMuestra).WithMany(p => p.LaboratorioPracticas)
                .HasForeignKey(d => d.LabTipoMuestraId)
                .HasConstraintName("FK_LaboratorioPracticas_LabTipoMuestra");

            entity.HasOne(d => d.LabTipoPractica).WithMany(p => p.LaboratorioPracticas)
                .HasForeignKey(d => d.LabTipoPracticaId)
                .HasConstraintName("FK_LaboratorioPracticas_LabTipoPractica");

            entity.HasOne(d => d.LaboratorioAgrupaSuma).WithMany(p => p.LaboratorioPracticas)
                .HasForeignKey(d => d.LaboratorioAgrupaSumaId)
                .HasConstraintName("FK_LaboratorioPracticas_LaboratorioAgrupaSuma");
        });

        modelBuilder.Entity<LaboratorioRegistro>(entity =>
        {
            entity.HasIndex(e => new { e.PacienteId, e.PracticasEstadoId, e.Anulado }, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.Anulado, e.TurnoId, e.PracticasOrigenId, e.PracticasEstadoId, e.PacienteId }, "_dta_index_LaboratorioRegistro_6_148299688__K13_K3_K6_K7_K2_9");

            entity.HasIndex(e => new { e.InstitucionId, e.Anulado, e.Fecha, e.PracticasEstadoId, e.LaboratorioRegistroId, e.PacienteId, e.Urgente, e.NumeroIdentificador }, "_dta_index_LaboratorioRegistro_6_148299688__K20_K13_K12_K7_K1_K2_K8_K9");

            entity.HasIndex(e => new { e.InstitucionId, e.Anulado, e.Fecha, e.PracticasEstadoId, e.LaboratorioRegistroId, e.Urgente, e.NumeroIdentificador }, "_dta_index_LaboratorioRegistro_6_148299688__K20_K13_K12_K7_K1_K8_K9");

            entity.HasIndex(e => new { e.InstitucionId, e.Anulado, e.Fecha, e.PracticasEstadoId, e.PacienteId, e.Urgente, e.NumeroIdentificador }, "_dta_index_LaboratorioRegistro_6_148299688__K20_K13_K12_K7_K2_K8_K9_1_3_4_5_6_10_11_14_15_16_17_18_19_21_22_23");

            entity.HasIndex(e => new { e.InstitucionId, e.Anulado, e.NumeroIdentificador, e.PracticasOrigenId, e.Fecha, e.Validado, e.PracticasEstadoId, e.TurnoId, e.PrestadorSolicita, e.PacienteId, e.LaboratorioRegistroId, e.Urgente }, "_dta_index_LaboratorioRegistro_6_148299688__K20_K13_K9_K6_K12_K23_K7_K3_K10_K2_K1_K8_16");

            entity.HasIndex(e => new { e.InstitucionId, e.Anulado, e.NumeroIdentificador, e.PracticasOrigenId, e.Fecha, e.PracticasEstadoId, e.TurnoId, e.PrestadorSolicita, e.PacienteId, e.LaboratorioRegistroId, e.Urgente }, "_dta_index_LaboratorioRegistro_6_148299688__K20_K13_K9_K6_K12_K7_K3_K10_K2_K1_K8_16");

            entity.HasIndex(e => new { e.PracticasEstadoId, e.Anulado, e.LaboratorioRegistroId, e.InstitucionId, e.Fecha }, "_dta_index_LaboratorioRegistro_6_148299688__K7_K13_K1_K20_K12");

            entity.HasIndex(e => new { e.PracticasEstadoId, e.Anulado, e.LaboratorioRegistroId, e.InstitucionId, e.Fecha, e.Urgente }, "_dta_index_LaboratorioRegistro_6_148299688__K7_K13_K1_K20_K12_K8");

            entity.HasIndex(e => new { e.PracticasEstadoId, e.Anulado, e.LaboratorioRegistroId, e.InstitucionId, e.Fecha, e.Urgente }, "_dta_index_LaboratorioRegistro_6_148299688__K7_K13_K1_K20_K12_K8_2_3_4_5_6_9_10_11_14_15_16_17_18_19_21_22_23");

            entity.HasIndex(e => new { e.PracticasEstadoId, e.PacienteId, e.Anulado, e.LaboratorioRegistroId, e.PracticasOrigenId, e.PrestadorSolicita, e.Fecha }, "_dta_index_LaboratorioRegistro_6_148299688__K7_K2_K13_K1_K6_K10_K12_3_4_5_8_9_11_14_15_16_17_18_19_20_21_22_23");

            entity.HasIndex(e => new { e.Urgente, e.NumeroIdentificador, e.Fecha, e.PracticasOrigenId, e.InstitucionId, e.TurnoId, e.PracticasEstadoId, e.Anulado }, "_dta_index_LaboratorioRegistro_6_148299688__K8D_K9_K12_K6_K20_K3_K7_K13_1_2_10_16").IsDescending(true, false, false, false, false, false, false, false);

            entity.Property(e => e.LaboratorioRegistroId).HasColumnName("LaboratorioRegistroID");
            entity.Property(e => e.CodigoBarra)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoWeb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MotivoModificado).HasMaxLength(300);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PracticasEstadoId).HasColumnName("PracticasEstadoID");
            entity.Property(e => e.PracticasOrigenId).HasColumnName("PracticasOrigenID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.TurnoReferenciaId).HasColumnName("TurnoReferenciaID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PracticasOrigen).WithMany(p => p.LaboratorioRegistro)
                .HasForeignKey(d => d.PracticasOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaboratorioRegistro_PracticasOrigen");

            entity.HasOne(d => d.PrestadorRealizaNavigation).WithMany(p => p.LaboratorioRegistroPrestadorRealizaNavigation)
                .HasForeignKey(d => d.PrestadorRealiza)
                .HasConstraintName("FK_LaboratorioRegistro_Prestadores");

            entity.HasOne(d => d.PrestadorSolicitaNavigation).WithMany(p => p.LaboratorioRegistroPrestadorSolicitaNavigation)
                .HasForeignKey(d => d.PrestadorSolicita)
                .HasConstraintName("FK_LaboratorioRegistro_Prestadores1");

            entity.HasOne(d => d.Turno).WithMany(p => p.LaboratorioRegistro)
                .HasForeignKey(d => d.TurnoId)
                .HasConstraintName("FK_LaboratorioRegistro_Turnos");
        });

        modelBuilder.Entity<LaboratorioSecciones>(entity =>
        {
            entity.HasKey(e => e.LaboratorioSeccionId);

            entity.Property(e => e.LaboratorioSeccionId).HasColumnName("LaboratorioSeccionID");
            entity.Property(e => e.ColorPractica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LaboratorioXsector>(entity =>
        {
            entity.ToTable("LaboratorioXSector");

            entity.Property(e => e.LaboratorioXsectorId).HasColumnName("LaboratorioXSectorID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.LaboratorioId).HasColumnName("LaboratorioID");
            entity.Property(e => e.SectorId).HasColumnName("SectorID");
            entity.Property(e => e.SectorNombre).HasMaxLength(200);
            entity.Property(e => e.TipoNombre).HasMaxLength(200);
            entity.Property(e => e.TipoSectorId).HasColumnName("TipoSectorID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LaboratorioXusuario>(entity =>
        {
            entity.ToTable("LaboratorioXUsuario");

            entity.Property(e => e.LaboratorioXusuarioId).HasColumnName("LaboratorioXUSuarioID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.LaboratorioId).HasColumnName("LaboratorioID");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Laboratorios>(entity =>
        {
            entity.HasKey(e => e.LaboratorioId);

            entity.Property(e => e.LaboratorioId).HasColumnName("LaboratorioID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Localidades>(entity =>
        {
            entity.HasKey(e => e.IdLocalidad);

            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Localidades)
                .HasForeignKey(d => d.IdProvincia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Localidades_Provincias");
        });

        modelBuilder.Entity<LogExcepciones>(entity =>
        {
            entity.HasKey(e => e.IdExcepcion);

            entity.Property(e => e.Accion).HasMaxLength(49);
            entity.Property(e => e.Controlador).HasMaxLength(40);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IpOrigen)
                .HasMaxLength(15)
                .HasColumnName("IP_Origen");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Logs>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoteRegPagos>(entity =>
        {
            entity.HasKey(e => e.LoteRegPagoId);

            entity.Property(e => e.LoteRegPagoId).HasColumnName("LoteRegPagoID");
            entity.Property(e => e.Distribuido).HasColumnType("datetime");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.LoteId).HasColumnName("LoteID");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoPagoId).HasColumnName("TipoPagoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMarcaDistribuido)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LoteRegXestado>(entity =>
        {
            entity.ToTable("LoteRegXEstado");

            entity.Property(e => e.LoteRegXestadoId).HasColumnName("LoteRegXEstadoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.LoteId).HasColumnName("LoteID");
            entity.Property(e => e.TramiteEstadoId).HasColumnName("TramiteEstadoID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Lotes>(entity =>
        {
            entity.HasKey(e => e.LoteId);

            entity.Property(e => e.LoteId).HasColumnName("LoteID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaExtendido).HasColumnType("datetime");
            entity.Property(e => e.FechaPresentado).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.NroFactura).HasMaxLength(50);
            entity.Property(e => e.NroLote)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.Periodo).HasMaxLength(100);
            entity.Property(e => e.TramiteEstadoId).HasColumnName("TramiteEstadoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCierra)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<LugarRetira>(entity =>
        {
            entity.HasKey(e => e.RetiraId);

            entity.Property(e => e.RetiraId).HasColumnName("RetiraID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Mails>(entity =>
        {
            entity.HasKey(e => e.MailId);

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("EMail");

            entity.HasOne(d => d.Persona).WithMany(p => p.Mails)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mails_Personas");

            entity.HasOne(d => d.TipoMail).WithMany(p => p.Mails)
                .HasForeignKey(d => d.TipoMailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mails_Tipo_Mail");
        });

        modelBuilder.Entity<ManualDatCobertura>(entity =>
        {
            entity.HasKey(e => e.IdManualDatCobertura).HasName("PK__ManualDa__2687BFC968A93BE1");

            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.Barras)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("barras");
            entity.Property(e => e.CoberturaAmbulatorio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Cobertura_ambulatorio");
            entity.Property(e => e.CoberturaInternado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Cobertura_Internado");
            entity.Property(e => e.FecAct).HasColumnName("fec_act");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Ioma)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ioma");
            entity.Property(e => e.Laborat)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("laborat");
            entity.Property(e => e.Nombre)
                .HasMaxLength(44)
                .IsFixedLength()
                .HasColumnName("nombre");
            entity.Property(e => e.Present)
                .HasMaxLength(24)
                .IsFixedLength()
                .HasColumnName("present");
            entity.Property(e => e.Registro)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("registro");
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("troquel");
            entity.Property(e => e.VigenciaCobertura).HasColumnName("Vigencia_Cobertura");
        });

        modelBuilder.Entity<Marcas>(entity =>
        {
            entity.HasKey(e => e.MarcaId);

            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<MedicacionDiscreta>(entity =>
        {
            entity.Property(e => e.MedicacionDiscretaId).HasColumnName("MedicacionDiscretaID");
            entity.Property(e => e.FarMedicamentoId).HasColumnName("Far_MedicamentoID");
            entity.Property(e => e.FechaIndica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MedNombre)
                .HasMaxLength(150)
                .HasDefaultValue("-");
            entity.Property(e => e.MedPresentacion)
                .HasMaxLength(150)
                .HasDefaultValue("-");
            entity.Property(e => e.MedicacionViaId).HasColumnName("MedicacionViaID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorIdindica).HasColumnName("PrestadorIDIndica");
            entity.Property(e => e.PrestadorIdretira).HasColumnName("PrestadorIDRetira");
            entity.Property(e => e.Programa)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarMedicamento).WithMany(p => p.MedicacionDiscreta)
                .HasForeignKey(d => d.FarMedicamentoId)
                .HasConstraintName("FK_MedicacionDiscreta_Far_Medicamento");

            entity.HasOne(d => d.MedicacionVia).WithMany(p => p.MedicacionDiscreta)
                .HasForeignKey(d => d.MedicacionViaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionDiscreta_MedicacionVia");

            entity.HasOne(d => d.Paciente).WithMany(p => p.MedicacionDiscreta)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionDiscreta_Pacientes");

            entity.HasOne(d => d.PrestadorIdindicaNavigation).WithMany(p => p.MedicacionDiscretaPrestadorIdindicaNavigation)
                .HasForeignKey(d => d.PrestadorIdindica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionDiscreta_Prestadores");

            entity.HasOne(d => d.PrestadorIdretiraNavigation).WithMany(p => p.MedicacionDiscretaPrestadorIdretiraNavigation)
                .HasForeignKey(d => d.PrestadorIdretira)
                .HasConstraintName("FK_MedicacionDiscreta_Prestadores1");
        });

        modelBuilder.Entity<MedicacionInfusionContinua>(entity =>
        {
            entity.Property(e => e.MedicacionInfusionContinuaId).HasColumnName("MedicacionInfusionContinuaID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.FarMedicamentoId).HasColumnName("Far_MedicamentoID");
            entity.Property(e => e.FechaIndica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MedicacionViaId).HasColumnName("MedicacionViaID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorIdindica).HasColumnName("PrestadorIDIndica");
            entity.Property(e => e.PrestadorIdretira).HasColumnName("PrestadorIDRetira");
            entity.Property(e => e.TipoGoteoId).HasColumnName("TipoGoteoID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.FarMedicamento).WithMany(p => p.MedicacionInfusionContinua)
                .HasForeignKey(d => d.FarMedicamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionInfusionContinua_Far_Medicamento");

            entity.HasOne(d => d.MedicacionVia).WithMany(p => p.MedicacionInfusionContinua)
                .HasForeignKey(d => d.MedicacionViaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionInfusionContinua_MedicacionVia");

            entity.HasOne(d => d.Paciente).WithMany(p => p.MedicacionInfusionContinua)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionInfusionContinua_Pacientes");

            entity.HasOne(d => d.PrestadorIdindicaNavigation).WithMany(p => p.MedicacionInfusionContinuaPrestadorIdindicaNavigation)
                .HasForeignKey(d => d.PrestadorIdindica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionInfusionContinua_Prestadores");

            entity.HasOne(d => d.PrestadorIdretiraNavigation).WithMany(p => p.MedicacionInfusionContinuaPrestadorIdretiraNavigation)
                .HasForeignKey(d => d.PrestadorIdretira)
                .HasConstraintName("FK_MedicacionInfusionContinua_Prestadores1");

            entity.HasOne(d => d.TipoGoteo).WithMany(p => p.MedicacionInfusionContinua)
                .HasForeignKey(d => d.TipoGoteoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionInfusionContinua_TipoGoteo");
        });

        modelBuilder.Entity<MedicacionInfusionContinuaDetalle>(entity =>
        {
            entity.ToTable("MedicacionInfusionContinua_Detalle");

            entity.Property(e => e.MedicacionInfusionContinuaDetalleId).HasColumnName("MedicacionInfusionContinua_DetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CodigoTubo).HasMaxLength(20);
            entity.Property(e => e.FarMedicamentoId).HasColumnName("Far_MedicamentoID");
            entity.Property(e => e.FechaCargaCodigoTubo).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.MedNombre).HasMaxLength(150);
            entity.Property(e => e.MedPresentacion).HasMaxLength(150);
            entity.Property(e => e.MedicacionInfusionContinuaId).HasColumnName("MedicacionInfusionContinuaID");
            entity.Property(e => e.PrestadorIdretira).HasColumnName("PrestadorIDRetira");
            entity.Property(e => e.UsuarioCargaCodigoTubo)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.MedicacionInfusionContinua).WithMany(p => p.MedicacionInfusionContinuaDetalle)
                .HasForeignKey(d => d.MedicacionInfusionContinuaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionInfusionContinua_Detalle_MedicacionInfusionContinua");
        });

        modelBuilder.Entity<MedicacionPaciente>(entity =>
        {
            entity.Property(e => e.MedicacionPacienteId).HasColumnName("MedicacionPacienteID");
            entity.Property(e => e.CantidadSolucion).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");
            entity.Property(e => e.EmfermeroId).HasColumnName("EmfermeroID");
            entity.Property(e => e.EnfermeriaId).HasColumnName("EnfermeriaID");
            entity.Property(e => e.FechaAplica).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaPrescribe).HasColumnType("datetime");
            entity.Property(e => e.FechaProcesa).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MedicacionViaId).HasColumnName("MedicacionViaID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrescripcionId).HasColumnName("PrescripcionID");
            entity.Property(e => e.PrestadorPrescribeId).HasColumnName("PrestadorPrescribeID");
            entity.Property(e => e.PrestadorRetiraId).HasColumnName("PrestadorRetiraID");
            entity.Property(e => e.Programa)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.SectorInternadoId).HasColumnName("SectorInternadoID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.SolucionId).HasColumnName("SolucionID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoEstadoMedicacionId).HasColumnName("TipoEstadoMedicacionID");
            entity.Property(e => e.TipoGoteoId).HasColumnName("TipoGoteoID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioAplica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioProcesa)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Consulta).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.ConsultaId)
                .HasConstraintName("FK_MedicacionPaciente_Consultas_Ambulatorias");

            entity.HasOne(d => d.GuardiaSector).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.GuardiaSectorId)
                .HasConstraintName("FK_MedicacionPaciente_GuardiaSector");

            entity.HasOne(d => d.Internacion).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.InternacionId)
                .HasConstraintName("FK_MedicacionPaciente_Internaciones");

            entity.HasOne(d => d.MedicacionVia).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.MedicacionViaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionPaciente_GuardiaRegistro");

            entity.HasOne(d => d.Paciente).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionPaciente_Pacientes");

            entity.HasOne(d => d.PrestadorPrescribe).WithMany(p => p.MedicacionPacientePrestadorPrescribe)
                .HasForeignKey(d => d.PrestadorPrescribeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionPaciente_Prestadores");

            entity.HasOne(d => d.PrestadorRetira).WithMany(p => p.MedicacionPacientePrestadorRetira)
                .HasForeignKey(d => d.PrestadorRetiraId)
                .HasConstraintName("FK_MedicacionPaciente_Prestadores1");

            entity.HasOne(d => d.SectorInternado).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.SectorInternadoId)
                .HasConstraintName("FK_MedicacionPaciente_Habitaciones_Hospital");

            entity.HasOne(d => d.Servicio).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK_MedicacionPaciente_Servicios");

            entity.HasOne(d => d.TipoEstadoMedicacion).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.TipoEstadoMedicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionPaciente_TipoEstadoMedicacionPaciente");

            entity.HasOne(d => d.TipoGoteo).WithMany(p => p.MedicacionPaciente)
                .HasForeignKey(d => d.TipoGoteoId)
                .HasConstraintName("FK_MedicacionPaciente_TipoGoteo");
        });

        modelBuilder.Entity<MedicacionPacienteDetalle>(entity =>
        {
            entity.Property(e => e.MedicacionPacienteDetalleId).HasColumnName("MedicacionPacienteDetalleID");
            entity.Property(e => e.ArticuloDroga).HasMaxLength(100);
            entity.Property(e => e.ArticuloNombre).HasMaxLength(100);
            entity.Property(e => e.ArticuloPresentacion).HasMaxLength(100);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");
            entity.Property(e => e.EnfermeroAplicaId).HasColumnName("EnfermeroAplicaID");
            entity.Property(e => e.FarmaciaArticuloId).HasColumnName("FarmaciaArticuloID");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.InicioServicio)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.MedicacionPacienteId).HasColumnName("MedicacionPacienteID");
            entity.Property(e => e.SinStock).HasColumnName("sinStock");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TipoEstadoMedicacionPacienteDetalleId).HasColumnName("TipoEstadoMedicacionPacienteDetalleID");
            entity.Property(e => e.TipoGoteoId).HasColumnName("TipoGoteoID");
            entity.Property(e => e.UsuarioAplica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.ViaTipoId).HasColumnName("ViaTipoID");

            entity.HasOne(d => d.FarmaciaArticulo).WithMany(p => p.MedicacionPacienteDetalle)
                .HasForeignKey(d => d.FarmaciaArticuloId)
                .HasConstraintName("FK_MedicacionPacienteDetalle_FarmaciaArticulo");

            entity.HasOne(d => d.MedicacionPaciente).WithMany(p => p.MedicacionPacienteDetalle)
                .HasForeignKey(d => d.MedicacionPacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionPacienteDetalle_MedicacionPaciente");

            entity.HasOne(d => d.TipoEstadoMedicacionPacienteDetalle).WithMany(p => p.MedicacionPacienteDetalle)
                .HasForeignKey(d => d.TipoEstadoMedicacionPacienteDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionPacienteDetalle_TipoEstadoMedicacionPacienteDetalle");
        });

        modelBuilder.Entity<MedicacionPacienteHistorico>(entity =>
        {
            entity.Property(e => e.MedicacionPacienteHistoricoId).HasColumnName("MedicacionPacienteHistoricoID");
            entity.Property(e => e.Accion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.MedicacionPacienteId).HasColumnName("MedicacionPacienteID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.MedicacionPaciente).WithMany(p => p.MedicacionPacienteHistorico)
                .HasForeignKey(d => d.MedicacionPacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicacionPacienteHistorico_MedicacionPaciente");
        });

        modelBuilder.Entity<MedicacionVia>(entity =>
        {
            entity.Property(e => e.MedicacionViaId).HasColumnName("MedicacionViaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VistaMedico).HasColumnName("vistaMedico");
        });

        modelBuilder.Entity<MedioCompra>(entity =>
        {
            entity.Property(e => e.MedioCompraId).HasColumnName("MedioCompraID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MetodoAnticonceptivo>(entity =>
        {
            entity.ToTable("Metodo_Anticonceptivo");

            entity.Property(e => e.MetodoAnticonceptivoId).HasColumnName("MetodoAnticonceptivoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<MotivoConsulta>(entity =>
        {
            entity.ToTable("Motivo_Consulta");

            entity.Property(e => e.MotivoConsultaId)
                .ValueGeneratedNever()
                .HasColumnName("MotivoConsultaID");
            entity.Property(e => e.AnamnesisId).HasColumnName("AnamnesisID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Sintomas)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Anamnesis).WithMany(p => p.MotivoConsulta)
                .HasForeignKey(d => d.AnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Motivo_Consulta_Anamnesis");
        });

        modelBuilder.Entity<MotivoGanador>(entity =>
        {
            entity.HasKey(e => e.MotivoGanadorId).HasName("PK_MotivoGanador");

            entity.ToTable("Motivo_Ganador");

            entity.Property(e => e.MotivoGanadorId).HasColumnName("MotivoGanadorID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<MotivoProtegido>(entity =>
        {
            entity.HasKey(e => e.IdMotivoProtegido);

            entity.Property(e => e.IdMotivoProtegido).HasColumnName("idMotivoProtegido");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.ControlPorPrestador).HasColumnName("controlPorPrestador");
            entity.Property(e => e.ControlPorServicio).HasColumnName("controlPorServicio");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.IdInstitucion).HasColumnName("idInstitucion");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<MotivoProtegidoPaciente>(entity =>
        {
            entity.HasKey(e => e.IdMotivoPaciente);

            entity.Property(e => e.IdMotivoPaciente).HasColumnName("idMotivoPaciente");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.CantidadDisponible).HasColumnName("cantidadDisponible");
            entity.Property(e => e.CantidadTotal).HasColumnName("cantidadTotal");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.FechaFin).HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.IdMotivoProtegido).HasColumnName("idMotivoProtegido");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.IdPrestador).HasColumnName("idPrestador");
            entity.Property(e => e.IdServicio).HasColumnName("idServicio");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCrea");

            entity.HasOne(d => d.IdMotivoProtegidoNavigation).WithMany(p => p.MotivoProtegidoPaciente)
                .HasForeignKey(d => d.IdMotivoProtegido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MotivoProtegidoPaciente_MotivoProtegido");
        });

        modelBuilder.Entity<MotivoProtegidoRol>(entity =>
        {
            entity.HasKey(e => e.IdMotivoRol);

            entity.Property(e => e.IdMotivoRol).HasColumnName("idMotivoRol");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.IdMotivoProtegido).HasColumnName("idMotivoProtegido");
            entity.Property(e => e.IdRol)
                .HasMaxLength(128)
                .HasColumnName("idRol");

            entity.HasOne(d => d.IdMotivoProtegidoNavigation).WithMany(p => p.MotivoProtegidoRol)
                .HasForeignKey(d => d.IdMotivoProtegido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MotivoProtegidoRol_MotivoProtegido");
        });

        modelBuilder.Entity<MotivoSancionProveedor>(entity =>
        {
            entity.HasKey(e => e.MotivoSancionProveedorId).HasName("PK_MotivoSancionProveedorID");

            entity.Property(e => e.MotivoSancionProveedorId).HasColumnName("MotivoSancionProveedorID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MotivosAnula>(entity =>
        {
            entity.HasKey(e => e.MotivoAnulaId);

            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
        });

        modelBuilder.Entity<MotivosConsultas>(entity =>
        {
            entity.HasKey(e => e.MotivoConsultaId);

            entity.Property(e => e.MotivoConsultaId).HasColumnName("MotivoConsultaID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.NombreMotivo).HasMaxLength(150);

            entity.HasOne(d => d.Institucion).WithMany(p => p.MotivosConsultas)
                .HasForeignKey(d => d.InstitucionId)
                .HasConstraintName("FK_MotivosConsultas_Instituciones");
        });

        modelBuilder.Entity<MovilHospital>(entity =>
        {
            entity.Property(e => e.MovilHospitalId).HasColumnName("MovilHospitalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MovimientosInternaciones>(entity =>
        {
            entity.HasKey(e => e.MovimientoInternadoId);

            entity.ToTable("Movimientos_Internaciones", tb =>
                {
                    tb.HasTrigger("Tr_EdicionPasesInternadoHCWeb");
                    tb.HasTrigger("Tr_RegistroPaseInternadoHCWeb");
                });

            entity.HasIndex(e => e.Anulado, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.Activo, e.Anulado, e.HastaCamaId }, "Index_MovInternaciones");

            entity.HasIndex(e => new { e.InternacionId, e.Activo, e.MovimientoInternadoId }, "_dta_index_Movimientos_Internaciones_6_608057252__K2_K10_K1");

            entity.Property(e => e.MovimientoInternadoId).HasColumnName("MovimientoInternadoID");
            entity.Property(e => e.DesdeCamaId).HasColumnName("DesdeCamaID");
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.EpicrisisSinCargar).HasDefaultValue(true);
            entity.Property(e => e.EstadoId).HasColumnName("EstadoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.HastaCamaId).HasColumnName("HastaCamaID");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MovInternadoIdhc).HasColumnName("MovInternadoIDHC");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.SoloCama).HasColumnName("soloCama");
            entity.Property(e => e.TipoInternacionId).HasColumnName("TipoInternacionID");
            entity.Property(e => e.UsuarioCrea).HasMaxLength(11);
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.DesdeCama).WithMany(p => p.MovimientosInternacionesDesdeCama)
                .HasForeignKey(d => d.DesdeCamaId)
                .HasConstraintName("FK_Movimientos_Internaciones_Camas");

            entity.HasOne(d => d.HastaCama).WithMany(p => p.MovimientosInternacionesHastaCama)
                .HasForeignKey(d => d.HastaCamaId)
                .HasConstraintName("FK_Movimientos_Internaciones_Camas1");

            entity.HasOne(d => d.Internacion).WithMany(p => p.MovimientosInternaciones)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimientos_Internaciones_Internaciones");

            entity.HasOne(d => d.Prestador).WithMany(p => p.MovimientosInternaciones)
                .HasForeignKey(d => d.PrestadorId)
                .HasConstraintName("FK_Movimientos_Internaciones_Prestadores");
        });

        modelBuilder.Entity<MovimientosUsuario>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datos)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("datos");
            entity.Property(e => e.FechaMod)
                .HasColumnType("datetime")
                .HasColumnName("fechaMod");
            entity.Property(e => e.Operacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("operacion");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tabla");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Nbu2012Ed2016>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'NBU 2012 - Ed#2016$'");

            entity.Property(e => e.F2).HasMaxLength(255);
            entity.Property(e => e.F3).HasMaxLength(255);
            entity.Property(e => e.F4).HasMaxLength(255);
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.F8).HasMaxLength(255);
            entity.Property(e => e.NBUVersión2012Actualización2016).HasColumnName("N#B#U# Versión 2012 - Actualización 2016");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.DiasNotificacion).HasDefaultValue(0);
            entity.Property(e => e.Enlace).HasMaxLength(300);
            entity.Property(e => e.IconoId).HasColumnName("IconoID");
            entity.Property(e => e.Inicio).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Vencimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<NodoAdmision>(entity =>
        {
            entity.HasKey(e => e.IdAdmision);

            entity.ToTable("Nodo_Admision");

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaApertura).HasColumnType("datetime");
            entity.Property(e => e.FechaAsigna).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaDeriva).HasColumnType("datetime");
            entity.Property(e => e.HospitalId).HasColumnName("HospitalID");
            entity.Property(e => e.Idinstitucion).HasColumnName("IDInstitucion");
            entity.Property(e => e.IdprestadorAsignado).HasColumnName("IDPrestadorAsignado");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.NodoPacienteEstadoId).HasColumnName("Nodo_PacienteEstadoID");
            entity.Property(e => e.NroAfiliado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialId)
                .HasDefaultValue(0)
                .HasColumnName("ObraSocialID");
            entity.Property(e => e.OtroNo).HasColumnName("OtroNO");
            entity.Property(e => e.OtroSd).HasColumnName("OtroSD");
            entity.Property(e => e.OtroSi).HasColumnName("OtroSI");
            entity.Property(e => e.RegistroContingenteId).HasColumnName("RegistroContingenteID");
            entity.Property(e => e.SaturometriaNo).HasColumnName("SaturometriaNO");
            entity.Property(e => e.SaturometriaSd).HasColumnName("SaturometriaSD");
            entity.Property(e => e.SaturometriaSi).HasColumnName("SaturometriaSI");
            entity.Property(e => e.TemperaturaNo).HasColumnName("TemperaturaNO");
            entity.Property(e => e.TemperaturaSd).HasColumnName("TemperaturaSD");
            entity.Property(e => e.TemperaturaSi).HasColumnName("TemperaturaSI");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioAsigna)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioDeriva)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NodoControlesDiarios>(entity =>
        {
            entity.HasKey(e => e.IdControlDiario);

            entity.ToTable("Nodo_ControlesDiarios");

            entity.Property(e => e.Drotro)
                .HasMaxLength(300)
                .HasColumnName("DROtro");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FrmayorIgual30x).HasColumnName("FRMayorIgual30x");
            entity.Property(e => e.Imc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMC");
            entity.Property(e => e.Pamayor9060).HasColumnName("PAMayor9060");
            entity.Property(e => e.PerimetroAbdominal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SignosVitalesFc)
                .HasMaxLength(20)
                .HasColumnName("SignosVitalesFC");
            entity.Property(e => e.SignosVitalesFr)
                .HasMaxLength(20)
                .HasColumnName("SignosVitalesFR");
            entity.Property(e => e.SignosVitalesSatu).HasMaxLength(20);
            entity.Property(e => e.SignosVitalesTa)
                .HasMaxLength(20)
                .HasColumnName("SignosVitalesTA");
            entity.Property(e => e.SignosVitalesTemp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Talla).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdIngresoNodoNavigation).WithMany(p => p.NodoControlesDiarios)
                .HasForeignKey(d => d.IdIngresoNodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nodo_ControlesDiarios_Nodo_Ingreso");
        });

        modelBuilder.Entity<NodoDietas>(entity =>
        {
            entity.HasKey(e => e.NodoDietaId);

            entity.ToTable("Nodo_Dietas");

            entity.Property(e => e.NodoDietaId).HasColumnName("NodoDietaID");
            entity.Property(e => e.Detalle).HasMaxLength(500);
            entity.Property(e => e.DietaId).HasColumnName("DietaID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NodoExamenFisico>(entity =>
        {
            entity.HasKey(e => e.IdExamenFisico).HasName("PK_ExamenFisico");

            entity.ToTable("Nodo_ExamenFisico");

            entity.Property(e => e.CentroDerivaId).HasColumnName("CentroDerivaID");
            entity.Property(e => e.CentroEstrellaId).HasColumnName("CentroEstrellaID");
            entity.Property(e => e.Fa60100).HasColumnName("FA60100");
            entity.Property(e => e.FcmayorIgual30).HasColumnName("FCMayorIgual30");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Imc).HasColumnName("IMC");
            entity.Property(e => e.OtroCentroDeriva).HasMaxLength(300);
            entity.Property(e => e.OtroCentroEstrella).HasMaxLength(300);
            entity.Property(e => e.Pamenor9060).HasColumnName("PAMenor9060");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdIngresoNodoNavigation).WithMany(p => p.NodoExamenFisico)
                .HasForeignKey(d => d.IdIngresoNodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nodo_ExamenFisico_Nodo_Ingreso");
        });

        modelBuilder.Entity<NodoHisopado>(entity =>
        {
            entity.HasKey(e => e.IdHisopado);

            entity.ToTable("Nodo_Hisopado");

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdIngresoNodoNavigation).WithMany(p => p.NodoHisopado)
                .HasForeignKey(d => d.IdIngresoNodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nodo_Hisopado_Nodo_Ingreso");
        });

        modelBuilder.Entity<NodoHisopadoResultado>(entity =>
        {
            entity.HasKey(e => e.IdHisopadoResultado);

            entity.ToTable("Nodo_HisopadoResultado");

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdHisopadoNavigation).WithMany(p => p.NodoHisopadoResultado)
                .HasForeignKey(d => d.IdHisopado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nodo_HisopadoResultado_Nodo_Hisopado");
        });

        modelBuilder.Entity<NodoIngreso>(entity =>
        {
            entity.HasKey(e => e.IdIngresoNodo).HasName("PK_IngresoNodo");

            entity.ToTable("Nodo_Ingreso");

            entity.Property(e => e.AdjuntoUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CamaId).HasColumnName("CamaID");
            entity.Property(e => e.CentroId).HasColumnName("CentroID");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistraAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistraIngreso).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Motivo).HasMaxLength(500);
            entity.Property(e => e.MotivoAnula).HasMaxLength(300);
            entity.Property(e => e.NodoTipoId).HasColumnName("NodoTipoID");
            entity.Property(e => e.OtroCentro).HasMaxLength(200);
            entity.Property(e => e.OtrosLugar).HasMaxLength(300);
            entity.Property(e => e.PrestadorAltaId).HasColumnName("PrestadorAltaID");
            entity.Property(e => e.RespuestaOtros).HasMaxLength(300);
            entity.Property(e => e.TipoAltaId).HasColumnName("TipoAltaID");
            entity.Property(e => e.TipoTrasladoId).HasColumnName("TipoTrasladoID");
            entity.Property(e => e.UsuarioAlta)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdAdmisionNavigation).WithMany(p => p.NodoIngreso)
                .HasForeignKey(d => d.IdAdmision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nodo_Ingreso_Nodo_Admision");
        });

        modelBuilder.Entity<NodoLugaresAltoRiesgo>(entity =>
        {
            entity.HasKey(e => e.IdAltoRiesgo);

            entity.ToTable("Nodo_LugaresAltoRiesgo");

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NodoLugaresAltoRiesgoTrigger>(entity =>
        {
            entity.HasKey(e => e.IdTrigger).HasName("PK_Nodo_LugaresAltoRiesgoTrigger_1");

            entity.ToTable("Nodo_LugaresAltoRiesgoTrigger");

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NodoMovimientos>(entity =>
        {
            entity.HasKey(e => e.IdMovimiento);

            entity.ToTable("Nodo_Movimientos");

            entity.Property(e => e.DesdeCamaId).HasColumnName("DesdeCamaID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.HastaCamaId).HasColumnName("HastaCamaID");
            entity.Property(e => e.Motivo).HasMaxLength(500);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.DesdeCama).WithMany(p => p.NodoMovimientosDesdeCama)
                .HasForeignKey(d => d.DesdeCamaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nodo_Movimientos_Camas");

            entity.HasOne(d => d.HastaCama).WithMany(p => p.NodoMovimientosHastaCama)
                .HasForeignKey(d => d.HastaCamaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nodo_Movimientos_Camas1");
        });

        modelBuilder.Entity<NodoNotificacion>(entity =>
        {
            entity.HasKey(e => e.IdNotificacion);

            entity.ToTable("Nodo_Notificacion");

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaRevisa).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioRevisa)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NodoPacienteEstado>(entity =>
        {
            entity.ToTable("Nodo_PacienteEstado");

            entity.Property(e => e.NodoPacienteEstadoId).HasColumnName("Nodo_PacienteEstadoID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NodoRegistroEnvioEmail>(entity =>
        {
            entity.HasKey(e => e.NodoRegistroEnviosEmailId);

            entity.Property(e => e.NodoRegistroEnviosEmailId).HasColumnName("NodoRegistroEnviosEmailID");
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaRealiza).HasColumnType("datetime");
            entity.Property(e => e.OpRealiza)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NodoTipos>(entity =>
        {
            entity.HasKey(e => e.NodoTipoId).HasName("PK_NodoSector");

            entity.Property(e => e.NodoTipoId).HasColumnName("NodoTipoID");
            entity.Property(e => e.Detalle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nododepartamentos>(entity =>
        {
            entity.HasKey(e => e.DepartamentoId).HasName("PK_Departamentos");

            entity.ToTable("NODODepartamentos");

            entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
        });

        modelBuilder.Entity<Nodolocalidades>(entity =>
        {
            entity.HasKey(e => e.LocalidadId);

            entity.ToTable("NODOLocalidades");

            entity.Property(e => e.LocalidadId).HasColumnName("LocalidadID");
            entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");
        });

        modelBuilder.Entity<NomCatLaboratorio>(entity =>
        {
            entity.Property(e => e.NomCatLaboratorioId).HasColumnName("NomCatLaboratorioID");
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(10);
        });

        modelBuilder.Entity<NomExpDetallePagos>(entity =>
        {
            entity.HasKey(e => e.NomExpDetallePagoId);

            entity.Property(e => e.NomExpDetallePagoId).HasColumnName("NomExpDetallePagoID");
            entity.Property(e => e.LoteRegPagoId).HasColumnName("LoteRegPagoID");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NomExpedienteDetalleId).HasColumnName("NomExpedienteDetalleID");
        });

        modelBuilder.Entity<NomExpRegXestado>(entity =>
        {
            entity.ToTable("NomExpRegXEstado");

            entity.Property(e => e.NomExpRegxEstadoId).HasColumnName("NomExpRegxEstadoID");
            entity.Property(e => e.Detalle).HasMaxLength(300);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.NomExpedienteId).HasColumnName("NomExpedienteID");
            entity.Property(e => e.TramiteEstadoId).HasColumnName("TramiteEstadoID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NomExpediente>(entity =>
        {
            entity.Property(e => e.NomExpedienteId).HasColumnName("NomExpedienteID");
            entity.Property(e => e.CodigoRefes)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("CodigoREFES");
            entity.Property(e => e.DiagEgreso).HasMaxLength(150);
            entity.Property(e => e.DiagIngreso).HasMaxLength(150);
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.FechaRechazo).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.ImprimeComprobante).HasColumnType("datetime");
            entity.Property(e => e.ImprimeNotificacion).HasColumnType("datetime");
            entity.Property(e => e.ImprimePlanillaPract).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.LoteId).HasColumnName("LoteID");
            entity.Property(e => e.LoteRegPagoId).HasColumnName("LoteRegPagoID");
            entity.Property(e => e.MotivoRechazo).HasMaxLength(300);
            entity.Property(e => e.Nombre).HasMaxLength(300);
            entity.Property(e => e.NroExpediente)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.ObraSocial).HasMaxLength(150);
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.OpImpComprobante)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpImprimeNotif)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.Prestador).HasMaxLength(150);
            entity.Property(e => e.PrestadorFirmaId).HasColumnName("PrestadorFirmaID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Lote).WithMany(p => p.NomExpediente)
                .HasForeignKey(d => d.LoteId)
                .HasConstraintName("FK_NomExpediente_Lotes");
        });

        modelBuilder.Entity<NomExpedienteDetalle>(entity =>
        {
            entity.HasKey(e => e.NomExpedienteDetalleId).HasName("PK_NomFacturacionRegDetalle");

            entity.Property(e => e.NomExpedienteDetalleId).HasColumnName("NomExpedienteDetalleID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaPractica).HasColumnType("datetime");
            entity.Property(e => e.LoteRegPagoId).HasColumnName("LoteRegPagoID");
            entity.Property(e => e.NomExpedienteId).HasColumnName("NomExpedienteID");
            entity.Property(e => e.NomLaboratorioId).HasColumnName("NomLaboratorioID");
            entity.Property(e => e.NomServicioId).HasColumnName("NomServicioID");
            entity.Property(e => e.NomServicioNombre).HasMaxLength(100);
            entity.Property(e => e.NomencladorId).HasColumnName("NomencladorID");
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.NomServicio).WithMany(p => p.NomExpedienteDetalle)
                .HasForeignKey(d => d.NomServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NomExpedienteDetalle_NomServicios");

            entity.HasOne(d => d.Nomenclador).WithMany(p => p.NomExpedienteDetalle)
                .HasForeignKey(d => d.NomencladorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NomExpedienteDetalle_Nomenclador");
        });

        modelBuilder.Entity<NomListas>(entity =>
        {
            entity.HasKey(e => e.NomListaId);

            entity.Property(e => e.Cod).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<NomServicios>(entity =>
        {
            entity.HasKey(e => e.NomServicioId).HasName("PK_SectorAutoGestion");

            entity.Property(e => e.NomServicioId).HasColumnName("NomServicioID");
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<NomTipoAtencion>(entity =>
        {
            entity.HasKey(e => e.NomTipoAtencionId).HasName("PK_NomTipoAtencionNom");

            entity.Property(e => e.NomTipoAtencionId).HasColumnName("NomTipoAtencionID");
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<Nomenclador>(entity =>
        {
            entity.Property(e => e.Arancel2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Arancel3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Arancel4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Codigos)
                .HasMaxLength(255)
                .HasColumnName("CODIGOS");
            entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.Restriccion).HasMaxLength(255);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nomenclador2>(entity =>
        {
            entity.HasKey(e => e.NomencladorId);

            entity.Property(e => e.Arancel2018).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Arancel3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Arancel4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Codigos)
                .HasMaxLength(255)
                .HasColumnName("CODIGOS");
            entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            entity.Property(e => e.DescripcionNva).HasMaxLength(500);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.Restriccion).HasMaxLength(255);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<NomencladorResolucion>(entity =>
        {
            entity.Property(e => e.NomencladorResolucionId).HasColumnName("NomencladorResolucionID");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Nomenclador).WithMany(p => p.NomencladorResolucion)
                .HasForeignKey(d => d.NomencladorId)
                .HasConstraintName("FK_NomencladorResolucion_Nomenclador");
        });

        modelBuilder.Entity<NotaPedido>(entity =>
        {
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.DirigidaA)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.MedioCompraId).HasColumnName("MedioCompraID");
            entity.Property(e => e.NotaPedidoEstadoId).HasColumnName("NotaPedidoEstadoID");
            entity.Property(e => e.NotaPedidoPresupuestoIdganador).HasColumnName("NotaPedido_PresupuestoIDGanador");
            entity.Property(e => e.NroAsunto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NroExpediente)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PedidoLugarEntregaId).HasColumnName("Pedido_LugarEntregaID");
            entity.Property(e => e.PrecioEstimadoTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PresupuestoMotivoGanadorId).HasColumnName("Presupuesto_MotivoGanadorID");
            entity.Property(e => e.RefExpediente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.MedioCompra).WithMany(p => p.NotaPedido)
                .HasForeignKey(d => d.MedioCompraId)
                .HasConstraintName("FK_NotaPedido_MedioCompra");

            entity.HasOne(d => d.NotaPedidoEstado).WithMany(p => p.NotaPedido)
                .HasForeignKey(d => d.NotaPedidoEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedido_NotaPedidoEstado");

            entity.HasOne(d => d.PedidoLugarEntrega).WithMany(p => p.NotaPedido)
                .HasForeignKey(d => d.PedidoLugarEntregaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedido_Pedido_LugarEntrega1");

            entity.HasOne(d => d.PresupuestoMotivoGanador).WithMany(p => p.NotaPedido)
                .HasForeignKey(d => d.PresupuestoMotivoGanadorId)
                .HasConstraintName("FK_NotaPedido_Presupuesto_MotivoGanador");
        });

        modelBuilder.Entity<NotaPedidoDetalle>(entity =>
        {
            entity.Property(e => e.NotaPedidoDetalleId).HasColumnName("NotaPedidoDetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.CantidadAutorizada).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.PedidoInternoDetalleId).HasColumnName("PedidoInterno_DetalleID");
            entity.Property(e => e.PrecioUnitarioEstimado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.NotaPedido).WithMany(p => p.NotaPedidoDetalle)
                .HasForeignKey(d => d.NotaPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedidoDetalle_NotaPedido");

            entity.HasOne(d => d.PedidoInternoDetalle).WithMany(p => p.NotaPedidoDetalle)
                .HasForeignKey(d => d.PedidoInternoDetalleId)
                .HasConstraintName("FK_NotaPedidoDetalle_PedidoInterno_Detalle");
        });

        modelBuilder.Entity<NotaPedidoEstado>(entity =>
        {
            entity.Property(e => e.NotaPedidoEstadoId).HasColumnName("NotaPedidoEstadoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NotaPedidoEstadoHistorico>(entity =>
        {
            entity.Property(e => e.NotaPedidoEstadoHistoricoId).HasColumnName("NotaPedidoEstadoHistoricoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NotaPedidoEstadoId).HasColumnName("NotaPedidoEstadoID");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.NotaPedidoEstado).WithMany(p => p.NotaPedidoEstadoHistorico)
                .HasForeignKey(d => d.NotaPedidoEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedidoEstadoHistorico_NotaPedidoEstado");

            entity.HasOne(d => d.NotaPedido).WithMany(p => p.NotaPedidoEstadoHistorico)
                .HasForeignKey(d => d.NotaPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedidoEstadoHistorico_NotaPedido");
        });

        modelBuilder.Entity<NotaPedidoPresupuesto>(entity =>
        {
            entity.ToTable("NotaPedido_Presupuesto");

            entity.Property(e => e.NotaPedidoPresupuestoId).HasColumnName("NotaPedido_PresupuestoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModi).HasColumnType("datetime");
            entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.OpCrea).HasMaxLength(11);
            entity.Property(e => e.OpModi).HasMaxLength(11);
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

            entity.HasOne(d => d.NotaPedido).WithMany(p => p.NotaPedidoPresupuesto)
                .HasForeignKey(d => d.NotaPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedido_Presupuesto_NotaPedido");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.NotaPedidoPresupuesto)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedido_Presupuesto_Proveedores1");
        });

        modelBuilder.Entity<NotaPedidoPresupuestoDetalle>(entity =>
        {
            entity.ToTable("NotaPedido_PresupuestoDetalle");

            entity.Property(e => e.NotaPedidoPresupuestoDetalleId).HasColumnName("NotaPedido_PresupuestoDetalleID");
            entity.Property(e => e.NotaPedidoDetalleId).HasColumnName("NotaPedidoDetalleID");
            entity.Property(e => e.NotaPedidoPresupuestoId).HasColumnName("NotaPedido_PresupuestoID");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.NotaPedidoDetalle).WithMany(p => p.NotaPedidoPresupuestoDetalle)
                .HasForeignKey(d => d.NotaPedidoDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedido_PresupuestoDetalle_NotaPedidoDetalle");

            entity.HasOne(d => d.NotaPedidoPresupuesto).WithMany(p => p.NotaPedidoPresupuestoDetalle)
                .HasForeignKey(d => d.NotaPedidoPresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotaPedido_PresupuestoDetalle_NotaPedido_Presupuesto");
        });

        modelBuilder.Entity<NotificacionCovidResidencia>(entity =>
        {
            entity.Property(e => e.NotificacionCovidResidenciaId).HasColumnName("NotificacionCovidResidenciaID");
            entity.Property(e => e.Barrio).HasMaxLength(50);
            entity.Property(e => e.CalleManzana).HasMaxLength(100);
            entity.Property(e => e.CodigoPostal).HasMaxLength(7);
            entity.Property(e => e.Departamento).HasMaxLength(50);
            entity.Property(e => e.Depto).HasMaxLength(5);
            entity.Property(e => e.Localidad).HasMaxLength(100);
            entity.Property(e => e.NotificacionId).HasColumnName("NotificacionID");
            entity.Property(e => e.NumeroCasa).HasMaxLength(5);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.Piso).HasMaxLength(3);
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.Notificacion).WithMany(p => p.NotificacionCovidResidencia)
                .HasForeignKey(d => d.NotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacionCovidResidencia_NotificacionesCovid");

            entity.HasOne(d => d.Paciente).WithMany(p => p.NotificacionCovidResidencia)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacionCovidResidencia_Pacientes");

            entity.HasOne(d => d.Provincia).WithMany(p => p.NotificacionCovidResidencia)
                .HasForeignKey(d => d.ProvinciaId)
                .HasConstraintName("FK_NotificacionCovidResidencia_Provincias");
        });

        modelBuilder.Entity<NotificacionDengue>(entity =>
        {
            entity.HasKey(e => e.NotiDengueId).HasName("PK__Notifica__50D3651505768DCE");

            entity.Property(e => e.NotiDengueId).HasColumnName("NotiDengueID");
            entity.Property(e => e.AltGpt)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ALT_GPT");
            entity.Property(e => e.AnoDengue)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AstGot)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("AST_GOT");
            entity.Property(e => e.Basofilos)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CalleDomicilio)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.CasoSimilarQuien)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Chikungunya)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.ContactoAnimalCual)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Creatinina)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Dcsa).HasColumnName("DCSA");
            entity.Property(e => e.Dengue)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.DepartamentoResidencia)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.DeptoDomicilio)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.DestinoViaje)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.DetalleOtroTratamiento)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.Dg).HasColumnName("DG");
            entity.Property(e => e.DosisDengue)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Dssa).HasColumnName("DSSA");
            entity.Property(e => e.Edad)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.EncefalitisEquinaOeste)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EncefalitisSanLuis)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EnfermedadZika)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Eosinofilos)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EsCampoLugar)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Establecimiento)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.EstablecimientoConsulta)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EstablecimientoInternacion)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EstablecimientoTomaMuestra)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Etnia)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Fal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FAL");
            entity.Property(e => e.Fallecido)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FechaArm).HasColumnName("FechaARM");
            entity.Property(e => e.FechaInicioFiebre)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaInternacionUti).HasColumnName("FechaInternacionUTI");
            entity.Property(e => e.FechaNacimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaNotificacion).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaVacAntiamarillica).HasColumnName("Fecha_VacAntiamarillica");
            entity.Property(e => e.FechaVacDengue).HasColumnName("Fecha_VacDengue");
            entity.Property(e => e.FechaVacFiebreHa).HasColumnName("Fecha_VacFiebreHA");
            entity.Property(e => e.FechaVacLeptospirosis).HasColumnName("Fecha_VacLeptospirosis");
            entity.Property(e => e.FiebreAmarilla)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FiebreHemorrArgentina)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FiebreNiloOccidental)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Gb)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("GB");
            entity.Property(e => e.Genero)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.GuardiaId).HasColumnName("GuardiaID");
            entity.Property(e => e.Hantavirus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Hto)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ImportadoDepto)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ImportadoLoc)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ImportadoPais)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ImportadoProv)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Lcr).HasColumnName("LCR");
            entity.Property(e => e.Leptospirosis)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Linfocitos)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LocalidadMonitoreo)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("localidadMonitoreo");
            entity.Property(e => e.LocalidadResidencia)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.MedicoTratante)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Monocitos)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Neutrofilos)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NombreNotificador)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.NombrePaciente)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.NumeroDomicilio)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Otra)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.OtraEnf)
                .HasMaxLength(150)
                .IsFixedLength();
            entity.Property(e => e.OtroSospecha)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OtroTratamientoPrevio)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OtrosEspecificar)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.Paludismo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PisoDomicilio)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Plaquetas)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Provincia)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.ProvinciaResidencia)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.PuebloIndigena).HasDefaultValueSql("('')");
            entity.Property(e => e.RequerimientoArm)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("RequerimientoARM");
            entity.Property(e => e.Rickettsiosis)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Rxtorax)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RXTorax");
            entity.Property(e => e.SexoAlNacer)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.SexoLegal)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.TelefonoMedicoTratante)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TelefonoPac)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.TerapiaIntensiva)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TipoAtencion)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TipoCampo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TipoCaso)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.TipoLaboralId).HasColumnName("TipoLaboralID");
            entity.Property(e => e.TratPrevio)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.Urea)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioImprime)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.VacFiebreHa).HasColumnName("VacFiebreHA");
            entity.Property(e => e.Vsg)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VSG");

            entity.HasOne(d => d.Paciente).WithMany(p => p.NotificacionDengue)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PacienteID");
        });

        modelBuilder.Entity<NotificacionesCovid>(entity =>
        {
            entity.HasKey(e => e.NotificacionId);

            entity.Property(e => e.NotificacionId).HasColumnName("NotificacionID");
            entity.Property(e => e.Arm).HasColumnName("ARM");
            entity.Property(e => e.Dnisecc)
                .HasMaxLength(20)
                .HasColumnName("DNISECC");
            entity.Property(e => e.Dnisecnc)
                .HasMaxLength(20)
                .HasColumnName("DNISECNC");
            entity.Property(e => e.Epoc).HasColumnName("EPOC");
            entity.Property(e => e.EstabDerivaMuestra).HasMaxLength(100);
            entity.Property(e => e.EstabMuestra).HasMaxLength(100);
            entity.Property(e => e.EstabPrimeraConsulta).HasMaxLength(100);
            entity.Property(e => e.Eti).HasColumnName("ETI");
            entity.Property(e => e.EtniaId).HasColumnName("EtniaID");
            entity.Property(e => e.EventoId)
                .HasMaxLength(20)
                .HasColumnName("EventoID");
            entity.Property(e => e.FechaArm).HasColumnName("FechaARM");
            entity.Property(e => e.FechaZre).HasColumnName("FechaZRE");
            entity.Property(e => e.FechaZrp).HasColumnName("FechaZRP");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InstitucionInternacion).HasMaxLength(100);
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Irag).HasColumnName("IRAG");
            entity.Property(e => e.LugarZre)
                .HasMaxLength(100)
                .HasColumnName("LugarZRE");
            entity.Property(e => e.LugarZrp)
                .HasMaxLength(100)
                .HasColumnName("LugarZRP");
            entity.Property(e => e.MotivoAnula).HasMaxLength(100);
            entity.Property(e => e.Nac).HasColumnName("NAC");
            entity.Property(e => e.NombreInsScep)
                .HasMaxLength(100)
                .HasColumnName("NombreInsSCEP");
            entity.Property(e => e.NombreSca)
                .HasMaxLength(100)
                .HasColumnName("NombreSCA");
            entity.Property(e => e.NombreSecc)
                .HasMaxLength(100)
                .HasColumnName("NombreSECC");
            entity.Property(e => e.NombreSecnc)
                .HasMaxLength(100)
                .HasColumnName("NombreSECNC");
            entity.Property(e => e.ObservacionesAnula).HasMaxLength(100);
            entity.Property(e => e.ObservacionesEnfPrev).HasMaxLength(100);
            entity.Property(e => e.ObservacionesEstrechos).HasMaxLength(100);
            entity.Property(e => e.OtraMuestra).HasMaxLength(100);
            entity.Property(e => e.OtrasComorb).HasMaxLength(100);
            entity.Property(e => e.OtrasEnfPrevias).HasMaxLength(100);
            entity.Property(e => e.OtroLugarFallecimiento).HasMaxLength(100);
            entity.Property(e => e.OtrosSintomas).HasMaxLength(100);
            entity.Property(e => e.OtrosTratamientos).HasMaxLength(100);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.ResidenteInsScep).HasColumnName("ResidenteInsSCEP");
            entity.Property(e => e.SemanaEpidemFis).HasColumnName("SemanaEpidemFIS");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioImprime)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioNotifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Etnia).WithMany(p => p.NotificacionesCovid)
                .HasForeignKey(d => d.EtniaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacionesCovid_Tipo_Etnia");

            entity.HasOne(d => d.Institucion).WithMany(p => p.NotificacionesCovid)
                .HasForeignKey(d => d.InstitucionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacionesCovid_Instituciones");

            entity.HasOne(d => d.Paciente).WithMany(p => p.NotificacionesCovid)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacionesCovid_Pacientes");
        });

        modelBuilder.Entity<NumeradorHc>(entity =>
        {
            entity.HasKey(e => e.NumeradorId);

            entity.ToTable("Numerador_HC");

            entity.HasIndex(e => e.PacienteId, "_dta_index_Numerador_HC_6_1591728773__K2_1_3_5_6");

            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Numero)
                .HasMaxLength(8)
                .IsFixedLength();

            entity.HasOne(d => d.Paciente).WithMany(p => p.NumeradorHc)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Numerador_HC_Pacientes");
        });

        modelBuilder.Entity<ObraSocial>(entity =>
        {
            entity.HasKey(e => e.ObraSocialId).HasName("PK_ObraSocial_1");

            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Codigo_Postal");
            entity.Property(e => e.CondIva).HasMaxLength(200);
            entity.Property(e => e.Cuit).HasMaxLength(50);
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.EsArt).HasColumnName("EsART");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.IdLocalidad).HasDefaultValue(1);
            entity.Property(e => e.Localidad)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.NombrePuco).HasMaxLength(250);
            entity.Property(e => e.ObraSocialIdhc).HasColumnName("ObraSocialIDHC");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Rnos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sigla)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TituloInforme).HasMaxLength(100);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<Observaciones>(entity =>
        {
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Persona).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Observaciones_Personas");
        });

        modelBuilder.Entity<ObservacionesVarias>(entity =>
        {
            entity.Property(e => e.ObservacionesVariasId).HasColumnName("ObservacionesVariasID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.GuardiaRegistroId).HasColumnName("GuardiaRegistroID");
            entity.Property(e => e.GuardiaSectorId).HasColumnName("GuardiaSectorID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Ocupacion>(entity =>
        {
            entity.Property(e => e.OcupacionId).HasColumnName("OcupacionID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Odontograma>(entity =>
        {
            entity.HasKey(e => e.IdOdontograma);

            entity.Property(e => e.Cara)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");
            entity.Property(e => e.FechaTratamiento).HasColumnType("datetime");
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Odontograma)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Odontograma_Pacientes");

            entity.HasOne(d => d.IdTratamientoOdontologicoNavigation).WithMany(p => p.Odontograma)
                .HasForeignKey(d => d.IdTratamientoOdontologico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Odontograma_Prestaciones_Odontologicas");
        });

        modelBuilder.Entity<Oftalmologia>(entity =>
        {
            entity.Property(e => e.OftalmologiaId).HasColumnName("OftalmologiaID");
            entity.Property(e => e.AgudezaVisualDcc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualDCC");
            entity.Property(e => e.AgudezaVisualDce)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualDCE");
            entity.Property(e => e.AgudezaVisualDcsc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualDCSC");
            entity.Property(e => e.AgudezaVisualDsc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualDSC");
            entity.Property(e => e.AgudezaVisualIcc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualICC");
            entity.Property(e => e.AgudezaVisualIce)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualICE");
            entity.Property(e => e.AgudezaVisualIcsc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualICSC");
            entity.Property(e => e.AgudezaVisualIsc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("AgudezaVisualISC");
            entity.Property(e => e.BielchowskyD)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.BielchowskyI)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.BielchowskyObs)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CicloplegiaOd)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("CicloplegiaOD");
            entity.Property(e => e.CicloplegiaOi)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("CicloplegiaOI");
            entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");
            entity.Property(e => e.EstrabismoIc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoIC");
            entity.Property(e => e.EstrabismoId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoID");
            entity.Property(e => e.EstrabismoIi)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoII");
            entity.Property(e => e.EstrabismoMcd)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoMCD");
            entity.Property(e => e.EstrabismoMci)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoMCI");
            entity.Property(e => e.EstrabismoMd)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoMD");
            entity.Property(e => e.EstrabismoMi)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoMI");
            entity.Property(e => e.EstrabismoSc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoSC");
            entity.Property(e => e.EstrabismoSd)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoSD");
            entity.Property(e => e.EstrabismoSi)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EstrabismoSI");
            entity.Property(e => e.Motivo)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.ObsBiomicroscopia)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.ObsEstrabismo)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.ObsFondoOjo)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.ObsImagenBiomicroscopia)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.ObsImagenFondoOjo)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.PresionIntraOcularOder)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("PresionIntraOcularODer");
            entity.Property(e => e.PresionIntraOcularOizq)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("PresionIntraOcularOIzq");
            entity.Property(e => e.RcercaDerechoCil)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RCercaDerechoCil");
            entity.Property(e => e.RcercaDerechoEje)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RCercaDerechoEje");
            entity.Property(e => e.RcercaDerechoEsf)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RCercaDerechoEsf");
            entity.Property(e => e.RcercaizquierdoCil)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RCercaizquierdoCil");
            entity.Property(e => e.RcercaizquierdoEje)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RCercaizquierdoEje");
            entity.Property(e => e.RcercaizquierdoEsf)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RCercaizquierdoEsf");
            entity.Property(e => e.RefOd)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RefOD");
            entity.Property(e => e.RefOi)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RefOI");
            entity.Property(e => e.RefResumen)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.RlejosDerechoCil)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RLejosDerechoCil");
            entity.Property(e => e.RlejosDerechoEje)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RLejosDerechoEje");
            entity.Property(e => e.RlejosDerechoEsf)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RLejosDerechoEsf");
            entity.Property(e => e.RlejosIzquierdoCil)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RLejosIzquierdoCil");
            entity.Property(e => e.RlejosIzquierdoEje)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RLejosIzquierdoEje");
            entity.Property(e => e.RlejosIzquierdoEsf)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RLejosIzquierdoEsf");
            entity.Property(e => e.RutaImagenBiomicroscopia)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.RutaImagenEstrabismo)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.RutaImagenFondoOjo)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.TestAmsler)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.VisionCercana)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.VisionCromatica)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrdenCompra>(entity =>
        {
            entity.Property(e => e.OrdenCompraId).HasColumnName("OrdenCompraID");
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.NotaPedidoPresupuestoId).HasColumnName("NotaPedido_PresupuestoID");
            entity.Property(e => e.OrdenCompraEstadoId).HasColumnName("OrdenCompraEstadoID");

            entity.HasOne(d => d.NotaPedido).WithMany(p => p.OrdenCompra)
                .HasForeignKey(d => d.NotaPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_NotaPedido");

            entity.HasOne(d => d.OrdenCompraEstado).WithMany(p => p.OrdenCompra)
                .HasForeignKey(d => d.OrdenCompraEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_OrdenCompraEstado");
        });

        modelBuilder.Entity<OrdenCompraAutorizaRecepParcial>(entity =>
        {
            entity.HasKey(e => e.OrdenCompraAutorizaRecepParcialId).HasName("PK_OrdenCompra_AutorizaRecepParcial");

            entity.Property(e => e.OrdenCompraAutorizaRecepParcialId).HasColumnName("OrdenCompraAutorizaRecepParcialID");
            entity.Property(e => e.FechaRecepciona).HasColumnType("datetime");
            entity.Property(e => e.FechaResuelve).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicita).HasColumnType("datetime");
            entity.Property(e => e.OrdenCompraId).HasColumnName("OrdenCompraID");
            entity.Property(e => e.UsuarioRecepciona)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioResuelve)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioSolicita)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrdenCompraEstado>(entity =>
        {
            entity.Property(e => e.OrdenCompraEstadoId).HasColumnName("OrdenCompraEstadoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenCompraEstadoHistorico>(entity =>
        {
            entity.Property(e => e.OrdenCompraEstadoHistoricoId).HasColumnName("OrdenCompraEstadoHistoricoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.OrdenCompraEstadoId).HasColumnName("OrdenCompraEstadoID");
            entity.Property(e => e.OrdenCompraId).HasColumnName("OrdenCompraID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.OrdenCompraEstado).WithMany(p => p.OrdenCompraEstadoHistorico)
                .HasForeignKey(d => d.OrdenCompraEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraEstadoHistorico_OrdenCompraEstado");

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.OrdenCompraEstadoHistorico)
                .HasForeignKey(d => d.OrdenCompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraEstadoHistorico_OrdenCompra");
        });

        modelBuilder.Entity<OrdenCompraRecepcion>(entity =>
        {
            entity.HasKey(e => e.OrdenCompraRecepcionId).HasName("PK_OrdenCompra_Recepcion");

            entity.Property(e => e.OrdenCompraRecepcionId).HasColumnName("OrdenCompraRecepcionID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.OrdenCompraId).HasColumnName("OrdenCompraID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.OrdenCompraRecepcion)
                .HasForeignKey(d => d.OrdenCompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_Recepcion_OrdenCompra");
        });

        modelBuilder.Entity<OrdenCompraRecepcionDetalle>(entity =>
        {
            entity.HasKey(e => e.OrdenCompraRecepcionDetalleId).HasName("PK_OrdenCompra_RecepcionDetalle");

            entity.Property(e => e.OrdenCompraRecepcionDetalleId).HasColumnName("OrdenCompraRecepcionDetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.OrdenCompraRecepcionId).HasColumnName("OrdenCompraRecepcionID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.OrdenCompraRecepcion).WithMany(p => p.OrdenCompraRecepcionDetalle)
                .HasForeignKey(d => d.OrdenCompraRecepcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_RecepcionDetalle_OrdenCompra_Recepcion");
        });

        modelBuilder.Entity<OrdenLaboratorioPracticas>(entity =>
        {
            entity.HasKey(e => e.OrdenLabPracticasId).HasName("PK_OrdenLaboratorioPracticas_1");

            entity.Property(e => e.OrdenLabPracticasId).HasColumnName("OrdenLabPracticasID");
            entity.Property(e => e.LaboratorioPracticasId).HasColumnName("LaboratorioPracticasID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrdenPago>(entity =>
        {
            entity.Property(e => e.OrdenPagoId).HasColumnName("OrdenPagoID");
            entity.Property(e => e.CuentaBancariaId).HasColumnName("CuentaBancariaID");
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FondoPermanenteId).HasColumnName("FondoPermanenteID");
            entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NroExpediente)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.OrdenCompraId).HasColumnName("OrdenCompraID");
            entity.Property(e => e.OrdenPagoEstadoId).HasColumnName("OrdenPagoEstadoID");
            entity.Property(e => e.PresupuestoResolucionId).HasColumnName("PresupuestoResolucionID");
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.CuentaBancaria).WithMany(p => p.OrdenPago)
                .HasForeignKey(d => d.CuentaBancariaId)
                .HasConstraintName("FK_OrdenPago_CuentaBancaria");

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.OrdenPago)
                .HasForeignKey(d => d.OrdenCompraId)
                .HasConstraintName("FK_OrdenPago_OrdenCompra");

            entity.HasOne(d => d.OrdenPagoEstado).WithMany(p => p.OrdenPago)
                .HasForeignKey(d => d.OrdenPagoEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenPago_OrdenPagoEstado");
        });

        modelBuilder.Entity<OrdenPagoAsiento>(entity =>
        {
            entity.Property(e => e.OrdenPagoAsientoId).HasColumnName("OrdenPagoAsientoID");
            entity.Property(e => e.ImportePartida).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrdenPagoId).HasColumnName("OrdenPagoID");
            entity.Property(e => e.PresupuestoAnualDetalleId).HasColumnName("PresupuestoAnualDetalleID");

            entity.HasOne(d => d.OrdenPago).WithMany(p => p.OrdenPagoAsiento)
                .HasForeignKey(d => d.OrdenPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenPagoAsiento_OrdenPago");
        });

        modelBuilder.Entity<OrdenPagoDetalle>(entity =>
        {
            entity.Property(e => e.OrdenPagoDetalleId).HasColumnName("OrdenPagoDetalleID");
            entity.Property(e => e.ConceptoRetencion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NroCheque)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NroTransaccion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrdenPagoId).HasColumnName("OrdenPagoID");
            entity.Property(e => e.OrdenPagoRetencionesId).HasColumnName("OrdenPagoRetencionesID");
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

            entity.HasOne(d => d.OrdenPago).WithMany(p => p.OrdenPagoDetalle)
                .HasForeignKey(d => d.OrdenPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenPagoDetalle_OrdenPago");

            entity.HasOne(d => d.OrdenPagoRetenciones).WithMany(p => p.OrdenPagoDetalle)
                .HasForeignKey(d => d.OrdenPagoRetencionesId)
                .HasConstraintName("FK_OrdenPagoDetalle_OrdenPagoRetenciones");
        });

        modelBuilder.Entity<OrdenPagoEstado>(entity =>
        {
            entity.Property(e => e.OrdenPagoEstadoId).HasColumnName("OrdenPagoEstadoID");
            entity.Property(e => e.Descipcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenPagoEstadoHistorico>(entity =>
        {
            entity.Property(e => e.OrdenPagoEstadoHistoricoId).HasColumnName("OrdenPagoEstadoHistoricoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.OrdenPagoEstadoId).HasColumnName("OrdenPagoEstadoID");
            entity.Property(e => e.OrdenPagoId).HasColumnName("OrdenPagoID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.OrdenPagoEstado).WithMany(p => p.OrdenPagoEstadoHistorico)
                .HasForeignKey(d => d.OrdenPagoEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenPagoEstadoHistorico_OrdenPagoEstado");

            entity.HasOne(d => d.OrdenPago).WithMany(p => p.OrdenPagoEstadoHistorico)
                .HasForeignKey(d => d.OrdenPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenPagoEstadoHistorico_OrdenPago");
        });

        modelBuilder.Entity<OrdenPagoRetenciones>(entity =>
        {
            entity.Property(e => e.OrdenPagoRetencionesId).HasColumnName("OrdenPagoRetencionesID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrientacionDeriva>(entity =>
        {
            entity.Property(e => e.OrientacionDerivaId).HasColumnName("OrientacionDerivaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrientacionObstetrica>(entity =>
        {
            entity.Property(e => e.OrientacionObstetricaId).HasColumnName("OrientacionObstetricaID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.OrientacionDerivaId).HasColumnName("OrientacionDerivaID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.OrientacionDeriva).WithMany(p => p.OrientacionObstetrica)
                .HasForeignKey(d => d.OrientacionDerivaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrientacionObstetrica_OrientacionDeriva");

            entity.HasOne(d => d.Paciente).WithMany(p => p.OrientacionObstetrica)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrientacionObstetrica_Pacientes");
        });

        modelBuilder.Entity<OrientacionObstetricaFormulario>(entity =>
        {
            entity.HasKey(e => e.FormularioId);

            entity.Property(e => e.FormularioId).HasColumnName("FormularioID");
            entity.Property(e => e.DiabetesMi).HasColumnName("DiabetesMI");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.IsoInmunizacionRhn).HasColumnName("IsoInmunizacionRHN");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrigenEstado>(entity =>
        {
            entity.Property(e => e.OrigenEstadoId).HasColumnName("OrigenEstadoID");
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<OtrosCentros>(entity =>
        {
            entity.ToTable("Otros_Centros");

            entity.Property(e => e.OtrosCentrosId).HasColumnName("OtrosCentrosID");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Telefonos)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("WEB");
        });

        modelBuilder.Entity<PacienteAntecedentes>(entity =>
        {
            entity.HasKey(e => e.PacienteAntecedenteId);

            entity.Property(e => e.PacienteAntecedenteId).HasColumnName("PacienteAntecedenteID");
            entity.Property(e => e.AdiccionDrogasIlicitasFliar).HasMaxLength(50);
            entity.Property(e => e.AdiccionDrogasIlicitasPers).HasMaxLength(50);
            entity.Property(e => e.AlcoholismoFliar).HasMaxLength(50);
            entity.Property(e => e.AlcoholismoPers).HasMaxLength(50);
            entity.Property(e => e.AlergiasFliar).HasMaxLength(50);
            entity.Property(e => e.AlergiasPers).HasMaxLength(50);
            entity.Property(e => e.DiabetesFliar).HasMaxLength(50);
            entity.Property(e => e.DiabetesPers).HasMaxLength(50);
            entity.Property(e => e.EnfermedadCardVascFliar).HasMaxLength(50);
            entity.Property(e => e.EnfermedadCardVascPers).HasMaxLength(50);
            entity.Property(e => e.EnfermedadRenalCronicaFliar).HasMaxLength(50);
            entity.Property(e => e.EnfermedadRenalCronicaPers).HasMaxLength(50);
            entity.Property(e => e.EpocasmaFliar)
                .HasMaxLength(50)
                .HasColumnName("EPOCAsmaFliar");
            entity.Property(e => e.EpocasmaPers)
                .HasMaxLength(50)
                .HasColumnName("EPOCAsmaPers");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.InmunocomprometidoFliar).HasMaxLength(50);
            entity.Property(e => e.InmunocomprometidoPers).HasMaxLength(50);
            entity.Property(e => e.ObesidadMorbidaFliar).HasMaxLength(50);
            entity.Property(e => e.ObesidadMorbidaPers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtroFliar).HasMaxLength(50);
            entity.Property(e => e.OtroPers).HasMaxLength(50);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.ProbPsicPsiqFliar).HasMaxLength(50);
            entity.Property(e => e.ProbPsicPsiqPers).HasMaxLength(50);
            entity.Property(e => e.RenalCronicaFliar).HasMaxLength(50);
            entity.Property(e => e.RenalCronicaPers).HasMaxLength(50);
            entity.Property(e => e.TabaquismoFliar).HasMaxLength(50);
            entity.Property(e => e.TabaquismoPers).HasMaxLength(50);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.ViolenciaFliar).HasMaxLength(50);
            entity.Property(e => e.ViolenciaPers).HasMaxLength(50);
        });

        modelBuilder.Entity<PacienteEstado>(entity =>
        {
            entity.Property(e => e.PacienteEstadoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PacienteEstadoID");
            entity.Property(e => e.EstadoId).HasColumnName("EstadoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.OrigenEstadoId).HasColumnName("OrigenEstadoID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.OrigenEstado).WithMany(p => p.PacienteEstado)
                .HasForeignKey(d => d.OrigenEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PacienteEstado_OrigenEstado");

            entity.HasOne(d => d.PacienteEstadoNavigation).WithOne(p => p.PacienteEstado)
                .HasForeignKey<PacienteEstado>(d => d.PacienteEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PacienteEstado_Pacientes");
        });

        modelBuilder.Entity<PacienteExtraInfo>(entity =>
        {
            entity.HasKey(e => e.PacienteExtraId);

            entity.Property(e => e.PacienteExtraId).HasColumnName("PacienteExtraID");
            entity.Property(e => e.LecturaOcr).HasColumnName("Lectura_OCR");
            entity.Property(e => e.TurnosId).HasColumnName("TurnosID");
        });

        modelBuilder.Entity<PacienteFotos>(entity =>
        {
            entity.Property(e => e.PacienteFotosId).HasColumnName("PacienteFotosID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.TipoImagenId).HasColumnName("TipoImagenID");
            entity.Property(e => e.UrlImagen).HasMaxLength(500);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.TipoImagen).WithMany(p => p.PacienteFotos)
                .HasForeignKey(d => d.TipoImagenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PacienteFotos_TipoImagen");
        });

        modelBuilder.Entity<PacientePrevencionPromocion>(entity =>
        {
            entity.HasKey(e => e.PacientePrevPromId);

            entity.Property(e => e.PacientePrevPromId).HasColumnName("PacientePrevPromID");
            entity.Property(e => e.ActividadFisica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlcoholismoCriticaFormaBeber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlcoholismoCulpableFormaDeBeber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlcoholismoImpresionDejarDeBeber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlcoholismoPrimeroEnLaMañana)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlimentacionSaludable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControlDislipemiaMas1Anio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControlDislipemiaMenos1Anio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControlDislipemiaNsnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ControlDislipemiaNSNC");
            entity.Property(e => e.ControlDislipemiaNunca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControlGlucemiaMas1anio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControlGlucemiaMenos1anio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControlGlucemiaNsnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ControlGlucemiaNSNC");
            entity.Property(e => e.ControlGlucemiaNunca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Fuma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FumaDispuestoDejar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObesidadImcmay30)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ObesidadIMCMay30");
            entity.Property(e => e.ObservacionesPp).HasColumnName("ObservacionesPP");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.RastreoHta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RastreoHTA");
            entity.Property(e => e.ResulUltimoPapna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ResulUltimoPAPNA");
            entity.Property(e => e.ResulUltimoPapnormal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ResulUltimoPAPNormal");
            entity.Property(e => e.ResultadoGlucemiaAnormal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoGlucemiaDbt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ResultadoGlucemiaDBT");
            entity.Property(e => e.ResultadoGlucemiaNormal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoLipidicoAnormal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoLipidicoNormal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoMamografiaNa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ResultadoMamografiaNA");
            entity.Property(e => e.ResultadoMamografiaNormal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoSomfna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ResultadoSOMFNA");
            entity.Property(e => e.ResultadoSomfnormal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ResultadoSOMFNormal");
            entity.Property(e => e.UltimaMamografiaMenos1anio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimaMamografiaNoAplica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimaMamografiaNsnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimaMamografiaNSNC");
            entity.Property(e => e.UltimaMamografiaNunca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimaMamografiamas1anio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimoPapmas1anio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoPAPMas1anio");
            entity.Property(e => e.UltimoPapmenos1anio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoPAPMenos1anio");
            entity.Property(e => e.UltimoPapnoAplica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoPAPNoAplica");
            entity.Property(e => e.UltimoPapnsnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoPAPNSNC");
            entity.Property(e => e.UltimoPapnunca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoPAPNunca");
            entity.Property(e => e.UltimoSomfmas1Anio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoSOMFMas1Anio");
            entity.Property(e => e.UltimoSomfmenos1anio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoSOMFMenos1anio");
            entity.Property(e => e.UltimoSomfnoAplica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoSOMFNoAplica");
            entity.Property(e => e.UltimoSomfnsnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoSOMFNSNC");
            entity.Property(e => e.UltimoSomfnunca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UltimoSOMFNunca");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.VacunaAntigripal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VacunaContraHb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VacunaContraHB");
            entity.Property(e => e.VacunaDobleBacteriana)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VacunaOtra)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PacienteSitSocioEconomica>(entity =>
        {
            entity.Property(e => e.PacienteSitSocioEconomicaId).HasColumnName("PacienteSitSocioEconomicaID");
            entity.Property(e => e.AmigosCompanieros)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Casa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comorbilidades)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConvivienteOtro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");
            entity.Property(e => e.DomNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomNsnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DomNSNC");
            entity.Property(e => e.DomOtro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomSi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Embarazada)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.IngresoOtro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Inquilinto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocalidadId).HasColumnName("LocalidadID");
            entity.Property(e => e.Mayores60)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesSe).HasColumnName("ObservacionesSE");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.ParteFliaConv)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
            entity.Property(e => e.Solo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoRancho)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoViviendaOtro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TodaFliaConv)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Pacientes>(entity =>
        {
            entity.HasKey(e => e.PacienteId);

            entity.ToTable(tb => tb.HasTrigger("Tr_EdicionPacientesInternadosHCWeb"));

            entity.HasIndex(e => e.Anulado, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => e.DocReferencia, "IndexDniReferencia");

            entity.HasIndex(e => e.Anulado, "IndexPSearch");

            entity.HasIndex(e => new { e.Documento, e.Anulado }, "PIndex_NewSearch");

            entity.HasIndex(e => new { e.PacienteId, e.Documento, e.DocReferencia, e.Nombre }, "_dta_index_Pacientes_6_593437188__K1_K4_K14_K5");

            entity.HasIndex(e => e.Anulado, "_dta_index_Pacientes_6_593437188__K21");

            entity.HasIndex(e => e.Documento, "_dta_index_Pacientes_6_593437188__K4");

            entity.HasIndex(e => e.Nombre, "_dta_index_Pacientes_6_593437188__K5");

            entity.HasIndex(e => new { e.Nombre, e.Anulado }, "_dta_index_Pacientes_6_593437188__K5_K21_1_2_3_4_6_7_8_9_10_11_12_13_14_15_16_18_19_20_22_23_24_25_26_27_28_31_32_33_34_35_36_");

            entity.HasIndex(e => new { e.Nombre, e.Anulado }, "_dta_index_Pacientes_6_593437188__K5_K21_1_4_6_7_12");

            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.CdepartamentoId).HasColumnName("CDepartamentoID");
            entity.Property(e => e.ClocalidadId).HasColumnName("CLocalidadID");
            entity.Property(e => e.CodigoPedidosWeb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConDatodeMadre).HasDefaultValue(false);
            entity.Property(e => e.ConsultaPuco).HasDefaultValue(false);
            entity.Property(e => e.Correo).HasMaxLength(200);
            entity.Property(e => e.CprovinciaId).HasColumnName("CProvinciaId");
            entity.Property(e => e.CreadoPorWpp)
                .HasColumnType("datetime")
                .HasColumnName("CreadoPorWPP");
            entity.Property(e => e.Cuil)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.DatosAdicionales).IsUnicode(false);
            entity.Property(e => e.DocReferencia)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Doc_Referencia");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Ejemplar)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.FechaCarga)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaConsulPuco).HasColumnType("datetime");
            entity.Property(e => e.IdEstadoCivil).HasDefaultValue(7);
            entity.Property(e => e.IdMpi)
                .HasDefaultValue(0)
                .HasColumnName("IdMPI");
            entity.Property(e => e.IdTipoDocReferencia).HasColumnName("IdTipo_DocReferencia");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.NroAfiliado).HasMaxLength(50);
            entity.Property(e => e.NumTramite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialId)
                .HasDefaultValue(0)
                .HasColumnName("ObraSocialID");
            entity.Property(e => e.PacienteIdhc).HasColumnName("PacienteIDHC");
            entity.Property(e => e.PacienteIdoriginal).HasColumnName("PacienteIDOriginal");
            entity.Property(e => e.PacienteIdref).HasColumnName("PacienteIDRef");
            entity.Property(e => e.ProfesionId).HasColumnName("ProfesionID");
            entity.Property(e => e.RecienNacidoHospital).HasDefaultValue(false);
            entity.Property(e => e.ResidenciaLocalidad)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Residencia_Localidad");
            entity.Property(e => e.RnnroFicha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RNNroFicha");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoBeneficiarioId).HasColumnName("TipoBeneficiarioID");
            entity.Property(e => e.TipoInstruccionId).HasColumnName("TipoInstruccionID");
            entity.Property(e => e.TipoLaboralId).HasColumnName("TipoLaboralID");
            entity.Property(e => e.TipoParentezcoId).HasColumnName("TipoParentezcoID");
            entity.Property(e => e.UltimaMod).HasColumnType("datetime");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.ValidadoPorWpp).HasColumnName("ValidadoPorWPP");

            entity.HasOne(d => d.PacienteIdrefNavigation).WithMany(p => p.InversePacienteIdrefNavigation)
                .HasForeignKey(d => d.PacienteIdref)
                .HasConstraintName("FK_Pacientes_Pacientes");
        });

        modelBuilder.Entity<PacientesObraSocial>(entity =>
        {
            entity.HasKey(e => e.PacienteObraSocialId);

            entity.Property(e => e.PacienteObraSocialId).HasColumnName("PacienteObraSocialID");
            entity.Property(e => e.Coseguro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoseguroId).HasColumnName("CoseguroID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.NroAfiliado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PlanId).HasColumnName("PlanID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Paises>(entity =>
        {
            entity.HasKey(e => e.IdPais);

            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<ParametrosHoraHabil>(entity =>
        {
            entity.HasKey(e => e.IdParametroHoraHabil);

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(75);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
        });

        modelBuilder.Entity<ParametrosHoraHabilDetalle>(entity =>
        {
            entity.HasKey(e => e.IdParametrosHoraHabilDet);

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdParametrosHoraHabilNavigation).WithMany(p => p.ParametrosHoraHabilDetalle)
                .HasForeignKey(d => d.IdParametrosHoraHabil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParametrosHoraHabilDetalle_ParametrosHoraHabil");
        });

        modelBuilder.Entity<PartidasAafectar>(entity =>
        {
            entity.ToTable("PartidasAAfectar");

            entity.Property(e => e.PartidasAafectarId).HasColumnName("PartidasAAfectarID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.PresupuestoAnualDetalleId).HasColumnName("PresupuestoAnualDetalleID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.NotaPedido).WithMany(p => p.PartidasAafectar)
                .HasForeignKey(d => d.NotaPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartidasAAfectar_NotaPedido");

            entity.HasOne(d => d.PresupuestoAnualDetalle).WithMany(p => p.PartidasAafectar)
                .HasForeignKey(d => d.PresupuestoAnualDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartidasAAfectar_PresupuestoAnualDetalle");
        });

        modelBuilder.Entity<Patologias>(entity =>
        {
            entity.HasKey(e => e.IdPatologia);

            entity.Property(e => e.Patologia)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<PedIntDetalleRetirar>(entity =>
        {
            entity.Property(e => e.PedIntDetalleRetirarId).HasColumnName("PedIntDetalleRetirarID");
            entity.Property(e => e.CantAretirar)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("CantARetirar");
            entity.Property(e => e.DepositoId).HasColumnName("DepositoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.PedidoInternoDetalleId).HasColumnName("PedidoInterno_DetalleID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PedIntEstado).WithMany(p => p.PedIntDetalleRetirar)
                .HasForeignKey(d => d.PedIntEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedIntDetalleRetirar_PedIntEstado");

            entity.HasOne(d => d.PedidoInternoDetalle).WithMany(p => p.PedIntDetalleRetirar)
                .HasForeignKey(d => d.PedidoInternoDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedIntDetalleRetirar_PedidoInterno_Detalle");
        });

        modelBuilder.Entity<PedIntDetalleRetirarFarmacia>(entity =>
        {
            entity.HasKey(e => e.PedIntDetalleRetirarId);

            entity.Property(e => e.PedIntDetalleRetirarId).HasColumnName("PedIntDetalleRetirarID");
            entity.Property(e => e.CantAretirar)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("CantARetirar");
            entity.Property(e => e.DepositoId).HasColumnName("DepositoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.PedidoInternoFarmaciaDetalleId).HasColumnName("PedidoInternoFarmaciaDetalleID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PedIntEstado>(entity =>
        {
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.Descrpcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PedIntEstadoHistorico>(entity =>
        {
            entity.Property(e => e.PedIntEstadoHistoricoId)
                .ValueGeneratedNever()
                .HasColumnName("PedIntEstadoHistoricoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.PedidoInternoDetalleId).HasColumnName("PedidoInterno_DetalleID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PedIntEstado).WithMany(p => p.PedIntEstadoHistorico)
                .HasForeignKey(d => d.PedIntEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedIntEstadoHistorico_PedIntEstado");

            entity.HasOne(d => d.PedidoInternoDetalle).WithMany(p => p.PedIntEstadoHistorico)
                .HasForeignKey(d => d.PedidoInternoDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedIntEstadoHistorico_PedidoInterno_Detalle");
        });

        modelBuilder.Entity<PedidoInterno>(entity =>
        {
            entity.Property(e => e.PedidoInternoId).HasColumnName("PedidoInternoID");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DepositoServicioId).HasColumnName("DepositoServicioID");
            entity.Property(e => e.DestinoSectorId).HasColumnName("Destino_SectorId");
            entity.Property(e => e.DirigidoA)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstimativoTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaAutoriza).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModi).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.MotivoPedido)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NumeroPedidoInterno)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("Numero_PedidoInterno");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.PedidoLugarEntregaId).HasColumnName("Pedido_LugarEntregaID");
            entity.Property(e => e.PedidoPrioridadId).HasColumnName("PedidoPrioridadID");
            entity.Property(e => e.PedidoSectorIdsolicita).HasColumnName("PedidoSectorIDSolicita");
            entity.Property(e => e.RemitoProveedor)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Remito_Proveedor");
            entity.Property(e => e.UsuarioAutoriza)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PedidoInternoDestinos>(entity =>
        {
            entity.ToTable("PedidoInterno_Destinos");

            entity.Property(e => e.PedidoInternoDestinosId).HasColumnName("PedidoInterno_DestinosID");
            entity.Property(e => e.PedidoInternoId).HasColumnName("PedidoInternoID");
            entity.Property(e => e.PedidoSectorIddestino).HasColumnName("PedidoSectorIDDestino");

            entity.HasOne(d => d.PedidoInterno).WithMany(p => p.PedidoInternoDestinos)
                .HasForeignKey(d => d.PedidoInternoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoInterno_Destinos_PedidoInterno");

            entity.HasOne(d => d.PedidoSectorIddestinoNavigation).WithMany(p => p.PedidoInternoDestinos)
                .HasForeignKey(d => d.PedidoSectorIddestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoInterno_Destinos_PedidoSector");
        });

        modelBuilder.Entity<PedidoInternoDetalle>(entity =>
        {
            entity.ToTable("PedidoInterno_Detalle");

            entity.Property(e => e.PedidoInternoDetalleId).HasColumnName("PedidoInterno_DetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.CantidadSaldo).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModi).HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasColumnType("ntext");
            entity.Property(e => e.OpCrea).HasMaxLength(11);
            entity.Property(e => e.OpModi).HasMaxLength(11);
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.PedidoInternoId).HasColumnName("PedidoInternoID");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Unitario");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.TipoEntrega)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Tipo_Entrega");

            entity.HasOne(d => d.PedIntEstado).WithMany(p => p.PedidoInternoDetalle)
                .HasForeignKey(d => d.PedIntEstadoId)
                .HasConstraintName("FK_PedidoInterno_Detalle_PedIntEstado");

            entity.HasOne(d => d.PedidoInterno).WithMany(p => p.PedidoInternoDetalle)
                .HasForeignKey(d => d.PedidoInternoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoInterno_Detalle_PedidoInterno");

            entity.HasOne(d => d.Producto).WithMany(p => p.PedidoInternoDetalle)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_PedidoInterno_Detalle_Productos");
        });

        modelBuilder.Entity<PedidoInternoEncabezado>(entity =>
        {
            entity.ToTable("PedidoInterno_Encabezado");

            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DestinoSectorId).HasColumnName("Destino_SectorId");
            entity.Property(e => e.EstimativoTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModi).HasColumnType("datetime");
            entity.Property(e => e.NumeroPedidoInterno)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("Numero_PedidoInterno");
            entity.Property(e => e.Observaciones).HasColumnType("ntext");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.RemitoProveedor)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("Remito_Proveedor");
            entity.Property(e => e.SolicitaSectorId).HasColumnName("Solicita_SectorId");

            entity.HasOne(d => d.DestinoSector).WithMany(p => p.PedidoInternoEncabezadoDestinoSector)
                .HasForeignKey(d => d.DestinoSectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoInterno_Encabezado_Sectores_Hospital1");

            entity.HasOne(d => d.SolicitaSector).WithMany(p => p.PedidoInternoEncabezadoSolicitaSector)
                .HasForeignKey(d => d.SolicitaSectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoInterno_Encabezado_Sectores_Hospital");

            entity.HasOne(d => d.TipoPedidoInterno).WithMany(p => p.PedidoInternoEncabezado)
                .HasForeignKey(d => d.TipoPedidoInternoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoInterno_Encabezado_Tipo_PedidoInterno");
        });

        modelBuilder.Entity<PedidoInternoFarmacia>(entity =>
        {
            entity.Property(e => e.PedidoInternoFarmaciaId).HasColumnName("PedidoInternoFarmaciaID");
            entity.Property(e => e.FechaAutoriza).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.IndiacionIdhc).HasColumnName("IndiacionIDHC");
            entity.Property(e => e.InstitucionAnteriorId).HasColumnName("InstitucionAnteriorID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Motivo).HasMaxLength(200);
            entity.Property(e => e.NumeroPedidoInterno).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(200);
            entity.Property(e => e.OpAutoriza)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.PedidoPrioridadId).HasColumnName("PedidoPrioridadID");
        });

        modelBuilder.Entity<PedidoInternoFarmaciaDetalle>(entity =>
        {
            entity.Property(e => e.PedidoInternoFarmaciaDetalleId).HasColumnName("PedidoInternoFarmaciaDetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CantidadSaldo).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.MedicamentoId).HasColumnName("MedicamentoID");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PedIntEstadoId).HasColumnName("PedIntEstadoID");
            entity.Property(e => e.PedidoInternoFarmaciaId).HasColumnName("PedidoInternoFarmaciaID");
        });

        modelBuilder.Entity<PedidoInternoMotivo>(entity =>
        {
            entity.ToTable("PedidoInterno_Motivo");

            entity.Property(e => e.PedidoInternoMotivoId).HasColumnName("PedidoInterno_MotivoId");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<PedidoInternoNotaPedido>(entity =>
        {
            entity.ToTable("PedidoInterno_NotaPedido");
        });

        modelBuilder.Entity<PedidoLugarEntrega>(entity =>
        {
            entity.ToTable("Pedido_LugarEntrega");

            entity.Property(e => e.PedidoLugarEntregaId).HasColumnName("Pedido_LugarEntregaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PedidoPrioridad>(entity =>
        {
            entity.Property(e => e.PedidoPrioridadId).HasColumnName("PedidoPrioridadID");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PedidoSector>(entity =>
        {
            entity.Property(e => e.PedidoSectorId).HasColumnName("PedidoSectorID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PedidosEnConsultorio>(entity =>
        {
            entity.HasKey(e => e.PedidoId);

            entity.ToTable("Pedidos_EnConsultorio");

            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.ConsultaId).HasColumnName("ConsultaID");
            entity.Property(e => e.TipoPedidoId).HasColumnName("Tipo_PedidoID");

            entity.HasOne(d => d.Consulta).WithMany(p => p.PedidosEnConsultorio)
                .HasForeignKey(d => d.ConsultaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedidos_EnConsultorio_Consultas_Ambulatorias");

            entity.HasOne(d => d.TipoPedido).WithMany(p => p.PedidosEnConsultorio)
                .HasForeignKey(d => d.TipoPedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedidos_EnConsultorio_Tipo_PedidoEnConsultorio");
        });

        modelBuilder.Entity<PendientesServicios>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pendientes_Servicios");

            entity.Property(e => e.DetallePedido).HasColumnName("Detalle_Pedido");
            entity.Property(e => e.FechaSolicitud).HasColumnName("Fecha_Solicitud");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PendientesServiciosId).HasColumnName("PendientesServiciosID");
            entity.Property(e => e.PrestadorEfectorId).HasColumnName("Prestador_EfectorID");
            entity.Property(e => e.PrestadorSolicitanteId).HasColumnName("Prestador_SolicitanteID");
            entity.Property(e => e.SectorEfectorId).HasColumnName("Sector_EfectorID");
            entity.Property(e => e.SectorSolicitanteId).HasColumnName("Sector_SolicitanteID");
            entity.Property(e => e.TurnoNuevoId).HasColumnName("Turno_NuevoID");
            entity.Property(e => e.TurnoOrigenId).HasColumnName("Turno_OrigenID");
        });

        modelBuilder.Entity<PerfilAnalisisLaboratorio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Perfil_AnalisisLaboratorio");

            entity.Property(e => e.Perfil)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PerfilAnalisisLaboratorioId).HasColumnName("PerfilAnalisisLaboratorioID");
        });

        modelBuilder.Entity<PerfilDetalleLaboratorio>(entity =>
        {
            entity.HasKey(e => e.DetalleLaboratorioId);

            entity.ToTable("Perfil_DetalleLaboratorio");

            entity.Property(e => e.DetalleLaboratorioId)
                .ValueGeneratedNever()
                .HasColumnName("DetalleLaboratorioID");
            entity.Property(e => e.AnalisisLaboratorioId).HasColumnName("AnalisisLaboratorioID");
            entity.Property(e => e.GeneralLaboratorioId).HasColumnName("GeneralLaboratorioID");

            entity.HasOne(d => d.AnalisisLaboratorio).WithMany(p => p.PerfilDetalleLaboratorio)
                .HasForeignKey(d => d.AnalisisLaboratorioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Perfil_DetalleLaboratorio_Analisis_Laboratorio");

            entity.HasOne(d => d.GeneralLaboratorio).WithMany(p => p.PerfilDetalleLaboratorio)
                .HasForeignKey(d => d.GeneralLaboratorioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Perfil_DetalleLaboratorio_Perfil_GeneralLaboratorio");
        });

        modelBuilder.Entity<PerfilGeneralLaboratorio>(entity =>
        {
            entity.HasKey(e => e.GeneralLaboratorioId);

            entity.ToTable("Perfil_GeneralLaboratorio");

            entity.Property(e => e.GeneralLaboratorioId)
                .ValueGeneratedNever()
                .HasColumnName("GeneralLaboratorioID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<PersClasificacionInasistencia>(entity =>
        {
            entity.Property(e => e.PersClasificacionInasistenciaId).HasColumnName("PersClasificacionInasistenciaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersEstadoSolicitud>(entity =>
        {
            entity.Property(e => e.PersEstadoSolicitudId).HasColumnName("PersEstadoSolicitudID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PersLicencia>(entity =>
        {
            entity.Property(e => e.PersLicenciaId).HasColumnName("PersLicenciaID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.PersSolicitudPermisoId).HasColumnName("PersSolicitudPermisoID");
            entity.Property(e => e.PersTipoLicenciaId).HasColumnName("PersTipoLicenciaID");
            entity.Property(e => e.RutaArchivoAdjunto).HasMaxLength(100);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModificar)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PersSolicitudPermiso).WithMany(p => p.PersLicencia)
                .HasForeignKey(d => d.PersSolicitudPermisoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersLicencia_PersSolicitudPermiso");

            entity.HasOne(d => d.PersTipoLicencia).WithMany(p => p.PersLicencia)
                .HasForeignKey(d => d.PersTipoLicenciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersLicencia_PersTipoLicencia");
        });

        modelBuilder.Entity<PersPlanificacion>(entity =>
        {
            entity.Property(e => e.PersPlanificacionId).HasColumnName("PersPlanificacionID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Periodo)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Empleado).WithMany(p => p.PersPlanificacion)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersPlanificacion_Empleados_Hospital");
        });

        modelBuilder.Entity<PersPlanificacionDetalle>(entity =>
        {
            entity.Property(e => e.PersPlanificacionDetalleId).HasColumnName("PersPlanificacionDetalleID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraHasta).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PersLicenciaId).HasColumnName("PersLicenciaID");
            entity.Property(e => e.PersPlanificacionDetalleIdmodificado).HasColumnName("PersPlanificacionDetalleIDModificado");
            entity.Property(e => e.PersPlanificacionId).HasColumnName("PersPlanificacionID");
            entity.Property(e => e.PersTipoTrabajoId).HasColumnName("PersTipoTrabajoID");
            entity.Property(e => e.PersTurnoId).HasColumnName("PersTurnoID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PersLicencia).WithMany(p => p.PersPlanificacionDetalle)
                .HasForeignKey(d => d.PersLicenciaId)
                .HasConstraintName("FK_PersPlanificacionDetalle_PersLicencia");

            entity.HasOne(d => d.PersPlanificacion).WithMany(p => p.PersPlanificacionDetalle)
                .HasForeignKey(d => d.PersPlanificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersPlanificacionDetalle_PersPlanificacion");

            entity.HasOne(d => d.PersTipoTrabajo).WithMany(p => p.PersPlanificacionDetalle)
                .HasForeignKey(d => d.PersTipoTrabajoId)
                .HasConstraintName("FK_PersPlanificacionDetalle_PersTipoTrabajo");

            entity.HasOne(d => d.PersTurno).WithMany(p => p.PersPlanificacionDetalle)
                .HasForeignKey(d => d.PersTurnoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersPlanificacionDetalle_PersTurno");
        });

        modelBuilder.Entity<PersPlanificacionReloj>(entity =>
        {
            entity.HasKey(e => e.IdPersPlanificacionReloj);

            entity.Property(e => e.IdPersPlanificacionReloj).HasColumnName("idPersPlanificacionReloj");
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.FechaProcesa).HasColumnType("datetime");
            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.IdReloj).HasColumnName("idReloj");
        });

        modelBuilder.Entity<PersPlanificacionRelojChek>(entity =>
        {
            entity.HasKey(e => e.IdPersPlanificacionRelojChek);

            entity.Property(e => e.IdPersPlanificacionRelojChek).HasColumnName("idPersPlanificacionRelojChek");
            entity.Property(e => e.Chequeo).HasColumnType("datetime");
            entity.Property(e => e.IdPersPlanificacionRelojTurno).HasColumnName("idPersPlanificacionRelojTurno");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<PersPlanificacionRelojTurno>(entity =>
        {
            entity.HasKey(e => e.IdPersPlanificacionRelojTurno);

            entity.Property(e => e.IdPersPlanificacionRelojTurno).HasColumnName("idPersPlanificacionRelojTurno");
            entity.Property(e => e.Detalle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaDia).HasColumnType("datetime");
            entity.Property(e => e.HorasTurno).HasMaxLength(20);
            entity.Property(e => e.IdPersPlanificacionReloj).HasColumnName("idPersPlanificacionReloj");
        });

        modelBuilder.Entity<PersRegistro>(entity =>
        {
            entity.Property(e => e.PersRegistroId).HasColumnName("PersRegistroID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.PersRelojId).HasColumnName("PersRelojID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Empleado).WithMany(p => p.PersRegistro)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersRegistro_Empleados_Hospital");

            entity.HasOne(d => d.PersReloj).WithMany(p => p.PersRegistro)
                .HasForeignKey(d => d.PersRelojId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersRegistro_PersReloj");
        });

        modelBuilder.Entity<PersReloj>(entity =>
        {
            entity.Property(e => e.PersRelojId).HasColumnName("PersRelojID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PersRestriccion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Antiguedad)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DiasAnticipacion).HasDefaultValue(0);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Horas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nuevamente).HasDefaultValue(0);
            entity.Property(e => e.PersRestriccionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PersRestriccionID");
            entity.Property(e => e.Prorroga)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TopeAnualDias).HasDefaultValue(0);
            entity.Property(e => e.TopeAnualPermisos).HasDefaultValue(0);
            entity.Property(e => e.TopeMensualDias).HasDefaultValue(0);
            entity.Property(e => e.TopeMensualPermisos).HasDefaultValue(0);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PersRestriccionXantiguedad>(entity =>
        {
            entity.ToTable("PersRestriccionXAntiguedad");

            entity.Property(e => e.PersRestriccionXantiguedadId).HasColumnName("PersRestriccionXAntiguedadID");
            entity.Property(e => e.PersRestriccionId).HasColumnName("PersRestriccionID");
            entity.Property(e => e.PersTipoLicenciaId).HasColumnName("PersTipoLicenciaID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersSolicitudPermiso>(entity =>
        {
            entity.Property(e => e.PersSolicitudPermisoId).HasColumnName("PersSolicitudPermisoID");
            entity.Property(e => e.CantHs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Fecha2daProcesa).HasColumnType("datetime");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraHasta).HasColumnType("datetime");
            entity.Property(e => e.FechaProcesa).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicita).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Momento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Motivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.MotivoRechazo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PersEstadoSolicitudId).HasColumnName("PersEstadoSolicitudID");
            entity.Property(e => e.PersTipoLicenciaId).HasColumnName("PersTipoLicenciaID");
            entity.Property(e => e.PersVacacionAnualId).HasColumnName("PersVacacionAnualID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioProcesa)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioSolicita)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Empleado).WithMany(p => p.PersSolicitudPermiso)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersSolicitudPermiso_Empleados_Hospital");

            entity.HasOne(d => d.PersEstadoSolicitud).WithMany(p => p.PersSolicitudPermiso)
                .HasForeignKey(d => d.PersEstadoSolicitudId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersSolicitudPermiso_PersEstadoSolicitud");

            entity.HasOne(d => d.PersTipoLicencia).WithMany(p => p.PersSolicitudPermiso)
                .HasForeignKey(d => d.PersTipoLicenciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersSolicitudPermiso_PersTipoLicencia");

            entity.HasOne(d => d.Sector).WithMany(p => p.PersSolicitudPermiso)
                .HasForeignKey(d => d.SectorId)
                .HasConstraintName("FK_PersSolicitudPermiso_Sectores_Hospital");
        });

        modelBuilder.Entity<PersTipoLicencia>(entity =>
        {
            entity.Property(e => e.PersTipoLicenciaId).HasColumnName("PersTipoLicenciaID");
            entity.Property(e => e.Abreviatura).HasMaxLength(30);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.PersClasificacionInasistenciaId).HasColumnName("PersClasificacionInasistenciaID");
            entity.Property(e => e.PersRestriccionId).HasColumnName("PersRestriccionID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PersTipoTrabajo>(entity =>
        {
            entity.Property(e => e.PersTipoTrabajoId).HasColumnName("PersTipoTrabajoID");
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ColorMostrar)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersTurno>(entity =>
        {
            entity.Property(e => e.PersTurnoId).HasColumnName("PersTurnoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersVacacionAnual>(entity =>
        {
            entity.Property(e => e.PersVacacionAnualId).HasColumnName("PersVacacionAnualID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Empleado).WithMany(p => p.PersVacacionAnual)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersVacacionAnual_Empleados_Hospital");
        });

        modelBuilder.Entity<PersVacacionAnualHistorial>(entity =>
        {
            entity.Property(e => e.PersVacacionAnualHistorialId).HasColumnName("PersVacacionAnualHistorialID");
            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PersVacacionAnualId).HasColumnName("PersVacacionAnualID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PersVacacionAnual).WithMany(p => p.PersVacacionAnualHistorial)
                .HasForeignKey(d => d.PersVacacionAnualId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersVacacionAnualHistorial_PersVacacionAnual");
        });

        modelBuilder.Entity<PersonaTipo>(entity =>
        {
            entity.HasKey(e => e.TipoPersonaId);

            entity.ToTable("Persona_Tipo");

            entity.Property(e => e.TipoPersonaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TipoPersonaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Tabla)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<Personas>(entity =>
        {
            entity.HasKey(e => e.PersonaId);

            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.CuitCuil)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Cuit_Cuil");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EnviarPublicidad).HasColumnName("Enviar_Publicidad");
            entity.Property(e => e.FechaAnulado)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Anulado");
            entity.Property(e => e.FechaEgreso)
                .HasComment("Código de clasificación...Indica cual es el id del clasificador de gastos.")
                .HasColumnName("Fecha_Egreso");
            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.NombreVisible)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Nombre_Visible");
            entity.Property(e => e.SituacionLaboralId).HasColumnName("SituacionLaboralID");
            entity.Property(e => e.SituacionTribId).HasColumnName("SituacionTribID");
            entity.Property(e => e.TipoCuitid).HasColumnName("TipoCUITId");
            entity.Property(e => e.TipoDocumentoId).HasColumnName("TipoDocumentoID");
            entity.Property(e => e.TipoInstruccionId).HasColumnName("TipoInstruccionID");
            entity.Property(e => e.TipoPersonaId).HasColumnName("TipoPersonaID");
            entity.Property(e => e.Web)
                .HasMaxLength(200)
                .IsFixedLength();

            entity.HasOne(d => d.IdEstadoCivilNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdEstadoCivil)
                .HasConstraintName("FK_Personas_EstadoCivil");

            entity.HasOne(d => d.IdSexoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdSexo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personas_Sexo");

            entity.HasOne(d => d.SituacionLaboral).WithMany(p => p.Personas)
                .HasForeignKey(d => d.SituacionLaboralId)
                .HasConstraintName("FK_Personas_Situacion_Laboral");

            entity.HasOne(d => d.SituacionTrib).WithMany(p => p.Personas)
                .HasForeignKey(d => d.SituacionTribId)
                .HasConstraintName("FK_Personas_SituacionTributaria");

            entity.HasOne(d => d.TipoCuit).WithMany(p => p.Personas)
                .HasForeignKey(d => d.TipoCuitid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personas_Tipo_CUIT");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Personas)
                .HasForeignKey(d => d.TipoDocumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personas_Tipo_Documento");

            entity.HasOne(d => d.TipoInstruccion).WithMany(p => p.Personas)
                .HasForeignKey(d => d.TipoInstruccionId)
                .HasConstraintName("FK_Personas_Tipo_Instruccion");

            entity.HasOne(d => d.TipoPersona).WithMany(p => p.Personas)
                .HasForeignKey(d => d.TipoPersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personas_Tipo_Persona");
        });

        modelBuilder.Entity<PersonasTipoDetalle>(entity =>
        {
            entity.HasKey(e => e.TipoDetalleId);

            entity.ToTable("Personas_TipoDetalle");

            entity.Property(e => e.TipoDetalleId).HasColumnName("TipoDetalleID");
            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            entity.Property(e => e.TablaId).HasColumnName("TablaID");
            entity.Property(e => e.TipoPersonaId).HasColumnName("TipoPersonaID");

            entity.HasOne(d => d.Persona).WithMany(p => p.PersonasTipoDetalle)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personas_TipoDetalle_Personas");

            entity.HasOne(d => d.TipoPersona).WithMany(p => p.PersonasTipoDetalle)
                .HasForeignKey(d => d.TipoPersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personas_TipoDetalle_Persona_Tipo");
        });

        modelBuilder.Entity<PisosHospital>(entity =>
        {
            entity.HasKey(e => e.PisoId);

            entity.ToTable("Pisos_hospital");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity.Property(e => e.PlanId).HasColumnName("PlanID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserAnula)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UserCrea)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UserModifica)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PlanObraSocial>(entity =>
        {
            entity.Property(e => e.PlanObraSocialId).HasColumnName("PlanObraSocialID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.PlanId).HasColumnName("PlanID");
            entity.Property(e => e.UserAnula)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UserCrea)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UserModifica)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Planes>(entity =>
        {
            entity.HasKey(e => e.IdPlan).HasName("PK_Planes_1");

            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.Hc).HasColumnName("HC");
            entity.Property(e => e.OperAnula)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.OperModif)
                .HasMaxLength(14)
                .IsFixedLength();
            entity.Property(e => e.Relacion)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<PlanesInstituciones>(entity =>
        {
            entity.Property(e => e.PlanesInstitucionesId).HasColumnName("PlanesInstitucionesID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.PlanId).HasColumnName("PlanID");
            entity.Property(e => e.UserAnula)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UserCrea)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UserModifica)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PlanillaControl>(entity =>
        {
            entity.HasKey(e => e.IdControl);

            entity.Property(e => e.Dtmeses).HasColumnName("DTmeses");
            entity.Property(e => e.OftalmologiaId).HasColumnName("OftalmologiaID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

            entity.HasOne(d => d.Oftalmologia).WithMany(p => p.PlanillaControl)
                .HasForeignKey(d => d.OftalmologiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanillaControl_Oftalmologia");

            entity.HasOne(d => d.Prestador).WithMany(p => p.PlanillaControl)
                .HasForeignKey(d => d.PrestadorId)
                .HasConstraintName("FK_PlanillaControl_Prestadores");
        });

        modelBuilder.Entity<PlanillaTurnos>(entity =>
        {
            entity.HasKey(e => e.PlanillaTurnoId);

            entity.ToTable("Planilla_Turnos");

            entity.HasIndex(e => new { e.Fecha, e.ServicioId, e.Anulado }, "Ix_Planilla_Turnos_FechaServicioIDAnulado");

            entity.Property(e => e.PlanillaTurnoId).HasColumnName("Planilla_TurnoID");
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.Opcrea)
                .HasMaxLength(11)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("opcrea");
            entity.Property(e => e.Opmodifica)
                .HasMaxLength(11)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("opmodifica");
            entity.Property(e => e.PlanillaTurnoIdoriginal).HasColumnName("Planilla_TurnoIDOriginal");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.Turno).HasDefaultValue((short)1);

            entity.HasOne(d => d.Consultorio).WithMany(p => p.PlanillaTurnos)
                .HasForeignKey(d => d.ConsultorioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Planilla_Turnos_Consultorios");

            entity.HasOne(d => d.Prestador).WithMany(p => p.PlanillaTurnos)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Planilla_Turnos_Prestadores");

            entity.HasOne(d => d.Servicio).WithMany(p => p.PlanillaTurnos)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Planilla_Turnos_Servicios");
        });

        modelBuilder.Entity<PracticaTurnos>(entity =>
        {
            entity.HasKey(e => e.PracticaTurnoId);

            entity.Property(e => e.PracticaTurnoId).HasColumnName("PracticaTurnoID");
            entity.Property(e => e.PracticaBaseId).HasColumnName("PracticaBaseID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

            entity.HasOne(d => d.PracticaBase).WithMany(p => p.PracticaTurnos)
                .HasForeignKey(d => d.PracticaBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PracticaTurnos_Practicas_Base");
        });

        modelBuilder.Entity<PracticasBase>(entity =>
        {
            entity.HasKey(e => e.PracticaBaseId).HasName("PK_NPracticas_Base");

            entity.ToTable("Practicas_Base");

            entity.Property(e => e.PracticaBaseId).HasColumnName("PracticaBaseID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.DescripcionPractica).HasColumnName("Descripcion_Practica");
            entity.Property(e => e.IdTipoPractica).HasColumnName("IdTipo_Practica");
            entity.Property(e => e.IdUnidadGastos).HasColumnName("IdUnidad_Gastos");
            entity.Property(e => e.IdUnidadHonorarios).HasColumnName("IdUnidad_Honorarios");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.NumeroAyudantes).HasColumnName("Numero_ayudantes");
            entity.Property(e => e.UnidadAnestesista)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Anestesista");
            entity.Property(e => e.UnidadAyudante1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Ayudante1");
            entity.Property(e => e.UnidadAyudante2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Ayudante2");
            entity.Property(e => e.UnidadAyudante3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Ayudante3");
            entity.Property(e => e.UnidadAyudante4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Ayudante4");
            entity.Property(e => e.UnidadEspecialista)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Especialista");
            entity.Property(e => e.UnidadGastos)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Gastos");
            entity.Property(e => e.UnidadInstrumentista)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Unidad_Instrumentista");
        });

        modelBuilder.Entity<PracticasEstado>(entity =>
        {
            entity.Property(e => e.PracticasEstadoId).HasColumnName("PracticasEstadoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PracticasEstados>(entity =>
        {
            entity.HasKey(e => e.PracticaEstadoId);

            entity.Property(e => e.PracticaEstadoId).HasColumnName("PracticaEstadoID");
            entity.Property(e => e.Nombre).HasMaxLength(150);
        });

        modelBuilder.Entity<PracticasMedicas>(entity =>
        {
            entity.HasKey(e => e.PracticaMedicaId);

            entity.Property(e => e.PracticaMedicaId).HasColumnName("PracticaMedicaID");
            entity.Property(e => e.PracticaMedicaTipoId).HasColumnName("PracticaMedicaTipoID");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioFinSemanaFeriado).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.PracticaMedicaTipo).WithMany(p => p.PracticasMedicas)
                .HasForeignKey(d => d.PracticaMedicaTipoId)
                .HasConstraintName("FK_PracticasMedicas_PracticasMedicasTipo");
        });

        modelBuilder.Entity<PracticasMedicasTipo>(entity =>
        {
            entity.HasKey(e => e.PracticaMedicaTipoId);

            entity.Property(e => e.PracticaMedicaTipoId)
                .ValueGeneratedNever()
                .HasColumnName("PracticaMedicaTipoID");
        });

        modelBuilder.Entity<PracticasOrigen>(entity =>
        {
            entity.Property(e => e.PracticasOrigenId).HasColumnName("PracticasOrigenID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PracticasXtipoInternacion>(entity =>
        {
            entity.HasKey(e => e.PracticaXtipoInternacionId);

            entity.ToTable("PracticasXTipoInternacion");

            entity.Property(e => e.PracticaXtipoInternacionId).HasColumnName("PracticaXTipoInternacionID");
            entity.Property(e => e.PracticaBaseId).HasColumnName("PracticaBaseID");
            entity.Property(e => e.TipoInternacionId).HasColumnName("TipoInternacionID");
            entity.Property(e => e.UsuarioAnula).HasMaxLength(20);
            entity.Property(e => e.UsuarioCrea).HasMaxLength(20);
            entity.Property(e => e.UsuarioModifica).HasMaxLength(20);
        });

        modelBuilder.Entity<Prescripcion>(entity =>
        {
            entity.Property(e => e.PrescripcionId).HasColumnName("PrescripcionID");
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.FechaPrescribe).HasColumnType("datetime");
            entity.Property(e => e.PrescripcionEncabezadoId).HasColumnName("PrescripcionEncabezadoID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioImprime)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PrescripcionEncabezado).WithMany(p => p.Prescripcion)
                .HasForeignKey(d => d.PrescripcionEncabezadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prescripcion_PrescripcionEncabezado");

            entity.HasOne(d => d.Prestador).WithMany(p => p.Prescripcion)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prescripcion_Prestadores");
        });

        modelBuilder.Entity<PrescripcionDetalle>(entity =>
        {
            entity.Property(e => e.PrescripcionDetalleId).HasColumnName("PrescripcionDetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaRetira).HasColumnType("datetime");
            entity.Property(e => e.IdOpcion).HasMaxLength(100);
            entity.Property(e => e.InicioServicio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrescripcionId).HasColumnName("PrescripcionID");
            entity.Property(e => e.PrescripcionTipoIndicacionId).HasColumnName("PrescripcionTipoIndicacionID");
            entity.Property(e => e.TipoId).HasColumnName("TipoID");

            entity.HasOne(d => d.Prescripcion).WithMany(p => p.PrescripcionDetalle)
                .HasForeignKey(d => d.PrescripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescripcionDetalle_Prescripcion");

            entity.HasOne(d => d.PrescripcionTipoIndicacion).WithMany(p => p.PrescripcionDetalle)
                .HasForeignKey(d => d.PrescripcionTipoIndicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescripcionDetalle_PrescripcionTipoIndicacion");
        });

        modelBuilder.Entity<PrescripcionEncabezado>(entity =>
        {
            entity.Property(e => e.PrescripcionEncabezadoId).HasColumnName("PrescripcionEncabezadoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Internacion).WithMany(p => p.PrescripcionEncabezado)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescripcionEncabezado_Internaciones");

            entity.HasOne(d => d.Paciente).WithMany(p => p.PrescripcionEncabezado)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescripcionEncabezado_Pacientes");
        });

        modelBuilder.Entity<PrescripcionTipoIndicacion>(entity =>
        {
            entity.Property(e => e.PrescripcionTipoIndicacionId).HasColumnName("PrescripcionTipoIndicacionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<PrestacionesOdontologicas>(entity =>
        {
            entity.HasKey(e => e.IdPrestacionOdontologica);

            entity.ToTable("Prestaciones_Odontologicas");

            entity.Property(e => e.IdPrestacionOdontologica).HasColumnName("idPrestacionOdontologica");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PrestadorDias>(entity =>
        {
            entity.HasKey(e => e.PrestadorDiasId).HasName("PK_PresatdorDias");

            entity.HasIndex(e => new { e.PrestadorId, e.DiaId, e.Anulado }, "Ix_PrestadorDia_PrestadorIDDiaIDAnulado");

            entity.HasIndex(e => new { e.ServicioId, e.DiaId, e.Anulado }, "Ix_PrestadorDias_ServicioIDDiasIDAnulado");

            entity.Property(e => e.PrestadorDiasId).HasColumnName("PrestadorDiasID");
            entity.Property(e => e.CantPacienteM).HasComment("0");
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.DiaId).HasColumnName("DiaID");
            entity.Property(e => e.Frecuencia)
                .HasMaxLength(2)
                .HasDefaultValue("15")
                .IsFixedLength();
            entity.Property(e => e.MDesde)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("M_Desde");
            entity.Property(e => e.MHasta)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("M_Hasta");
            entity.Property(e => e.NDesde)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("N_Desde");
            entity.Property(e => e.NHasta)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("N_Hasta");
            entity.Property(e => e.PrestadorDiasIdoriginal).HasColumnName("PrestadorDiasIDOriginal");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.PrestadoresInstitucionesId).HasColumnName("PrestadoresInstitucionesID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.TDesde)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("T_Desde");
            entity.Property(e => e.THasta)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("T_Hasta");
            entity.Property(e => e.UltimaMod).HasColumnType("datetime");
            entity.Property(e => e.UsuarioBaja)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Dia).WithMany(p => p.PrestadorDias)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestadorDias_Dias");

            entity.HasOne(d => d.Prestador).WithMany(p => p.PrestadorDias)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestadorDias_Prestador");
        });

        modelBuilder.Entity<PrestadorXservicio>(entity =>
        {
            entity.ToTable("PrestadorXServicio");

            entity.Property(e => e.PrestadorXservicioId).HasColumnName("PrestadorXServicioID");
            entity.Property(e => e.Ambulatorio).HasDefaultValue(false);
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Interconsulta).HasDefaultValue(false);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.UsuarioBaja)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Prestadores>(entity =>
        {
            entity.HasKey(e => e.PrestadorId);

            entity.HasIndex(e => e.Anulado, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => e.Anulado, "<Name of Missing Index2, sysname,>");

            entity.HasIndex(e => e.PrestadorId, "_dta_index_Prestadores_6_746537793__K1_3");

            entity.HasIndex(e => new { e.Anulado, e.Internacion }, "index_internacion");

            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Cuil).HasMaxLength(20);
            entity.Property(e => e.DniJardin).HasMaxLength(10);
            entity.Property(e => e.Documento).HasMaxLength(10);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");
            entity.Property(e => e.IdIosepddjj)
                .HasDefaultValue(0)
                .HasColumnName("IdIOSEPddjj");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Iosepddjj).HasColumnName("IOSEPddjj");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PrestadorIdhc).HasColumnName("PrestadorIDHC");
            entity.Property(e => e.PrestadorIdoriginal).HasColumnName("PrestadorIDOriginal");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TipoGuardiaId).HasColumnName("TipoGuardiaID");
            entity.Property(e => e.UltimaMod)
                .HasColumnType("datetime")
                .HasColumnName("ultimaMod");
            entity.Property(e => e.Usuario).HasMaxLength(20);
            entity.Property(e => e.UsuarioBaja)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioBaja");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCarga");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioMod");
            entity.Property(e => e.Vencimientoddjj).HasColumnType("datetime");

            entity.HasOne(d => d.Especialidad).WithMany(p => p.Prestadores)
                .HasForeignKey(d => d.EspecialidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prestadores_Especialidades");

            entity.HasOne(d => d.TipoGuardia).WithMany(p => p.Prestadores)
                .HasForeignKey(d => d.TipoGuardiaId)
                .HasConstraintName("FK_Prestadores_TipoGuardia");
        });

        modelBuilder.Entity<PrestadoresAsignados>(entity =>
        {
            entity.HasKey(e => e.PrestadorAsignadoId);

            entity.Property(e => e.PrestadorAsignadoId).HasColumnName("PrestadorAsignadoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaAsigna).HasColumnType("datetime");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioAsigna)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PrestadoresDiasExcepcion>(entity =>
        {
            entity.Property(e => e.PrestadoresDiasExcepcionId).HasColumnName("PrestadoresDiasExcepcionID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Motivo).HasMaxLength(200);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.PrestadoresInstitucionesId).HasColumnName("PrestadoresInstitucionesID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<PrestadoresEspecialidades>(entity =>
        {
            entity.HasKey(e => e.IdPrestadorEspecialidad);

            entity.Property(e => e.Documento)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.UserAnula)
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.HasOne(d => d.Especialidad).WithMany(p => p.PrestadoresEspecialidades)
                .HasForeignKey(d => d.EspecialidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestadoresEspecialidades_Especialidades");
        });

        modelBuilder.Entity<PrestadoresInstituciones>(entity =>
        {
            entity.Property(e => e.PrestadoresInstitucionesId).HasColumnName("PrestadoresInstitucionesID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.OpAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
        });

        modelBuilder.Entity<PrestadoresServicios>(entity =>
        {
            entity.Property(e => e.PrestadoresServiciosId)
                .ValueGeneratedNever()
                .HasColumnName("PrestadoresServiciosID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

            entity.HasOne(d => d.Prestador).WithMany(p => p.PrestadoresServicios)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestadoresServicios_Prestadores");

            entity.HasOne(d => d.Servicio).WithMany(p => p.PrestadoresServicios)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestadoresServicios_Servicios");
        });

        modelBuilder.Entity<PresupuestoAnual>(entity =>
        {
            entity.Property(e => e.PresupuestoAnualId).HasColumnName("PresupuestoAnualID");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaVence).HasColumnType("datetime");
            entity.Property(e => e.HospitalId).HasColumnName("HospitalID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioVence)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.Hospital).WithMany(p => p.PresupuestoAnual)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoAnual_Hospital");
        });

        modelBuilder.Entity<PresupuestoAnualAfectacion>(entity =>
        {
            entity.Property(e => e.PresupuestoAnualAfectacionId).HasColumnName("PresupuestoAnualAfectacionID");
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FondoPermanenteId).HasColumnName("FondoPermanenteID");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.NroExpediente)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PresupuestoAnualDetalleId).HasColumnName("PresupuestoAnualDetalleID");
            entity.Property(e => e.RefAsiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RefAsientoId).HasColumnName("RefAsientoID");
            entity.Property(e => e.SaldoPartida).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PresupuestoAnualDetalle).WithMany(p => p.PresupuestoAnualAfectacion)
                .HasForeignKey(d => d.PresupuestoAnualDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoAnualAfectacion_PresupuestoAnualDetalle");
        });

        modelBuilder.Entity<PresupuestoAnualDetalle>(entity =>
        {
            entity.Property(e => e.PresupuestoAnualDetalleId).HasColumnName("PresupuestoAnualDetalleID");
            entity.Property(e => e.HospitalPartidaId).HasColumnName("HospitalPartidaID");
            entity.Property(e => e.HospitalProyectoId).HasColumnName("HospitalProyectoID");
            entity.Property(e => e.HospitalSubProgramaId).HasColumnName("HospitalSubProgramaID");
            entity.Property(e => e.ImporteAfectadoActual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IngresoAnual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PresupuestoAnualId).HasColumnName("PresupuestoAnualID");

            entity.HasOne(d => d.HospitalPartida).WithMany(p => p.PresupuestoAnualDetalle)
                .HasForeignKey(d => d.HospitalPartidaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoAnualDetalle_HospitalPartida");

            entity.HasOne(d => d.HospitalProyecto).WithMany(p => p.PresupuestoAnualDetalle)
                .HasForeignKey(d => d.HospitalProyectoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoAnualDetalle_HospitalProyecto");

            entity.HasOne(d => d.HospitalSubPrograma).WithMany(p => p.PresupuestoAnualDetalle)
                .HasForeignKey(d => d.HospitalSubProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoAnualDetalle_HospitalSubPrograma");

            entity.HasOne(d => d.PresupuestoAnual).WithMany(p => p.PresupuestoAnualDetalle)
                .HasForeignKey(d => d.PresupuestoAnualId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoAnualDetalle_PresupuestoAnual");
        });

        modelBuilder.Entity<PresupuestoAnualMovimiento>(entity =>
        {
            entity.HasKey(e => e.PresupuestoAnualMovimientoId).HasName("PK_PresupuestoAnualIngreso");

            entity.Property(e => e.PresupuestoAnualMovimientoId).HasColumnName("PresupuestoAnualMovimientoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PresupuestoAnualDetalleId).HasColumnName("PresupuestoAnualDetalleID");
            entity.Property(e => e.PresupuestoConceptoId).HasColumnName("PresupuestoConceptoID");
            entity.Property(e => e.PresupuestoMovEntrePartidasId).HasColumnName("PresupuestoMovEntrePartidasID");
            entity.Property(e => e.SaldoPartida).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PresupuestoAnualDetalle).WithMany(p => p.PresupuestoAnualMovimiento)
                .HasForeignKey(d => d.PresupuestoAnualDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoAnualIngreso_PresupuestoAnualDetalle");

            entity.HasOne(d => d.PresupuestoConcepto).WithMany(p => p.PresupuestoAnualMovimiento)
                .HasForeignKey(d => d.PresupuestoConceptoId)
                .HasConstraintName("FK_PresupuestoAnualIngreso_PresupuestoConcepto");

            entity.HasOne(d => d.PresupuestoMovEntrePartidas).WithMany(p => p.PresupuestoAnualMovimiento)
                .HasForeignKey(d => d.PresupuestoMovEntrePartidasId)
                .HasConstraintName("FK_PresupuestoAnualIngreso_PresupuestoMovEntrePartidas");
        });

        modelBuilder.Entity<PresupuestoCompromiso>(entity =>
        {
            entity.Property(e => e.PresupuestoCompromisoId).HasColumnName("PresupuestoCompromisoID");
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FondoPermanenteId).HasColumnName("FondoPermanenteID");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NroExpediente)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PresupuestoAnualAfectacionId).HasColumnName("PresupuestoAnualAfectacionID");
            entity.Property(e => e.PresupuestoResolucionId).HasColumnName("PresupuestoResolucionID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PresupuestoAnualAfectacion).WithMany(p => p.PresupuestoCompromiso)
                .HasForeignKey(d => d.PresupuestoAnualAfectacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoCompromiso_PresupuestoAnualAfectacion");

            entity.HasOne(d => d.PresupuestoResolucion).WithMany(p => p.PresupuestoCompromiso)
                .HasForeignKey(d => d.PresupuestoResolucionId)
                .HasConstraintName("FK_PresupuestoCompromiso_PresupuestoResolucion");
        });

        modelBuilder.Entity<PresupuestoConcepto>(entity =>
        {
            entity.Property(e => e.PresupuestoConceptoId).HasColumnName("PresupuestoConceptoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PresupuestoMotivoGanador>(entity =>
        {
            entity.HasKey(e => e.PresupuestoMotivoGanadorId).HasName("PK_MotivoGanador2");

            entity.ToTable("Presupuesto_MotivoGanador");

            entity.Property(e => e.PresupuestoMotivoGanadorId).HasColumnName("Presupuesto_MotivoGanadorID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PresupuestoMovEntrePartidas>(entity =>
        {
            entity.Property(e => e.PresupuestoMovEntrePartidasId).HasColumnName("PresupuestoMovEntrePartidasID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PresupuestoAnualDetalleIddestino).HasColumnName("PresupuestoAnualDetalleIDDestino");
            entity.Property(e => e.PresupuestoAnualDetalleIdorigen).HasColumnName("PresupuestoAnualDetalleIDOrigen");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.PresupuestoAnualDetalleIddestinoNavigation).WithMany(p => p.PresupuestoMovEntrePartidasPresupuestoAnualDetalleIddestinoNavigation)
                .HasForeignKey(d => d.PresupuestoAnualDetalleIddestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoMovEntrePartidas_PresupuestoAnualDetalle1");

            entity.HasOne(d => d.PresupuestoAnualDetalleIdorigenNavigation).WithMany(p => p.PresupuestoMovEntrePartidasPresupuestoAnualDetalleIdorigenNavigation)
                .HasForeignKey(d => d.PresupuestoAnualDetalleIdorigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoMovEntrePartidas_PresupuestoAnualDetalle");
        });

        modelBuilder.Entity<PresupuestoResolucion>(entity =>
        {
            entity.Property(e => e.PresupuestoResolucionId).HasColumnName("PresupuestoResolucionID");
            entity.Property(e => e.ExpedienteId).HasColumnName("ExpedienteID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.NotaPedidoId).HasColumnName("NotaPedidoID");
            entity.Property(e => e.NroExpediente)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NroResolucion)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PresupuestoAnualDetalleId).HasColumnName("PresupuestoAnualDetalleID");
            entity.Property(e => e.PresupuestoResolucionEstadoId).HasColumnName("PresupuestoResolucionEstadoID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.NotaPedido).WithMany(p => p.PresupuestoResolucion)
                .HasForeignKey(d => d.NotaPedidoId)
                .HasConstraintName("FK_PresupuestoResolucion_NotaPedido");

            entity.HasOne(d => d.PresupuestoResolucionEstado).WithMany(p => p.PresupuestoResolucion)
                .HasForeignKey(d => d.PresupuestoResolucionEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoResolucion_PresupuestoResolucionEstado");
        });

        modelBuilder.Entity<PresupuestoResolucionEstado>(entity =>
        {
            entity.Property(e => e.PresupuestoResolucionEstadoId).HasColumnName("PresupuestoResolucionEstadoID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PresupuestoResolucionEstadoHistorial>(entity =>
        {
            entity.Property(e => e.PresupuestoResolucionEstadoHistorialId).HasColumnName("PresupuestoResolucionEstadoHistorialID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PresupuestoResolucionEstadoId).HasColumnName("PresupuestoResolucionEstadoID");
            entity.Property(e => e.PresupuestoResolucionId).HasColumnName("PresupuestoResolucionID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PresupuestoResolucionEstado).WithMany(p => p.PresupuestoResolucionEstadoHistorial)
                .HasForeignKey(d => d.PresupuestoResolucionEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoResolucionEstadoHistorial_PresupuestoResolucionEstado");

            entity.HasOne(d => d.PresupuestoResolucion).WithMany(p => p.PresupuestoResolucionEstadoHistorial)
                .HasForeignKey(d => d.PresupuestoResolucionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoResolucionEstadoHistorial_PresupuestoResolucion");
        });

        modelBuilder.Entity<ProcedimientoEnfermeria>(entity =>
        {
            entity.Property(e => e.ProcedimientoEnfermeriaId).HasColumnName("ProcedimientoEnfermeriaID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProcedimientoEnfermeriaDetalle>(entity =>
        {
            entity.Property(e => e.ProcedimientoEnfermeriaDetalleId).HasColumnName("ProcedimientoEnfermeriaDetalleID");
            entity.Property(e => e.ArticuloFarmaciaCisId).HasColumnName("ArticuloFarmaciaCisID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.ProcedimientoEnfermeriaId).HasColumnName("ProcedimientoEnfermeriaID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.ArticuloFarmaciaCis).WithMany(p => p.ProcedimientoEnfermeriaDetalle)
                .HasForeignKey(d => d.ArticuloFarmaciaCisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcedimientoEnfermeriaDetalle_ArticulosFarmaciaCis");

            entity.HasOne(d => d.ProcedimientoEnfermeria).WithMany(p => p.ProcedimientoEnfermeriaDetalle)
                .HasForeignKey(d => d.ProcedimientoEnfermeriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcedimientoEnfermeriaDetalle_ProcedimientoEnfermeria");
        });

        modelBuilder.Entity<Productos>(entity =>
        {
            entity.HasKey(e => e.ProductoId);

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Anulado).HasDefaultValue(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.StockMinimo).HasColumnType("decimal(18, 2)");

            entity.HasMany(d => d.Categoria).WithMany(p => p.Producto)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductosXcategorias",
                    r => r.HasOne<Categorias>().WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductosXCategorias_Categorias"),
                    l => l.HasOne<Productos>().WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductosXCategorias_Productos"),
                    j =>
                    {
                        j.HasKey("ProductoId", "CategoriaId");
                        j.ToTable("ProductosXCategorias");
                        j.IndexerProperty<int>("ProductoId").HasColumnName("ProductoID");
                        j.IndexerProperty<int>("CategoriaId").HasColumnName("CategoriaID");
                    });

            entity.HasMany(d => d.Proveedor).WithMany(p => p.Producto)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductosXproveedor",
                    r => r.HasOne<Proveedores>().WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductosXProveedor_Proveedores"),
                    l => l.HasOne<Productos>().WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductosXProveedor_Productos"),
                    j =>
                    {
                        j.HasKey("ProductoId", "ProveedorId");
                        j.ToTable("ProductosXProveedor");
                        j.IndexerProperty<int>("ProductoId").HasColumnName("ProductoID");
                        j.IndexerProperty<int>("ProveedorId").HasColumnName("ProveedorID");
                    });
        });

        modelBuilder.Entity<ProductosXdeposito>(entity =>
        {
            entity.HasKey(e => new { e.ProductoId, e.DepositoId });

            entity.ToTable("ProductosXDeposito");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.DepositoId).HasColumnName("DepositoID");
            entity.Property(e => e.LugaresDisponibles).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Deposito).WithMany(p => p.ProductosXdeposito)
                .HasForeignKey(d => d.DepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductosXDeposito_Depositos");

            entity.HasOne(d => d.Producto).WithMany(p => p.ProductosXdeposito)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductosXDeposito_Productos");
        });

        modelBuilder.Entity<Profesion>(entity =>
        {
            entity.HasKey(e => e.ProfesionId).HasName("PK_Table_1");

            entity.Property(e => e.ProfesionId).HasColumnName("ProfesionID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProveedorCategoriaPertenece>(entity =>
        {
            entity.Property(e => e.ProveedorCategoriaPerteneceId).HasColumnName("ProveedorCategoriaPerteneceID");
            entity.Property(e => e.CategoriaProveedorId).HasColumnName("CategoriaProveedorID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.CategoriaProveedor).WithMany(p => p.ProveedorCategoriaPertenece)
                .HasForeignKey(d => d.CategoriaProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedorCategoriaPertenece_CategoriaProveedor");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedorCategoriaPertenece)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedorCategoriaPertenece_Proveedores");
        });

        modelBuilder.Entity<ProveedorSancion>(entity =>
        {
            entity.Property(e => e.ProveedorSancionId).HasColumnName("ProveedorSancionID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.MotivoSancionProveedorId).HasColumnName("MotivoSancionProveedorID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.MotivoSancionProveedor).WithMany(p => p.ProveedorSancion)
                .HasForeignKey(d => d.MotivoSancionProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedorSancion_MotivoSancionProveedor");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedorSancion)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedorSancion_Proveedores");
        });

        modelBuilder.Entity<Proveedores>(entity =>
        {
            entity.HasKey(e => e.ProveedorId);

            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.Cbu)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CBU");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Cuit)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Domicilio).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Gnl)
                .HasMaxLength(14)
                .IsFixedLength()
                .HasColumnName("GNL");
            entity.Property(e => e.IdProvincia).HasDefaultValue(0);
            entity.Property(e => e.IngresosBrutos)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Ingresos_Brutos");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.NombreFantasia).HasMaxLength(100);
            entity.Property(e => e.RazonSocial).HasMaxLength(100);
            entity.Property(e => e.Responsable).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(100);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("FK_Proveedores_Provincias");
        });

        modelBuilder.Entity<Provincias>(entity =>
        {
            entity.HasKey(e => e.IdProvincia);

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Provincias)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Provincias_Paises");
        });

        modelBuilder.Entity<ProyectoEstado>(entity =>
        {
            entity.Property(e => e.ProyectoEstadoId).HasColumnName("ProyectoEstadoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuirofanoDias>(entity =>
        {
            entity.Property(e => e.QuirofanoDiasId)
                .ValueGeneratedNever()
                .HasColumnName("QuirofanoDiasID");
            entity.Property(e => e.CantidadQuirofanos).HasColumnName("Cantidad_Quirofanos");
            entity.Property(e => e.DiaId).HasColumnName("DiaID");
            entity.Property(e => e.Freciencia)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.MDesde)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("M_Desde");
            entity.Property(e => e.MHasta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("M_Hasta");
            entity.Property(e => e.TDesde)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("T_Desde");
            entity.Property(e => e.THasta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("T_Hasta");
            entity.Property(e => e.TipoCirugiaId).HasColumnName("TipoCirugiaID");

            entity.HasOne(d => d.Dia).WithMany(p => p.QuirofanoDias)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuirofanoDias_Dias");
        });

        modelBuilder.Entity<Quirofanos>(entity =>
        {
            entity.HasKey(e => e.QuirofanoId);

            entity.Property(e => e.QuirofanoId)
                .ValueGeneratedNever()
                .HasColumnName("QuirofanoID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.SalaParto).HasColumnName("Sala_Parto");
        });

        modelBuilder.Entity<RecetaIndicaciones>(entity =>
        {
            entity.HasKey(e => e.IdReceta);

            entity.Property(e => e.IdReceta).HasColumnName("idReceta");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.IdDiagnostico).HasColumnName("idDiagnostico");
            entity.Property(e => e.IdInstitucion).HasColumnName("idInstitucion");
            entity.Property(e => e.IdObraSocial).HasColumnName("idObraSocial");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.IdPrestador).HasColumnName("idPrestador");
            entity.Property(e => e.IdTurno).HasColumnName("idTurno");
            entity.Property(e => e.NroCarnet)
                .HasMaxLength(50)
                .HasColumnName("nroCarnet");
            entity.Property(e => e.ObraSocialMigrada).HasMaxLength(200);
            entity.Property(e => e.Plan)
                .HasMaxLength(50)
                .HasColumnName("plan");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCrea");
        });

        modelBuilder.Entity<RecetaIndicacionesDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalleReceta);

            entity.Property(e => e.IdDetalleReceta).HasColumnName("idDetalleReceta");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.Codigobarra)
                .HasMaxLength(100)
                .HasColumnName("codigobarra");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.IdReceta).HasColumnName("idReceta");
            entity.Property(e => e.IndicacionGral)
                .HasMaxLength(100)
                .HasColumnName("indicacionGral");
            entity.Property(e => e.NombreMedicamento).HasColumnName("nombreMedicamento");
            entity.Property(e => e.Tablaindicacionesid).HasColumnName("tablaindicacionesid");
            entity.Property(e => e.Troquel)
                .HasMaxLength(10)
                .HasColumnName("troquel");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCrea");

            entity.HasOne(d => d.IdRecetaNavigation).WithMany(p => p.RecetaIndicacionesDetalle)
                .HasForeignKey(d => d.IdReceta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecetaIndicacionesDetalle_RecetaIndicaciones");
        });

        modelBuilder.Entity<RecetaIndicacionesTurno>(entity =>
        {
            entity.HasKey(e => e.IdRecetaIndicacionesTurno);

            entity.Property(e => e.IdRecetaIndicacionesTurno).HasColumnName("idRecetaIndicacionesTurno");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.Dosis)
                .HasMaxLength(50)
                .HasColumnName("dosis");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.IdDetalleReceta).HasColumnName("idDetalleReceta");
            entity.Property(e => e.IdTurnoReceta).HasColumnName("idTurnoReceta");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCrea");

            entity.HasOne(d => d.IdDetalleRecetaNavigation).WithMany(p => p.RecetaIndicacionesTurno)
                .HasForeignKey(d => d.IdDetalleReceta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecetaIndicacionesTurno_RecetaIndicacionesTurno");
        });

        modelBuilder.Entity<RecetaIndicacionesTurnoDescripcion>(entity =>
        {
            entity.HasKey(e => e.IdTurnoReceta);

            entity.Property(e => e.IdTurnoReceta).HasColumnName("idTurnoReceta");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaAnula)
                .HasColumnType("datetime")
                .HasColumnName("fechaAnula");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.IdInstitucion).HasColumnName("idInstitucion");
            entity.Property(e => e.Letra)
                .HasMaxLength(2)
                .HasColumnName("letra");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCrea");
        });

        modelBuilder.Entity<RegistroHistorialCambioSector>(entity =>
        {
            entity.HasKey(e => e.RegistroHistCambioSectorId);

            entity.Property(e => e.RegistroHistCambioSectorId).HasColumnName("RegistroHistCambioSectorID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoId).HasColumnName("MotivoID");
            entity.Property(e => e.NodoTipoAntId).HasColumnName("NodoTipoAntID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<RegistroModificaciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OperadorActualiza).HasMaxLength(11);
            entity.Property(e => e.TipoActualizacionId).HasColumnName("TipoActualizacionID");
            entity.Property(e => e.TipoEntidadId).HasColumnName("TipoEntidadID");
        });

        modelBuilder.Entity<RegistroPedidosPendientes>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Tr_AsignacionCamaPacienteGuardia"));

            entity.HasIndex(e => new { e.InstitucionId, e.DestinoPedidoId, e.OrigenPedidoId, e.Anulado, e.DestinoRegistroId, e.OrigenRegistroId, e.PacienteId, e.RegistroPedidosPendientesId }, "_dta_index_RegistroPedidosPendientes_6_1091587027__K13_K4_K2_K9_K5_K3_K12_K1_8_14");

            entity.HasIndex(e => new { e.InstitucionId, e.DestinoPedidoId, e.DestinoRegistroId, e.OrigenPedidoId, e.Anulado, e.OrigenRegistroId, e.RegistroPedidosPendientesId }, "_dta_index_RegistroPedidosPendientes_6_1091587027__K13_K4_K5_K2_K9_K3_K1");

            entity.Property(e => e.RegistroPedidosPendientesId).HasColumnName("RegistroPedidosPendientesID");
            entity.Property(e => e.DestinoPedidoId).HasColumnName("DestinoPedidoID");
            entity.Property(e => e.DestinoRegistroId).HasColumnName("DestinoRegistroID");
            entity.Property(e => e.FechaAplica).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.OrigenPedidoId).HasColumnName("OrigenPedidoID");
            entity.Property(e => e.OrigenRegistroId).HasColumnName("OrigenRegistroID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.UsuarioAplica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<RegistroPracticaDetalle>(entity =>
        {
            entity.HasKey(e => e.RegistroPracticaDetId);

            entity.Property(e => e.RegistroPracticaDetId).HasColumnName("RegistroPracticaDetID");
            entity.Property(e => e.Codigo).HasMaxLength(30);
            entity.Property(e => e.Nombre).HasMaxLength(300);
            entity.Property(e => e.PracticaId).HasColumnName("PracticaID");
            entity.Property(e => e.RegistroPracticaId).HasColumnName("RegistroPracticaID");
        });

        modelBuilder.Entity<RegistroPracticas>(entity =>
        {
            entity.HasKey(e => e.RegistroPracticaId);

            entity.Property(e => e.RegistroPracticaId).HasColumnName("RegistroPracticaID");
            entity.Property(e => e.Diagnostico).HasMaxLength(200);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaPrescripcion).HasColumnType("datetime");
            entity.Property(e => e.GuardiaId).HasColumnName("GuardiaID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.Observacion).HasMaxLength(500);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PaseId).HasColumnName("PaseID");
            entity.Property(e => e.PaseNombre).HasMaxLength(200);
            entity.Property(e => e.PlanId).HasColumnName("PlanID");
            entity.Property(e => e.PlanNombre).HasMaxLength(200);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<RegistrosContingente>(entity =>
        {
            entity.HasKey(e => e.RegistroContingenteId).HasName("PK_RegistrosAdmision");

            entity.Property(e => e.RegistroContingenteId).HasColumnName("RegistroContingenteID");
            entity.Property(e => e.EmpresaColectivoId).HasColumnName("EmpresaColectivoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaArribo).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaConfirmaArribo).HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.ProvinciaOrigenId).HasColumnName("ProvinciaOrigenID");
            entity.Property(e => e.TipoVehiculoId).HasColumnName("TipoVehiculoID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioConfirma)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<ReportSchemas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ReportSchemas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AirFilterMachine).HasColumnName("air_filter_machine");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.DefibrillatorsAdults).HasColumnName("defibrillators_adults");
            entity.Property(e => e.DefibrillatorsChildren).HasColumnName("defibrillators_children");
            entity.Property(e => e.MultiMonitorAdults).HasColumnName("multi_monitor_adults");
            entity.Property(e => e.MultiMonitorChildren).HasColumnName("multi_monitor_children");
            entity.Property(e => e.Other).HasColumnName("other");
            entity.Property(e => e.RespiratorsAdults).HasColumnName("respirators_adults");
            entity.Property(e => e.RespiratorsAllocatedAdult).HasColumnName("respirators_allocated_adult");
            entity.Property(e => e.RespiratorsAllocatedChildren).HasColumnName("respirators_allocated_children");
            entity.Property(e => e.RespiratorsAvailableAdultCount).HasColumnName("respirators_available_adult_count");
            entity.Property(e => e.RespiratorsAvailableChildrenCount).HasColumnName("respirators_available_children_count");
            entity.Property(e => e.RespiratorsChildren).HasColumnName("respirators_children");
            entity.Property(e => e.RespiratorsUnavailableAdultCount).HasColumnName("respirators_unavailable_adult_count");
            entity.Property(e => e.RespiratorsUnavailableChildrenCount).HasColumnName("respirators_unavailable_children_count");
            entity.Property(e => e.SuccessReportSalesforce).HasColumnName("success_report_salesforce");
            entity.Property(e => e.UtiAllocatedAdult).HasColumnName("uti_allocated_adult");
            entity.Property(e => e.UtiAllocatedAdultGas).HasColumnName("uti_allocated_adult_gas");
            entity.Property(e => e.UtiAllocatedChildren).HasColumnName("uti_allocated_children");
            entity.Property(e => e.UtiAllocatedChildrenGas).HasColumnName("uti_allocated_children_gas");
            entity.Property(e => e.UtiDischargedAdultCount).HasColumnName("uti_discharged_adult_count");
            entity.Property(e => e.UtiDischargedChildrenCount).HasColumnName("uti_discharged_children_count");
            entity.Property(e => e.UtiDischargedDeadAdultCount).HasColumnName("uti_discharged_dead_adult_count");
            entity.Property(e => e.UtiDischargedDeadChildrenCount).HasColumnName("uti_discharged_dead_children_count");
            entity.Property(e => e.UtiDischargedDerivativeAdultCount).HasColumnName("uti_discharged_derivative_adult_count");
            entity.Property(e => e.UtiDischargedDerivativeChildrenCount).HasColumnName("uti_discharged_derivative_children_count");
            entity.Property(e => e.UtiGasAvailableAdultCount).HasColumnName("uti_gas_available_adult_count");
            entity.Property(e => e.UtiGasAvailableChildrenCount).HasColumnName("uti_gas_available_children_count");
            entity.Property(e => e.UtiGasUnavailableAdultCount).HasColumnName("uti_gas_unavailable_adult_count");
            entity.Property(e => e.UtiGasUnavailableChildrenCount).HasColumnName("uti_gas_unavailable_children_count");
            entity.Property(e => e.UtiHospitalizedAdultCount).HasColumnName("uti_hospitalized_adult_count");
            entity.Property(e => e.UtiHospitalizedChildrenCount).HasColumnName("uti_hospitalized_children_count");
            entity.Property(e => e.UtiIntensive).HasColumnName("uti_intensive");
            entity.Property(e => e.VolInfPumps).HasColumnName("vol_inf_pumps");
        });

        modelBuilder.Entity<Respiradores>(entity =>
        {
            entity.HasKey(e => e.RespiradorId);

            entity.Property(e => e.RespiradorId).HasColumnName("RespiradorID");
            entity.Property(e => e.EstadoEquipoId).HasColumnName("EstadoEquipoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Modelo).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.OpAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<RespuestasDeFormulario1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Respuestas de formulario 1$'");

            entity.Property(e => e.Abdomen)
                .HasMaxLength(255)
                .HasColumnName(" (Abdomen)");
            entity.Property(e => e.ActividadFísica)
                .HasMaxLength(255)
                .HasColumnName("Actividad Física");
            entity.Property(e => e.AlgunoDeLosDatosConAnormalesSeDeriva)
                .HasMaxLength(255)
                .HasColumnName("Alguno de los datos con * anormales, se deriva");
            entity.Property(e => e.AlgunoDeLosDatosConConHallazgosAnormales)
                .HasMaxLength(255)
                .HasColumnName("Alguno de los datos con ** con hallazgos anormales");
            entity.Property(e => e.AlimentaciónSaludable)
                .HasMaxLength(255)
                .HasColumnName("Alimentación saludable");
            entity.Property(e => e.AnteUnÍtemIdentificadoConDaPositivoSeComunicaAlMéd)
                .HasMaxLength(255)
                .HasColumnName("Ante un ítem identificado con * da positivo, se  comunica al méd");
            entity.Property(e => e.AntecedentesParaCovid19Diabetes)
                .HasMaxLength(255)
                .HasColumnName("Antecedentes para COVID 19 (Diabetes)");
            entity.Property(e => e.AntecedentesParaCovid19EnfermedadCv)
                .HasMaxLength(255)
                .HasColumnName("Antecedentes para COVID 19 (Enfermedad CV)");
            entity.Property(e => e.AntecedentesParaCovid19EnfermedadRenalCrónica)
                .HasMaxLength(255)
                .HasColumnName("Antecedentes para COVID 19 (Enfermedad Renal Crónica)");
            entity.Property(e => e.AntecedentesParaCovid19EpocAsma)
                .HasMaxLength(255)
                .HasColumnName("Antecedentes para COVID 19 (EPOC/Asma)");
            entity.Property(e => e.AntecedentesParaCovid19Inmunocomprometido)
                .HasMaxLength(255)
                .HasColumnName("Antecedentes para COVID 19 (Inmunocomprometido)");
            entity.Property(e => e.AntecedentesParaCovid19ObesidadMórbida)
                .HasMaxLength(255)
                .HasColumnName("Antecedentes para COVID 19 (Obesidad Mórbida)");
            entity.Property(e => e.ApellidoYNombre)
                .HasMaxLength(255)
                .HasColumnName("Apellido y Nombre");
            entity.Property(e => e.AplicaciónDeTratamiento)
                .HasMaxLength(255)
                .HasColumnName("Aplicación de tratamiento ");
            entity.Property(e => e.AspectoGeneral)
                .HasMaxLength(255)
                .HasColumnName(" (Aspecto General)");
            entity.Property(e => e.BañoInstaladoEnElDomicilio)
                .HasMaxLength(255)
                .HasColumnName("Baño instalado en el domicilio");
            entity.Property(e => e.ConvivienteQuePertenezcaAlGrupoDeRiesgoDeCovid19)
                .HasMaxLength(255)
                .HasColumnName("Conviviente que pertenezca al grupo de riesgo de COVID 19");
            entity.Property(e => e.DificultadRespiratoria)
                .HasMaxLength(255)
                .HasColumnName("Dificultad respiratoria*");
            entity.Property(e => e.Documento).HasMaxLength(255);
            entity.Property(e => e.Domicilio).HasMaxLength(255);
            entity.Property(e => e.Edad).HasMaxLength(255);
            entity.Property(e => e.EdadMenorDe65Años)
                .HasMaxLength(255)
                .HasColumnName(" (Edad menor de 65 años**)");
            entity.Property(e => e.EgresoDelNodoAislamientoPreventivoEnDomicilioAl14Día)
                .HasMaxLength(255)
                .HasColumnName("Egreso del Nodo (Aislamiento Preventivo en Domicilio al 14° día)");
            entity.Property(e => e.EgresoDelNodoAislamientoPreventivoEnDomicilioAl7Día)
                .HasMaxLength(255)
                .HasColumnName("Egreso del Nodo (Aislamiento Preventivo en Domicilio al 7° día)");
            entity.Property(e => e.EgresoDelNodoAltaDelNodo)
                .HasMaxLength(255)
                .HasColumnName("Egreso del Nodo (Alta del Nodo)");
            entity.Property(e => e.EgresoDelNodoDerivaciónAInternación)
                .HasMaxLength(255)
                .HasColumnName("Egreso del Nodo (Derivación a internación)");
            entity.Property(e => e.EgresoDelNodoOtro)
                .HasMaxLength(255)
                .HasColumnName("Egreso del Nodo (Otro)");
            entity.Property(e => e.EntradaDeAire)
                .HasMaxLength(255)
                .HasColumnName(" (Entrada de aire**)");
            entity.Property(e => e.F129).HasMaxLength(255);
            entity.Property(e => e.F130).HasMaxLength(255);
            entity.Property(e => e.F131).HasMaxLength(255);
            entity.Property(e => e.F132).HasMaxLength(255);
            entity.Property(e => e.F133).HasMaxLength(255);
            entity.Property(e => e.F134).HasMaxLength(255);
            entity.Property(e => e.Fc60A100L)
                .HasMaxLength(255)
                .HasColumnName(" (FC 60 a 100 l/´)");
            entity.Property(e => e.FcO30X)
                .HasMaxLength(255)
                .HasColumnName(" (FC > o = 30 x´**)");
            entity.Property(e => e.Fecha).HasMaxLength(255);
            entity.Property(e => e.FechaDeApertura)
                .HasColumnType("datetime")
                .HasColumnName("Fecha de Apertura");
            entity.Property(e => e.FechaDeNacimiento)
                .HasMaxLength(255)
                .HasColumnName("Fecha de Nacimiento ");
            entity.Property(e => e.FechaDelControl)
                .HasMaxLength(255)
                .HasColumnName("Fecha del control");
            entity.Property(e => e.FrO30x)
                .HasMaxLength(255)
                .HasColumnName("FR > o  30x´*");
            entity.Property(e => e.HabitacionesSinContarBañoNiCocina)
                .HasMaxLength(255)
                .HasColumnName("Habitaciones, sin contar baño ni cocina");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdentificaciónDeTipoDeAislamiento)
                .HasMaxLength(255)
                .HasColumnName("Identificación de tipo de aislamiento");
            entity.Property(e => e.Imc)
                .HasMaxLength(255)
                .HasColumnName(" (IMC)");
            entity.Property(e => e.IngresaAlNodo)
                .HasMaxLength(255)
                .HasColumnName("Ingresa al NODO");
            entity.Property(e => e.InmunizacionesSegúnCalendarioOtra)
                .HasMaxLength(255)
                .HasColumnName("Inmunizaciones según calendario (Otra)");
            entity.Property(e => e.InmunizacionesSegúnCalendarioVacunaAntigripal)
                .HasMaxLength(255)
                .HasColumnName("Inmunizaciones según calendario (Vacuna antigripal)");
            entity.Property(e => e.InmunizacionesSegúnCalendarioVacunaContraHb)
                .HasMaxLength(255)
                .HasColumnName("Inmunizaciones según calendario (Vacuna contra HB)");
            entity.Property(e => e.InmunizacionesSegúnCalendarioVacunaDobleBacteriana)
                .HasMaxLength(255)
                .HasColumnName("Inmunizaciones según calendario (Vacuna Doble Bacteriana)");
            entity.Property(e => e.Localidad).HasMaxLength(255);
            entity.Property(e => e.LugarDeProcedencia)
                .HasMaxLength(255)
                .HasColumnName("Lugar de Procedencia");
            entity.Property(e => e.MarcaTemporal)
                .HasColumnType("datetime")
                .HasColumnName("Marca temporal");
            entity.Property(e => e.MedidasAntropométricasImc)
                .HasMaxLength(255)
                .HasColumnName("Medidas antropométricas: IMC");
            entity.Property(e => e.MedidasAntropométricasPerímetroAbdominal)
                .HasMaxLength(255)
                .HasColumnName("Medidas antropométricas: Perímetro Abdominal");
            entity.Property(e => e.MedidasAntropométricasPeso)
                .HasMaxLength(255)
                .HasColumnName("Medidas antropométricas: Peso");
            entity.Property(e => e.MedidasAntropométricasTalla)
                .HasMaxLength(255)
                .HasColumnName("Medidas antropométricas: Talla");
            entity.Property(e => e.NDeDocumentoNacionalDeIdentidad).HasColumnName("N° de Documento Nacional de Identidad");
            entity.Property(e => e.NDeTeléfonoCelular)
                .HasMaxLength(255)
                .HasColumnName("N° de teléfono celular");
            entity.Property(e => e.NDeTeléfonoFijo)
                .HasMaxLength(255)
                .HasColumnName("N° de teléfono fijo");
            entity.Property(e => e.NoName).HasMaxLength(255);
            entity.Property(e => e.NúmeroDeConvivientesEnElDomicilioDondeRealizaríaLaCuare)
                .HasMaxLength(255)
                .HasColumnName("Número de convivientes en el domicilio donde realizaría la cuare");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("*Observaciones");
            entity.Property(e => e.Observaciones1)
                .HasMaxLength(255)
                .HasColumnName("Observaciones");
            entity.Property(e => e.Observaciones11)
                .HasMaxLength(255)
                .HasColumnName("Observaciones1");
            entity.Property(e => e.Observaciones2).HasMaxLength(255);
            entity.Property(e => e.Observaciones3).HasMaxLength(255);
            entity.Property(e => e.Observaciones4).HasMaxLength(255);
            entity.Property(e => e.Observaciones5).HasMaxLength(255);
            entity.Property(e => e.ObservacionesEnCasoDeTenerAlgúnAntecedentePersonalIn)
                .HasMaxLength(255)
                .HasColumnName("Observaciones: en caso de tener algún antecedente personal--> in");
            entity.Property(e => e.ObservacionesEnCasoDeTenerAlgúnAntecedentePersonalInclu)
                .HasMaxLength(255)
                .HasColumnName("Observaciones: en caso de tener algún antecedente personal inclu");
            entity.Property(e => e.OrientadoEnTiempoYEspacio)
                .HasMaxLength(255)
                .HasColumnName(" (Orientado en tiempo y espacio**)");
            entity.Property(e => e.Otro).HasMaxLength(255);
            entity.Property(e => e.Otro1)
                .HasMaxLength(255)
                .HasColumnName(" (Otro)");
            entity.Property(e => e.OtrosAntecedentesAdicciónADrogasIlícitas)
                .HasMaxLength(255)
                .HasColumnName("Otros Antecedentes (Adicción a drogas ilícitas)");
            entity.Property(e => e.OtrosAntecedentesAlcoholismo)
                .HasMaxLength(255)
                .HasColumnName("Otros Antecedentes (Alcoholismo)");
            entity.Property(e => e.OtrosAntecedentesAlergias)
                .HasMaxLength(255)
                .HasColumnName("Otros Antecedentes (Alergias)");
            entity.Property(e => e.OtrosAntecedentesOtro)
                .HasMaxLength(255)
                .HasColumnName("Otros Antecedentes (Otro)");
            entity.Property(e => e.OtrosAntecedentesProblemasPsicológicosYOPsiquiátricos)
                .HasMaxLength(255)
                .HasColumnName("Otros Antecedentes (Problemas Psicológicos y/o Psiquiátricos)");
            entity.Property(e => e.OtrosAntecedentesTabaquismo)
                .HasMaxLength(255)
                .HasColumnName("Otros Antecedentes (Tabaquismo)");
            entity.Property(e => e.OtrosAntecedentesViolencia)
                .HasMaxLength(255)
                .HasColumnName("Otros Antecedentes (Violencia)");
            entity.Property(e => e.OtrosSíntomasCovid19AnosmiaDeRecienteAparición)
                .HasMaxLength(255)
                .HasColumnName("Otros síntomas COVID 19 (Anosmia de reciente aparición)");
            entity.Property(e => e.OtrosSíntomasCovid19DificultadRespiratoria)
                .HasMaxLength(255)
                .HasColumnName("Otros síntomas COVID 19 (Dificultad respiratoria)");
            entity.Property(e => e.OtrosSíntomasCovid19DisgeusiaDeRecienteAparición)
                .HasMaxLength(255)
                .HasColumnName("Otros síntomas COVID 19 (Disgeusia de reciente aparición)");
            entity.Property(e => e.OtrosSíntomasCovid19Odinofagia)
                .HasMaxLength(255)
                .HasColumnName("Otros síntomas COVID 19 (Odinofagia)");
            entity.Property(e => e.OtrosSíntomasCovid19Otro)
                .HasMaxLength(255)
                .HasColumnName("Otros síntomas COVID 19 (Otro)");
            entity.Property(e => e.OtrosSíntomasCovid19Tos)
                .HasMaxLength(255)
                .HasColumnName("Otros síntomas COVID 19 (Tos)");
            entity.Property(e => e.Pa9060MmHg)
                .HasMaxLength(255)
                .HasColumnName("PA < 90/60 mmHg*");
            entity.Property(e => e.Pa9060mmHg1)
                .HasMaxLength(255)
                .HasColumnName(" (PA >90/60mmHg**)");
            entity.Property(e => e.PartesBlandas)
                .HasMaxLength(255)
                .HasColumnName(" (Partes Blandas)");
            entity.Property(e => e.PielYFaneras)
                .HasMaxLength(255)
                .HasColumnName(" (Piel y Faneras)");
            entity.Property(e => e.PosibilidadDeAislamientoEnDomicilio)
                .HasMaxLength(255)
                .HasColumnName("Posibilidad de aislamiento en domicilio");
            entity.Property(e => e.ProcedeDelGrupoDelQueSeDerivóUnPacienteAlHospitalPor)
                .HasMaxLength(255)
                .HasColumnName("Procede del grupo del que se derivó un paciente al hospital por ");
            entity.Property(e => e.ProfesiónUOficio)
                .HasMaxLength(255)
                .HasColumnName("Profesión u Oficio");
            entity.Property(e => e.RastreoDeAlcoholismoAlgunaVezLoPrimeroQueHaHechoPor)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Alcoholismo (¿alguna vez lo primero que ha hecho por ");
            entity.Property(e => e.RastreoDeAlcoholismoHaTenidoAlgunaVezLaImpresiónDeQu)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Alcoholismo (¿ha tenido alguna vez la impresión de qu");
            entity.Property(e => e.RastreoDeAlcoholismoLeHaMolestadoAlgunaVezLaGenteCri)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Alcoholismo (¿le ha molestado alguna vez la gente cri");
            entity.Property(e => e.RastreoDeAlcoholismoSeHaSentidoAlgunaVezCulpablePorS)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Alcoholismo (¿se ha sentido alguna vez culpable por s");
            entity.Property(e => e.RastreoDeCáncerDeColonÚltimoSomf)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Cáncer de Colon: último SOMF");
            entity.Property(e => e.RastreoDeCáncerDeCuelloUterinoÚltimoPap)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Cáncer de Cuello Uterino: último PAP");
            entity.Property(e => e.RastreoDeCáncerDeMamaÚltimaMamografía)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Cáncer de Mama: última mamografía");
            entity.Property(e => e.RastreoDeDbtÚltimoControlDeGlucemiaEnAyunas)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de DBT: último control de glucemia en ayunas");
            entity.Property(e => e.RastreoDeHtaPaO14090MmHg)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de HTA: PA > o = 140/90 mmHg");
            entity.Property(e => e.RastreoDeObesidadImc30)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Obesidad: IMC >30");
            entity.Property(e => e.RastreoDeTabaquismo)
                .HasMaxLength(255)
                .HasColumnName("Rastreo de Tabaquismo");
            entity.Property(e => e.RestoDeExamenCardiovascular)
                .HasMaxLength(255)
                .HasColumnName(" (Resto de Examen Cardiovascular)");
            entity.Property(e => e.RestoDeExamenNeurológico)
                .HasMaxLength(255)
                .HasColumnName(" (Resto de Examen Neurológico)");
            entity.Property(e => e.RestoDeExamenRespiratorio)
                .HasMaxLength(255)
                .HasColumnName(" (Resto de Examen Respiratorio)");
            entity.Property(e => e.ResultadoDeHisopado14Día)
                .HasMaxLength(255)
                .HasColumnName("Resultado de Hisopado (14° día)");
            entity.Property(e => e.ResultadoDeHisopado1Día)
                .HasMaxLength(255)
                .HasColumnName("Resultado de Hisopado (1° día)");
            entity.Property(e => e.ResultadoDeHisopado3Día)
                .HasMaxLength(255)
                .HasColumnName("Resultado de Hisopado (3° día)");
            entity.Property(e => e.ResultadoDeHisopado7Día)
                .HasMaxLength(255)
                .HasColumnName("Resultado de Hisopado (7° día)");
            entity.Property(e => e.ResultadoDeHisopadoOtro)
                .HasMaxLength(255)
                .HasColumnName("Resultado de Hisopado (Otro)");
            entity.Property(e => e.ResultadoDeMamografía)
                .HasMaxLength(255)
                .HasColumnName("Resultado de mamografía");
            entity.Property(e => e.ResultadoDeÚltimaGlucemia)
                .HasMaxLength(255)
                .HasColumnName("Resultado de última glucemia");
            entity.Property(e => e.ResultadoDeÚltimoPap)
                .HasMaxLength(255)
                .HasColumnName("Resultado de último PAP");
            entity.Property(e => e.Saturometría93)
                .HasMaxLength(255)
                .HasColumnName(" (Saturometría >93%*)");
            entity.Property(e => e.SaturometríaO92)
                .HasMaxLength(255)
                .HasColumnName("Saturometría < o = 92%*");
            entity.Property(e => e.SeRedireccionaAlNodo)
                .HasMaxLength(255)
                .HasColumnName("Se redirecciona al NODO");
            entity.Property(e => e.SiIdentificóOtroEnElLugarDeProcedenciaEspecificarCuá)
                .HasMaxLength(255)
                .HasColumnName("Si identificó \"Otro\" en el lugar de procedencia, especificar cuá");
            entity.Property(e => e.SiRespondeDeManeraAfirmativaALaPreguntaAnteriorEspecif)
                .HasMaxLength(255)
                .HasColumnName("Si responde de manera afirmativa a la pregunta anterior, especif");
            entity.Property(e => e.SiRespondióOtroEnLaPreguntaAnteriorMencioneCuál)
                .HasMaxLength(255)
                .HasColumnName("Si respondió \"otro\" en la pregunta anterior, mencione cuál");
            entity.Property(e => e.SignosDeDerivaciónOtro)
                .HasMaxLength(255)
                .HasColumnName("Signos de derivación (Otro)");
            entity.Property(e => e.SignosDeDerivaciónSaturometría95)
                .HasMaxLength(255)
                .HasColumnName("Signos de derivación (Saturometría < 95%)");
            entity.Property(e => e.SignosDeDerivaciónTemperaturaO375C)
                .HasMaxLength(255)
                .HasColumnName("Signos de derivación (Temperatura > o = 37,5°C)");
            entity.Property(e => e.SignosVitalesFc)
                .HasMaxLength(255)
                .HasColumnName("Signos Vitales: FC ");
            entity.Property(e => e.SignosVitalesFr)
                .HasMaxLength(255)
                .HasColumnName("Signos Vitales: FR");
            entity.Property(e => e.SignosVitalesSaturometría)
                .HasMaxLength(255)
                .HasColumnName("Signos Vitales: Saturometría");
            entity.Property(e => e.SignosVitalesT)
                .HasMaxLength(255)
                .HasColumnName("Signos Vitales: T°");
            entity.Property(e => e.SignosVitalesTa)
                .HasMaxLength(255)
                .HasColumnName("Signos Vitales: TA ");
            entity.Property(e => e.TO375C)
                .HasMaxLength(255)
                .HasColumnName("T° > o = 37,5°C *");
            entity.Property(e => e.Temperatura375C)
                .HasMaxLength(255)
                .HasColumnName(" (Temperatura < 37,5°C *)");
            entity.Property(e => e.TipoDeVivienda)
                .HasMaxLength(255)
                .HasColumnName("Tipo de vivienda");
            entity.Property(e => e.TomaDeMuestraDeHisopado)
                .HasMaxLength(255)
                .HasColumnName("Toma de muestra de Hisopado");
            entity.Property(e => e.TrabajoOTareaQueDesempeñabaAntesDeLaConsulta)
                .HasMaxLength(255)
                .HasColumnName("Trabajo o Tarea que desempeñaba antes de la consulta");
        });

        modelBuilder.Entity<ResultadosInformes>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Idarq).HasColumnName("IDARQ");
            entity.Property(e => e.Iddat).HasColumnName("IDDAT");
            entity.Property(e => e.Idtipodato).HasColumnName("IDTIPODATO");
            entity.Property(e => e.ResultadoInformeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ResultadoInformeID");
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(128)
                .HasColumnName("UsuarioID");
        });

        modelBuilder.Entity<RevistaSala>(entity =>
        {
            entity.ToTable("Revista_Sala");

            entity.Property(e => e.RevistaSalaId).HasColumnName("RevistaSalaID");
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoRevistaSalaId).HasColumnName("TipoRevistaSalaID");

            entity.HasOne(d => d.Internacion).WithMany(p => p.RevistaSala)
                .HasForeignKey(d => d.InternacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Revista_Sala_Internaciones");

            entity.HasOne(d => d.TipoRevistaSala).WithMany(p => p.RevistaSala)
                .HasForeignKey(d => d.TipoRevistaSalaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Revista_Sala_Tipo_RevistaSala");
        });

        modelBuilder.Entity<RevistaSalaObstetricia>(entity =>
        {
            entity.HasKey(e => e.RevistaSalaObstetricia1);

            entity.ToTable("RevistaSala_Obstetricia");

            entity.Property(e => e.RevistaSalaObstetricia1).HasColumnName("RevistaSalaObstetricia");
            entity.Property(e => e.AbdemenToleraAlimentacion).HasColumnName("Abdemen_ToleraAlimentacion");
            entity.Property(e => e.AbdeomenReaccionPeritoneal).HasColumnName("Abdeomen_ReaccionPeritoneal");
            entity.Property(e => e.AbdomenBando).HasColumnName("Abdomen_Bando");
            entity.Property(e => e.AbdomenCatarsis).HasColumnName("Abdomen_Catarsis");
            entity.Property(e => e.AbdomenConDefensa).HasColumnName("Abdomen_ConDefensa");
            entity.Property(e => e.AbdomenDepresible).HasColumnName("Abdomen_Depresible");
            entity.Property(e => e.AbdomenDoloroso).HasColumnName("Abdomen_Doloroso");
            entity.Property(e => e.AbdomenRha).HasColumnName("Abdomen_RHA");
            entity.Property(e => e.LoquiosAbundantes).HasColumnName("Loquios_Abundantes");
            entity.Property(e => e.LoquiosFetidos).HasColumnName("Loquios_fetidos");
            entity.Property(e => e.LoquiosHematicos).HasColumnName("Loquios_Hematicos");
            entity.Property(e => e.MamasLactancia).HasColumnName("Mamas_Lactancia");
            entity.Property(e => e.MamasSecretantes).HasColumnName("Mamas_Secretantes");
            entity.Property(e => e.MiembroInferior).HasColumnName("Miembro_Inferior");
            entity.Property(e => e.PerineCicatrizacion).HasColumnName("Perine_Cicatrizacion");
            entity.Property(e => e.PerineEpisiorafia).HasColumnName("Perine_Episiorafia");
            entity.Property(e => e.PerineIndemne).HasColumnName("Perine_Indemne");
            entity.Property(e => e.RevistaSalaId).HasColumnName("RevistaSalaID");
            entity.Property(e => e.TensionArterialMaxima).HasColumnName("Tension_ArterialMaxima");
            entity.Property(e => e.TensionArterialMinima).HasColumnName("Tension_ArterialMinima");
            entity.Property(e => e.TipoMamasId).HasColumnName("TipoMamasID");
            entity.Property(e => e.UteroInvolucionado).HasColumnName("Utero_Involucionado");
            entity.Property(e => e.UteroRetraido).HasColumnName("Utero_Retraido");

            entity.HasOne(d => d.MiembroInferiorNavigation).WithMany(p => p.RevistaSalaObstetricia)
                .HasForeignKey(d => d.MiembroInferior)
                .HasConstraintName("FK_RevistaSala_Obstetricia_Tipo_NormalAlterado");

            entity.HasOne(d => d.RevistaSala).WithMany(p => p.RevistaSalaObstetricia)
                .HasForeignKey(d => d.RevistaSalaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RevistaSala_Obstetricia_Revista_Sala");

            entity.HasOne(d => d.TipoMamas).WithMany(p => p.RevistaSalaObstetricia)
                .HasForeignKey(d => d.TipoMamasId)
                .HasConstraintName("FK_RevistaSala_Obstetricia_Tipo_Mamas");
        });

        modelBuilder.Entity<SatuacionRn>(entity =>
        {
            entity.HasKey(e => e.SaturacionId);

            entity.ToTable("SatuacionRN");

            entity.Property(e => e.SaturacionId).HasColumnName("SaturacionID");
            entity.Property(e => e.AnamnesisRnid).HasColumnName("AnamnesisRNID");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_hora");
        });

        modelBuilder.Entity<SectorPedidoInternoXusuario>(entity =>
        {
            entity.ToTable("SectorPedidoInternoXUsuario");

            entity.Property(e => e.SectorPedidoInternoXusuarioId).HasColumnName("SectorPedidoInternoXUsuarioID");
            entity.Property(e => e.FechaAnulado).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.PedidoSectorId).HasColumnName("PedidoSectorID");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UsuarioAnulado)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(11)
                .IsFixedLength();

            entity.HasOne(d => d.PedidoSector).WithMany(p => p.SectorPedidoInternoXusuario)
                .HasForeignKey(d => d.PedidoSectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SectorPedidoInternoXUsuario_PedidoSector");
        });

        modelBuilder.Entity<SectorPlanificacion>(entity =>
        {
            entity.Property(e => e.SectorPlanificacionId).HasColumnName("SectorPlanificacionID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.SectorId).HasColumnName("SectorID");
        });

        modelBuilder.Entity<SectoresHospital>(entity =>
        {
            entity.HasKey(e => e.SectorId);

            entity.ToTable("Sectores_Hospital");

            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<SectoresHospitalXusuario>(entity =>
        {
            entity.HasKey(e => e.SectoresHospitalXusuariosId);

            entity.ToTable("SectoresHospitalXUsuario");

            entity.Property(e => e.SectoresHospitalXusuariosId).HasColumnName("SectoresHospitalXUsuariosID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Servicios>(entity =>
        {
            entity.HasKey(e => e.ServicioId);

            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.ColorFilas).HasMaxLength(30);
            entity.Property(e => e.EspecilidadId).HasColumnName("EspecilidadID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Planificable).HasDefaultValue(false);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.SePlanificaSolo).HasDefaultValue(false);
            entity.Property(e => e.ServAdmisiona).HasDefaultValue(false);
            entity.Property(e => e.ServicioIdoriginal).HasColumnName("ServicioIDOriginal");
            entity.Property(e => e.SexoId).HasColumnName("SexoID");
            entity.Property(e => e.TiempoAtencionAperturaVentana).HasDefaultValue(true);
            entity.Property(e => e.TipoPacienteId).HasColumnName("TipoPacienteID");
            entity.Property(e => e.TipoPedidoId).HasColumnName("TipoPedidoID");
            entity.Property(e => e.TipoPracticaId).HasColumnName("TipoPracticaID");
            entity.Property(e => e.TipoServicioAmbId).HasColumnName("TipoServicioAmbID");
            entity.Property(e => e.UltimaMod)
                .HasColumnType("datetime")
                .HasColumnName("ultimaMod");
            entity.Property(e => e.UsuarioBaja)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioBaja");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioCarga");
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("usuarioMod");

            entity.HasOne(d => d.Especilidad).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.EspecilidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Servicios_Especialidades");
        });

        modelBuilder.Entity<ServiciosDias>(entity =>
        {
            entity.HasKey(e => e.ServiociosDiasId);

            entity.Property(e => e.ServiociosDiasId).HasColumnName("ServiociosDiasID");
            entity.Property(e => e.CantidadConsultorios)
                .HasDefaultValue((byte)1)
                .HasColumnName("Cantidad_Consultorios");
            entity.Property(e => e.Demanda).HasDefaultValue(false);
            entity.Property(e => e.DiaId).HasColumnName("DiaID");
            entity.Property(e => e.Frecuencia)
                .HasMaxLength(2)
                .HasDefaultValue("15")
                .IsFixedLength();
            entity.Property(e => e.Frecuencia2)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Frecuencia3)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.MDesde)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("M_Desde");
            entity.Property(e => e.MHasta)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("M_Hasta");
            entity.Property(e => e.NDesde)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("N_Desde");
            entity.Property(e => e.NHasta)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("N_Hasta");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.ServiciosDiasIdoriginal).HasColumnName("ServiciosDiasIDOriginal");
            entity.Property(e => e.TDesde)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("T_Desde");
            entity.Property(e => e.THasta)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("T_Hasta");
            entity.Property(e => e.Turnos).HasDefaultValue((short)0);

            entity.HasOne(d => d.Dia).WithMany(p => p.ServiciosDias)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiciosDias_Dias");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ServiciosDias)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiciosDias_Servicios");
        });

        modelBuilder.Entity<ServiciosXroles>(entity =>
        {
            entity.ToTable("ServiciosXRoles");

            entity.Property(e => e.ServiciosXrolesId).HasColumnName("ServiciosXRolesID");
            entity.Property(e => e.RoleId).HasMaxLength(128);
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
        });

        modelBuilder.Entity<ServiciosXusuario>(entity =>
        {
            entity.ToTable("ServiciosXUsuario");

            entity.Property(e => e.ServiciosXusuarioId).HasColumnName("ServiciosXUsuarioID");
            entity.Property(e => e.FechaAnulado).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.RolId)
                .HasMaxLength(128)
                .HasColumnName("RolID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.ServiciosXusuarioIdoriginal).HasColumnName("ServiciosXUsuarioIDOriginal");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UsuarioAnulado)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Sexo>(entity =>
        {
            entity.HasKey(e => e.IdSexo);

            entity.Property(e => e.IdSexo).ValueGeneratedOnAdd();
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<ShockRoomAnamnesis>(entity =>
        {
            entity.HasKey(e => e.ShockRoomAnamnesisId).HasName("PK_SockRomm_Anamnesis");

            entity.ToTable("ShockRoom_Anamnesis");

            entity.Property(e => e.ShockRoomAnamnesisId).HasColumnName("ShockRoom_AnamnesisID");
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Egreso).HasColumnType("datetime");
            entity.Property(e => e.Hora)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("hora");
            entity.Property(e => e.Ingreso).HasColumnType("datetime");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ShockRoomRegistroId).HasColumnName("ShockRoomRegistroID");
            entity.Property(e => e.ShockRoomTipoAnamnesisId).HasColumnName("ShockRoom_TipoAnamnesisID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

            entity.HasOne(d => d.Paciente).WithMany(p => p.ShockRoomAnamnesis)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Anamnesis_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.ShockRoomAnamnesis)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SockRomm_Anamnesis_Prestadores");

            entity.HasOne(d => d.ShockRoomRegistro).WithMany(p => p.ShockRoomAnamnesis)
                .HasForeignKey(d => d.ShockRoomRegistroId)
                .HasConstraintName("FK_ShockRoom_Anamnesis_ShockRoom_Registro");

            entity.HasOne(d => d.ShockRoomTipoAnamnesis).WithMany(p => p.ShockRoomAnamnesis)
                .HasForeignKey(d => d.ShockRoomTipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Anamnesis_ShockRoom_Tipo_Anamnesis");
        });

        modelBuilder.Entity<ShockRoomAnamnesisDetalle>(entity =>
        {
            entity.ToTable("ShockRoom_Anamnesis_Detalle");

            entity.Property(e => e.ShockRoomAnamnesisDetalleId).HasColumnName("ShockRoom_AnamnesisDetalleID");
            entity.Property(e => e.Pregunta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ShockRoomTipoAnamnesisId).HasColumnName("ShockRoom_TipoAnamnesisID");
            entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");
            entity.Property(e => e.ValorMaximo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("Valor_Maximo");
            entity.Property(e => e.ValorMinimo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("Valor_Minimo");

            entity.HasOne(d => d.ShockRoomTipoAnamnesis).WithMany(p => p.ShockRoomAnamnesisDetalle)
                .HasForeignKey(d => d.ShockRoomTipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Anamnesis_Detalle_ShockRoom_Tipo_Anamnesis");

            entity.HasOne(d => d.TipoRespuesta).WithMany(p => p.ShockRoomAnamnesisDetalle)
                .HasForeignKey(d => d.TipoRespuestaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Anamnesis_Detalle_Tipo_Respuesta");
        });

        modelBuilder.Entity<ShockRoomCamas>(entity =>
        {
            entity.ToTable("ShockRoom_Camas");

            entity.Property(e => e.ShockRoomCamasId).HasColumnName("ShockRoom_CamasID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShockRoomDerivAlHospital>(entity =>
        {
            entity.HasKey(e => e.ShockRoomDerivAlHospitalId).HasName("PK_ShockRoom_DerivAoCentro");

            entity.ToTable("ShockRoom_DerivAlHospital");

            entity.Property(e => e.ShockRoomDerivAlHospitalId).HasColumnName("ShockRoom_DerivAlHospitalID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.ShockRoomRegistroId).HasColumnName("ShockRoomRegistroID");
            entity.Property(e => e.ShockRoomTipoAnamnesisId).HasColumnName("ShockRoom_TipoAnamnesisID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.HasOne(d => d.Habitacion).WithMany(p => p.ShockRoomDerivAlHospital)
                .HasForeignKey(d => d.HabitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_DerivAoCentro_Habitaciones_Hospital");

            entity.HasOne(d => d.ShockRoomRegistro).WithMany(p => p.ShockRoomDerivAlHospital)
                .HasForeignKey(d => d.ShockRoomRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_DerivAlHospital_ShockRoom_Registro");

            entity.HasOne(d => d.ShockRoomTipoAnamnesis).WithMany(p => p.ShockRoomDerivAlHospital)
                .HasForeignKey(d => d.ShockRoomTipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_DerivAoCentro_ShockRoom_Tipo_Anamnesis");
        });

        modelBuilder.Entity<ShockRoomDerivInt>(entity =>
        {
            entity.ToTable("ShockRoom_DerivInt");

            entity.Property(e => e.ShockRoomDerivIntId).HasColumnName("ShockRoom_DerivIntID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ShockRoomCamasId).HasColumnName("ShockRoom_CamasID");
            entity.Property(e => e.ShockRoomRegistroId).HasColumnName("ShockRoomRegistroID");
            entity.Property(e => e.ShockRoomTipoAnamnesisId).HasColumnName("ShockRoom_TipoAnamnesisID");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.HasOne(d => d.ShockRoomCamas).WithMany(p => p.ShockRoomDerivInt)
                .HasForeignKey(d => d.ShockRoomCamasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_DerivInt_ShockRoom_Camas");

            entity.HasOne(d => d.ShockRoomTipoAnamnesis).WithMany(p => p.ShockRoomDerivInt)
                .HasForeignKey(d => d.ShockRoomTipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_DerivInt_ShockRoom_Tipo_Anamnesis");
        });

        modelBuilder.Entity<ShockRoomEventoDetalle>(entity =>
        {
            entity.ToTable("ShockRoom_Evento_Detalle");

            entity.Property(e => e.ShockRoomEventoDetalleId).HasColumnName("ShockRoom_EventoDetalleID");
            entity.Property(e => e.ShockRoomAnamnesisDetalleId).HasColumnName("ShockRoom_AnamnesisDetalleID");
            entity.Property(e => e.ShockRoomEventoEncabezadoId).HasColumnName("ShockRoom_EventoEncabezadoID");
            entity.Property(e => e.ValorId).HasColumnName("ValorID");

            entity.HasOne(d => d.ShockRoomAnamnesisDetalle).WithMany(p => p.ShockRoomEventoDetalle)
                .HasForeignKey(d => d.ShockRoomAnamnesisDetalleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Evento_Detalle_ShockRoom_Anamnesis_Detalle");

            entity.HasOne(d => d.ShockRoomEventoEncabezado).WithMany(p => p.ShockRoomEventoDetalle)
                .HasForeignKey(d => d.ShockRoomEventoEncabezadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Evento_Detalle_ShockRoom_Evento_Encabezado");
        });

        modelBuilder.Entity<ShockRoomEventoEncabezado>(entity =>
        {
            entity.HasKey(e => e.ShockRoomEventoEncabezadoId);

            entity.ToTable("ShockRoom_Evento_Encabezado");

            entity.Property(e => e.ShockRoomEventoEncabezadoId).HasColumnName("ShockRoom_EventoEncabezadoID");
            entity.Property(e => e.Crea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ShockRoomTipoAnamnesisId).HasColumnName("ShockRoom_TipoAnamnesisID");

            entity.HasOne(d => d.ShockRoomTipoAnamnesis).WithMany(p => p.ShockRoomEventoEncabezado)
                .HasForeignKey(d => d.ShockRoomTipoAnamnesisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Evento_Encabezado_ShockRoom_Tipo_Anamnesis");
        });

        modelBuilder.Entity<ShockRoomRegistro>(entity =>
        {
            entity.HasKey(e => e.ShockRoomRegistroId).HasName("PK_ShockRommRegistro");

            entity.ToTable("ShockRoom_Registro");

            entity.Property(e => e.ShockRoomRegistroId).HasColumnName("ShockRoomRegistroID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.MedicoSalidaId).HasColumnName("MedicoSalidaID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.TipoAltaId).HasColumnName("TipoAltaID");
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.HasOne(d => d.Paciente).WithMany(p => p.ShockRoomRegistro)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Registro_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.ShockRoomRegistro)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShockRoom_Registro_Prestadores");
        });

        modelBuilder.Entity<ShockRoomServicios>(entity =>
        {
            entity.HasKey(e => e.SockRoomServicioId).HasName("PK_SockRomm_Servicios");

            entity.ToTable("ShockRoom_Servicios");

            entity.Property(e => e.SockRoomServicioId).HasColumnName("SockRoom_ServicioID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShockRoomTipoAnamnesis>(entity =>
        {
            entity.ToTable("ShockRoom_Tipo_Anamnesis");

            entity.Property(e => e.ShockRoomTipoAnamnesisId).HasColumnName("ShockRoom_TipoAnamnesisID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ShockRoomServicioId).HasColumnName("ShockRoom_ServicioID");

            entity.HasOne(d => d.ShockRoomServicio).WithMany(p => p.ShockRoomTipoAnamnesis)
                .HasForeignKey(d => d.ShockRoomServicioId)
                .HasConstraintName("FK_ShockRoom_Tipo_Anamnesis_ShockRoom_Servicios");
        });

        modelBuilder.Entity<SituacionLaboral>(entity =>
        {
            entity.ToTable("Situacion_Laboral");

            entity.Property(e => e.SituacionLaboralId).HasColumnName("SituacionLaboralID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<SituacionTributaria>(entity =>
        {
            entity.HasKey(e => e.SituacionTribId);

            entity.Property(e => e.SituacionTribId).HasColumnName("SituacionTribID");
            entity.Property(e => e.Iva).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<SliderHome>(entity =>
        {
            entity.HasKey(e => e.SliderId);

            entity.Property(e => e.SliderId).HasColumnName("sliderID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.SliderEstado).HasColumnName("sliderEstado");
            entity.Property(e => e.SliderImgAlt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sliderImgAlt");
            entity.Property(e => e.SliderImgName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sliderImgName");
            entity.Property(e => e.SliderImgUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sliderImgUrl");
            entity.Property(e => e.SliderParagraph)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("sliderParagraph");
            entity.Property(e => e.SliderTitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sliderTitle");
        });

        modelBuilder.Entity<Solicitudes>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud);

            entity.Property(e => e.Apellido).HasMaxLength(70);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Documento).HasMaxLength(10);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.Matricula).HasMaxLength(50);
            entity.Property(e => e.Motivo).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(70);
            entity.Property(e => e.OpSolicita)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Password).HasMaxLength(30);
            entity.Property(e => e.Sector).HasMaxLength(70);
            entity.Property(e => e.Telefono).HasMaxLength(50);
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.Usuario).HasMaxLength(11);
        });

        modelBuilder.Entity<SolicitudesApi>(entity =>
        {
            entity.HasKey(e => e.ApiSolicitudId);

            entity.Property(e => e.ApiSolicitudId).HasColumnName("ApiSolicitudID");
            entity.Property(e => e.DatosEnviados).HasMaxLength(2000);
            entity.Property(e => e.Endpoint).HasMaxLength(1000);
            entity.Property(e => e.FechaRespuesta).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Message).HasMaxLength(2000);
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Telefonos>(entity =>
        {
            entity.Property(e => e.Numero)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.Persona).WithMany(p => p.Telefonos)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Telefonos_Personas");

            entity.HasOne(d => d.TipoTelefono).WithMany(p => p.Telefonos)
                .HasForeignKey(d => d.TipoTelefonoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Telefonos_Tipo_Telefonos");
        });

        modelBuilder.Entity<TemperaturaRn>(entity =>
        {
            entity.HasKey(e => e.TemperaturaId);

            entity.ToTable("TemperaturaRN");

            entity.Property(e => e.TemperaturaId).HasColumnName("TemperaturaID");
            entity.Property(e => e.AnamnesisRnid).HasColumnName("AnamnesisRNID");
            entity.Property(e => e.Minutos).HasColumnType("datetime");
            entity.Property(e => e.Temperatura).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<TicketTotem>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Documento).HasMaxLength(255);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.MotivoDerivacion).HasMaxLength(255);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.TicketId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TicketID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoAceptacion>(entity =>
        {
            entity.ToTable("Tipo_Aceptacion");

            entity.Property(e => e.TipoAceptacionId).HasColumnName("Tipo_AceptacionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoAcompañante>(entity =>
        {
            entity.ToTable("Tipo_Acompañante");

            entity.Property(e => e.TipoAcompañanteId).HasColumnName("Tipo_AcompañanteID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoActividad>(entity =>
        {
            entity.ToTable("Tipo_Actividad");

            entity.Property(e => e.TipoActividadId).HasColumnName("Tipo_ActividadID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoActualizacion>(entity =>
        {
            entity.Property(e => e.TipoActualizacionId).HasColumnName("TipoActualizacionID");
            entity.Property(e => e.DescripcionActualizacion)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoAdmisionHospital>(entity =>
        {
            entity.Property(e => e.TipoAdmisionHospitalId).HasColumnName("TipoAdmisionHospitalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoAislamiento>(entity =>
        {
            entity.HasKey(e => e.IdTipoAislamiento);

            entity.ToTable("Tipo_Aislamiento");

            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoAltaIntenado>(entity =>
        {
            entity.HasKey(e => e.TipoAltaId);

            entity.ToTable("Tipo_AltaIntenado");

            entity.Property(e => e.TipoAltaId).HasColumnName("TipoAltaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoAltaIosepId).HasColumnName("TipoAltaIosepID");
        });

        modelBuilder.Entity<TipoAnamnesis>(entity =>
        {
            entity.ToTable("Tipo_Anamnesis");

            entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.AsociadaId).HasColumnName("AsociadaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.Tabla)
                .HasMaxLength(200)
                .IsFixedLength();

            entity.HasOne(d => d.Servicio).WithMany(p => p.TipoAnamnesis)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK_Tipo_Anamnesis_Servicios");
        });

        modelBuilder.Entity<TipoAntitetanica>(entity =>
        {
            entity.HasKey(e => e.AntitetanicaId);

            entity.ToTable("Tipo_Antitetanica");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoBeneficiario>(entity =>
        {
            entity.Property(e => e.TipoBeneficiarioId).HasColumnName("TipoBeneficiarioID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoBuenaRegular>(entity =>
        {
            entity.ToTable("Tipo_BuenaRegular");

            entity.Property(e => e.TipoBuenaRegularId).HasColumnName("Tipo_BuenaRegularID");
            entity.Property(e => e.Anulado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCama>(entity =>
        {
            entity.Property(e => e.TipoCamaId).HasColumnName("TipoCamaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCapacitacion>(entity =>
        {
            entity.HasKey(e => e.TipoCapacitacionId).HasName("PK_TiposCapacitaciones");

            entity.Property(e => e.TipoCapacitacionId).HasColumnName("TipoCapacitacionID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuaioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoCasa>(entity =>
        {
            entity.ToTable("Tipo_Casa");

            entity.Property(e => e.TipoCasaId)
                .ValueGeneratedNever()
                .HasColumnName("TipoCasaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoCbancos>(entity =>
        {
            entity.HasKey(e => e.TipoCbancoId);

            entity.ToTable("Tipo_CBancos");

            entity.Property(e => e.TipoCbancoId).HasColumnName("TipoCBancoId");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCirugia>(entity =>
        {
            entity.ToTable("Tipo_Cirugia");

            entity.Property(e => e.TipoCirugiaId).HasColumnName("TipoCirugiaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoCompletoIncompletoNc>(entity =>
        {
            entity.HasKey(e => e.TipoCompletoIncompletoNc1);

            entity.ToTable("Tipo_CompletoIncompletoNc");

            entity.Property(e => e.TipoCompletoIncompletoNc1).HasColumnName("Tipo_CompletoIncompletoNc");
            entity.Property(e => e.Nombre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoCompra>(entity =>
        {
            entity.HasKey(e => e.TipoCompraId).HasName("PK_Far_Tipo_Movimiento");

            entity.Property(e => e.TipoCompraId).HasColumnName("TipoCompraID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoComprobante>(entity =>
        {
            entity.ToTable("Tipo_Comprobante");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoConsentimiento>(entity =>
        {
            entity.Property(e => e.TipoConsentimientoId).HasColumnName("TipoConsentimientoID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoConsulta>(entity =>
        {
            entity.Property(e => e.TipoConsultaId).HasColumnName("TipoConsultaID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoConsumirBono>(entity =>
        {
            entity.HasKey(e => e.IdTipoConsumirBono);

            entity.Property(e => e.DescripcionConsumirBono).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoContactoCovid>(entity =>
        {
            entity.HasKey(e => e.TipoContactoId);

            entity.ToTable("Tipo_ContactoCovid");

            entity.Property(e => e.TipoContactoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TipoContactoID");
            entity.Property(e => e.Nombre).HasMaxLength(12);
        });

        modelBuilder.Entity<TipoContactos>(entity =>
        {
            entity.HasKey(e => e.TipoContactoId);

            entity.ToTable("Tipo_Contactos");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCuentaContable>(entity =>
        {
            entity.ToTable("Tipo_CuentaContable");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoCuit>(entity =>
        {
            entity.ToTable("Tipo_CUIT");

            entity.Property(e => e.TipoCuitid).HasColumnName("TipoCUITId");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCuracion>(entity =>
        {
            entity.Property(e => e.TipoCuracionId).HasColumnName("TipoCuracionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDiabetes>(entity =>
        {
            entity.HasKey(e => e.TipoDiabeteId);

            entity.ToTable("Tipo_Diabetes");

            entity.Property(e => e.TipoDiabeteId).HasColumnName("Tipo_DiabeteID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoDieta>(entity =>
        {
            entity.Property(e => e.TipoDietaId).HasColumnName("TipoDietaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDiscapacidad>(entity =>
        {
            entity.Property(e => e.TipoDiscapacidadId).HasColumnName("TipoDiscapacidadID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.ToTable("Tipo_Documento");

            entity.Property(e => e.TipoDocumentoId).HasColumnName("TipoDocumentoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoDomicilio>(entity =>
        {
            entity.ToTable("Tipo_Domicilio");

            entity.Property(e => e.TipodomicilioId).HasColumnName("tipodomicilioId");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoEmergencia>(entity =>
        {
            entity.HasKey(e => e.EmergenciaId);

            entity.ToTable("Tipo_Emergencia");

            entity.Property(e => e.EmergenciaId).HasColumnName("EmergenciaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoEmpleado>(entity =>
        {
            entity.Property(e => e.TipoEmpleadoId).HasColumnName("TipoEmpleadoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEntidad>(entity =>
        {
            entity.Property(e => e.TipoEntidadId).HasColumnName("TipoEntidadID");
            entity.Property(e => e.DescripcionEntidad)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoEstadoAnimo>(entity =>
        {
            entity.ToTable("Tipo_Estado_Animo");

            entity.Property(e => e.TipoEstadoAnimoId).HasColumnName("Tipo_Estado_AnimoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEstadoMedicacionPaciente>(entity =>
        {
            entity.Property(e => e.TipoEstadoMedicacionPacienteId).HasColumnName("TipoEstadoMedicacionPacienteID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoEstadoMedicacionPacienteDetalle>(entity =>
        {
            entity.Property(e => e.TipoEstadoMedicacionPacienteDetalleId).HasColumnName("TipoEstadoMedicacionPacienteDetalleID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoEstadoRemito>(entity =>
        {
            entity.HasKey(e => e.EstadoId);

            entity.ToTable("Tipo_EstadoRemito");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoEtnia>(entity =>
        {
            entity.HasKey(e => e.EtniaId);

            entity.ToTable("Tipo_Etnia");

            entity.Property(e => e.EtniaId)
                .ValueGeneratedNever()
                .HasColumnName("EtniaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoGastos>(entity =>
        {
            entity.HasKey(e => e.TipoGastoId);

            entity.ToTable("Tipo_Gastos");

            entity.Property(e => e.TipoGastoId).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.TipoServicio).WithMany(p => p.TipoGastos)
                .HasForeignKey(d => d.TipoServicioId)
                .HasConstraintName("FK_Tipo_Gastos_Tipo_Servicio");
        });

        modelBuilder.Entity<TipoGoteo>(entity =>
        {
            entity.Property(e => e.TipoGoteoId).HasColumnName("TipoGoteoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoGuardia>(entity =>
        {
            entity.Property(e => e.TipoGuardiaId).HasColumnName("TipoGuardiaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
        });

        modelBuilder.Entity<TipoHorarioTrabajo>(entity =>
        {
            entity.ToTable("Tipo_Horario_Trabajo");

            entity.Property(e => e.TipoHorarioTrabajoId).HasColumnName("Tipo_Horario_TrabajoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoImagen>(entity =>
        {
            entity.Property(e => e.TipoImagenId).HasColumnName("TipoImagenID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.NombreImagenGuardada).HasMaxLength(200);
        });

        modelBuilder.Entity<TipoInformeDigital>(entity =>
        {
            entity.HasKey(e => e.TipoInformeDigitalId).HasName("PK_TipoInforme");

            entity.Property(e => e.TipoInformeDigitalId).HasColumnName("TipoInformeDigitalID");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoIngresos>(entity =>
        {
            entity.HasKey(e => e.TipoIngresoId);

            entity.ToTable("Tipo_Ingresos");

            entity.Property(e => e.TipoIngresoId).HasColumnName("TipoIngresoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoInstruccion>(entity =>
        {
            entity.ToTable("Tipo_Instruccion");

            entity.Property(e => e.TipoInstruccionId).HasColumnName("TipoInstruccionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoInternacion>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Tr_TipoInternacionInsert"));

            entity.Property(e => e.TipoInternacionId).HasColumnName("TipoInternacionID");
            entity.Property(e => e.Idp).HasColumnName("IDP");
            entity.Property(e => e.IdtipoHc).HasColumnName("IDTipoHC");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.IosepTipoInternacionId).HasColumnName("IosepTipoInternacionID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Vigencia).HasColumnName("vigencia");
        });

        modelBuilder.Entity<TipoInternacionIosep>(entity =>
        {
            entity.HasKey(e => e.TipoInternacionId).HasName("PK_TipoInternacioniosep");

            entity.ToTable("TipoInternacionIOSEP");

            entity.Property(e => e.TipoInternacionId).HasColumnName("TipoInternacionID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codigo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoKinesiologia>(entity =>
        {
            entity.Property(e => e.TipoKinesiologiaId).HasColumnName("TipoKinesiologiaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoLaboral>(entity =>
        {
            entity.ToTable("Tipo_Laboral");

            entity.Property(e => e.TipoLaboralId).HasColumnName("TipoLaboralID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoLlamador>(entity =>
        {
            entity.Property(e => e.TipoLlamadorId).HasColumnName("TipoLlamadorID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoMail>(entity =>
        {
            entity.ToTable("Tipo_Mail");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoMamas>(entity =>
        {
            entity.ToTable("Tipo_Mamas");

            entity.Property(e => e.TipoMamasId).HasColumnName("TipoMamasID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoMarcaAlfaBeta>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Tipo_MarcaAlfaBeta");

            entity.Property(e => e.Codigo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoMaterialConstruccion>(entity =>
        {
            entity.HasKey(e => e.TipoMateriaConsId);

            entity.ToTable("Tipo_MaterialConstruccion");

            entity.Property(e => e.TipoMateriaConsId)
                .ValueGeneratedNever()
                .HasColumnName("Tipo_MateriaConsID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoMovimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tipo_Movimiento");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMovimientoId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TipoMovimientoBanco>(entity =>
        {
            entity.HasKey(e => e.TipoMovimientosBancoId);

            entity.ToTable("Tipo_MovimientoBanco");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoNormalAlterado>(entity =>
        {
            entity.HasKey(e => e.NormalAlteradoId);

            entity.ToTable("Tipo_NormalAlterado");

            entity.Property(e => e.NormalAlteradoId).HasColumnName("NormalAlteradoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoNormalAnormal>(entity =>
        {
            entity.HasKey(e => e.TipoNormalId);

            entity.ToTable("Tipo_NormalAnormal");

            entity.Property(e => e.TipoNormalId).HasColumnName("TipoNormalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoOsculta>(entity =>
        {
            entity.HasKey(e => e.OscultaId);

            entity.ToTable("Tipo_Osculta");

            entity.Property(e => e.OscultaId).HasColumnName("OscultaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoPaciente>(entity =>
        {
            entity.Property(e => e.TipoPacienteId).HasColumnName("TipoPacienteID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoParentezco>(entity =>
        {
            entity.ToTable("Tipo_Parentezco");

            entity.Property(e => e.TipoParentezcoId).HasColumnName("TipoParentezcoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoParto>(entity =>
        {
            entity.ToTable("Tipo_Parto");

            entity.Property(e => e.TipoPartoId).HasColumnName("Tipo_PartoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoPedidoEnConsultorio>(entity =>
        {
            entity.HasKey(e => e.TipoPedidoId);

            entity.ToTable("Tipo_PedidoEnConsultorio");

            entity.Property(e => e.TipoPedidoId).HasColumnName("Tipo_PedidoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoPedidoInterno>(entity =>
        {
            entity.ToTable("Tipo_PedidoInterno");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaModi).HasColumnType("datetime");
            entity.Property(e => e.GeneraOdenCompra).HasColumnName("Genera_OdenCompra");
            entity.Property(e => e.MontoDesde).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoHasta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Normativa)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.OpModi)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPersona>(entity =>
        {
            entity.ToTable("Tipo_Persona");

            entity.Property(e => e.TipoPersonaId).HasColumnName("TipoPersonaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoPosicion>(entity =>
        {
            entity.Property(e => e.TipoPosicionId).HasColumnName("TipoPosicionID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPositivoNegativo>(entity =>
        {
            entity.HasKey(e => e.TipoPositivoId);

            entity.ToTable("Tipo_PositivoNegativo");

            entity.Property(e => e.TipoPositivoId).HasColumnName("TipoPositivoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoPrefesionalQuirofano>(entity =>
        {
            entity.HasKey(e => e.TipoProfesionalQuirofanoId).HasName("PK_Tabla1");

            entity.Property(e => e.TipoProfesionalQuirofanoId).HasColumnName("TipoProfesionalQuirofanoID");
            entity.Property(e => e.EspecialistaIosepId).HasColumnName("EspecialistaIosepID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<TipoPresentacionAlturaFeto>(entity =>
        {
            entity.HasKey(e => e.PresentacionAlturaFetoId);

            entity.ToTable("Tipo_PresentacionAlturaFeto");

            entity.Property(e => e.PresentacionAlturaFetoId).HasColumnName("PresentacionAlturaFetoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoPresentacionFetal>(entity =>
        {
            entity.HasKey(e => e.PresentacionFetalId);

            entity.ToTable("Tipo_PresentacionFetal");

            entity.Property(e => e.PresentacionFetalId).HasColumnName("PresentacionFetalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoRazonTrabajo>(entity =>
        {
            entity.ToTable("Tipo_Razon_Trabajo");

            entity.Property(e => e.TipoRazonTrabajoId).HasColumnName("Tipo_Razon_TrabajoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoRelacionesSexuales>(entity =>
        {
            entity.ToTable("Tipo_Relaciones_Sexuales");

            entity.Property(e => e.TipoRelacionesSexualesId).HasColumnName("Tipo_Relaciones_SexualesID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoRespuesta>(entity =>
        {
            entity.ToTable("Tipo_Respuesta");

            entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TablaExterna)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TipoValorId).HasColumnName("TipoValorID");
            entity.Property(e => e.ValoraAlmacenar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ValoraMostrar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");

            entity.HasOne(d => d.TipoValor).WithMany(p => p.TipoRespuesta)
                .HasForeignKey(d => d.TipoValorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tipo_Respuesta_Tipo_Valor");
        });

        modelBuilder.Entity<TipoRetencion>(entity =>
        {
            entity.ToTable("Tipo_Retencion");

            entity.Property(e => e.AlicuotaBasica)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("Alicuota_basica");
            entity.Property(e => e.AlicuotaIncremento)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("Alicuota_Incremento");
            entity.Property(e => e.AlicuotaMaxima)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("Alicuota_Maxima");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ImporteIncremento)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Incremento");
            entity.Property(e => e.ImporteMaximo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_maximo");
            entity.Property(e => e.ImporteMinimo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_Minimo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.ProcentajeRetencion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Procentaje_Retencion");
        });

        modelBuilder.Entity<TipoRevistaSala>(entity =>
        {
            entity.ToTable("Tipo_RevistaSala");

            entity.Property(e => e.TipoRevistaSalaId).HasColumnName("TipoRevistaSalaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoServicio>(entity =>
        {
            entity.ToTable("Tipo_Servicio");

            entity.Property(e => e.TipoServicioId).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FrecuenciaMeses).HasColumnName("Frecuencia_Meses");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoServicioAmb>(entity =>
        {
            entity.Property(e => e.TipoServicioAmbId).HasColumnName("TipoServicioAmbID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoSiNoNoContesta>(entity =>
        {
            entity.HasKey(e => e.TipoSiNoNoContesta1).HasName("PK_Tabla_SiNoNoContesta");

            entity.ToTable("Tipo_SiNoNoContesta");

            entity.Property(e => e.TipoSiNoNoContesta1)
                .ValueGeneratedNever()
                .HasColumnName("TipoSiNoNoContesta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(12)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoTeleSalud>(entity =>
        {
            entity.Property(e => e.TipoTeleSaludId).HasColumnName("TipoTeleSaludID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoTelefonos>(entity =>
        {
            entity.HasKey(e => e.TipoTelefonoId);

            entity.ToTable("Tipo_Telefonos");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoTenenciaVivienda>(entity =>
        {
            entity.HasKey(e => e.TipoTenenciaVivId);

            entity.ToTable("Tipo_TenenciaVivienda");

            entity.Property(e => e.TipoTenenciaVivId)
                .ValueGeneratedNever()
                .HasColumnName("TipoTenenciaVivID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoTrabJuvenil>(entity =>
        {
            entity.ToTable("Tipo_Trab_Juvenil");

            entity.Property(e => e.TipoTrabJuvenilId).HasColumnName("Tipo_Trab_JuvenilID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoTrabajos>(entity =>
        {
            entity.HasKey(e => e.TipoTrabajoId);

            entity.ToTable("Tipo_Trabajos");

            entity.Property(e => e.TipoTrabajoId).HasColumnName("Tipo_TrabajoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoTraslado>(entity =>
        {
            entity.Property(e => e.TipoTrasladoId).HasColumnName("TipoTrasladoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoUltimoPrevio>(entity =>
        {
            entity.HasKey(e => e.TipoUltimoPrevioId).HasName("PK_Tipo_UltimoPobre");

            entity.ToTable("Tipo_UltimoPrevio");

            entity.Property(e => e.TipoUltimoPrevioId).HasColumnName("Tipo_UltimoPrevioID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoValor>(entity =>
        {
            entity.ToTable("Tipo_Valor");

            entity.Property(e => e.TipoValorId).HasColumnName("TipoValorID");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Tabla)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoVehiculo>(entity =>
        {
            entity.Property(e => e.TipoVehiculoId).HasColumnName("TipoVehiculoID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoVentaAlfaBeta>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("Tipo_VentaAlfaBeta");

            entity.Property(e => e.Codigo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoVentilacion>(entity =>
        {
            entity.Property(e => e.TipoVentilacionId).HasColumnName("TipoVentilacionID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoZonaResidencia>(entity =>
        {
            entity.ToTable("Tipo_ZonaResidencia");

            entity.Property(e => e.TipoZonaResidenciaId)
                .ValueGeneratedNever()
                .HasColumnName("TipoZonaResidenciaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<TiposFeriados>(entity =>
        {
            entity.HasKey(e => e.TipoFeriadoId);

            entity.Property(e => e.TipoFeriadoId).HasColumnName("TipoFeriadoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TituloProfesional>(entity =>
        {
            entity.Property(e => e.TituloProfesionalId).HasColumnName("TituloProfesionalID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Titulos>(entity =>
        {
            entity.HasKey(e => e.TituloId);

            entity.Property(e => e.TituloId).HasColumnName("TituloID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCarga)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<TokenAclimed>(entity =>
        {
            entity.HasKey(e => e.IdToken);

            entity.Property(e => e.IdToken).HasColumnName("idToken");
            entity.Property(e => e.Anulado).HasColumnName("anulado");
            entity.Property(e => e.FechaCaduce)
                .HasColumnType("datetime")
                .HasColumnName("fechaCaduce");
            entity.Property(e => e.FechaCrea)
                .HasColumnType("datetime")
                .HasColumnName("fechaCrea");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Usado).HasColumnName("usado");
            entity.Property(e => e.Usuario)
                .HasMaxLength(11)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TramiteEstado>(entity =>
        {
            entity.Property(e => e.TramiteEstadoId).HasColumnName("TramiteEstadoID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Turnos>(entity =>
        {
            entity.HasKey(e => e.TurnoId);

            entity.ToTable(tb => tb.HasTrigger("Tr_Actualizar"));

            entity.HasIndex(e => new { e.ServicioId, e.ConsultorioId, e.FechaHora, e.Anulado }, "<Name of Missing Index, sysname,>");

            entity.HasIndex(e => new { e.Atendido, e.Admisionado, e.Anulado, e.Llegada }, "Index_Monitor");

            entity.HasIndex(e => new { e.Admisionado, e.Anulado, e.Llegada }, "TurnoConsulID");

            entity.HasIndex(e => new { e.ServicioId, e.ConsultorioId, e.PrestadorId, e.Admisionado, e.Anulado, e.TurnoId }, "TurnosIndice");

            entity.HasIndex(e => new { e.TurnoId, e.Llegada }, "_dta_index_Turnos_6_797297950__K1_K9");

            entity.HasIndex(e => new { e.ServicioId, e.ConsultorioId, e.PrestadorId, e.FechaHora, e.Anulado, e.TurnoId, e.PacienteId }, "_dta_index_Turnos_6_797297950__K3_K4_K5_K6_K25_K1_K2_9_11_12_13_24_40");

            entity.HasIndex(e => new { e.ServicioId, e.ConsultorioId, e.FechaHora, e.Anulado, e.PrestadorId, e.TurnoId, e.PacienteId }, "_dta_index_Turnos_6_797297950__K3_K4_K6_K25_K5_K1_K2_9_11_12_13_24_40");

            entity.HasIndex(e => new { e.FechaHora, e.PrestadorId }, "_dta_index_Turnos_6_797297950__K6D_K5_1_2_3_4_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_29_30_31_32_33_34_35_36_").IsDescending(true, false);

            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.AnterirorId).HasColumnName("AnterirorID");
            entity.Property(e => e.Atendido).HasColumnType("smalldatetime");
            entity.Property(e => e.BloqueoTat)
                .HasColumnType("datetime")
                .HasColumnName("BloqueoTAT");
            entity.Property(e => e.BonoId).HasColumnName("BonoID");
            entity.Property(e => e.ComienzaAtencion)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.ConfirmadoWpp).HasColumnName("ConfirmadoWPP");
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.ConsultorioIdadmision).HasColumnName("ConsultorioIDAdmision");
            entity.Property(e => e.ConsultorioVisorId).HasColumnName("ConsultorioVisorID");
            entity.Property(e => e.DatosCompletos).HasColumnType("datetime");
            entity.Property(e => e.DesbloqueoTat)
                .HasColumnType("datetime")
                .HasColumnName("DesbloqueoTAT");
            entity.Property(e => e.EmergenciaId).HasColumnName("EmergenciaID");
            entity.Property(e => e.FecModifica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCrea)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaHora)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Hora");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.HoraHasta)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("Hora_Hasta");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.JurisdiccionId).HasColumnName("JurisdiccionID");
            entity.Property(e => e.Llamado).HasColumnType("smalldatetime");
            entity.Property(e => e.LlamadoAdmision).HasColumnType("smalldatetime");
            entity.Property(e => e.Llegada).HasColumnType("smalldatetime");
            entity.Property(e => e.MotivoConsultaId).HasColumnName("MotivoConsultaID");
            entity.Property(e => e.NoAtendido).HasColumnType("smalldatetime");
            entity.Property(e => e.NomExpedienteId).HasColumnName("NomExpedienteID");
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Orden)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.TerminaAtencion)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.TipoTeleSaludId).HasColumnName("TipoTeleSaludID");
            entity.Property(e => e.TurnoIdoriginal).HasColumnName("TurnoIDOriginal");
            entity.Property(e => e.UserDesbloqueaTat)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("UserDesbloqueaTAT");

            entity.HasOne(d => d.Paciente).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Pacientes");

            entity.HasOne(d => d.Prestador).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Prestadores");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Servicios");
        });

        modelBuilder.Entity<TurnosHistorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Turnos_Historico");

            entity.Property(e => e.AnterirorId).HasColumnName("AnterirorID");
            entity.Property(e => e.Atendido).HasColumnType("smalldatetime");
            entity.Property(e => e.ComienzaAtencion)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.ConsultorioVisorId).HasColumnName("ConsultorioVisorID");
            entity.Property(e => e.EmergenciaId).HasColumnName("EmergenciaID");
            entity.Property(e => e.FecModifica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaHora)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Hora");
            entity.Property(e => e.HoraHasta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Hora_Hasta");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Llamado).HasColumnType("smalldatetime");
            entity.Property(e => e.Llegada).HasColumnType("smalldatetime");
            entity.Property(e => e.NoAtendido).HasColumnType("smalldatetime");
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Orden)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.TerminaAtencion)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
        });

        modelBuilder.Entity<TurnosQuirofano>(entity =>
        {
            entity.ToTable("Turnos_Quirofano");

            entity.Property(e => e.TurnosQuirofanoId).HasColumnName("TurnosQuirofanoID");
            entity.Property(e => e.CirugiaIosepId).HasColumnName("CirugiaIosepID");
            entity.Property(e => e.CirujanoId).HasColumnName("CirujanoID");
            entity.Property(e => e.DetOperacion).HasMaxLength(300);
            entity.Property(e => e.Diagnostico).HasMaxLength(500);
            entity.Property(e => e.DiagnosticoId).HasColumnName("DiagnosticoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaMod).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.InternacionId).HasColumnName("InternacionID");
            entity.Property(e => e.MotivoReprogramado).HasMaxLength(400);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PracticasEstadoId).HasColumnName("PracticasEstadoID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.QuirofanoId).HasColumnName("QuirofanoID");
            entity.Property(e => e.TipoCirugiaId).HasColumnName("TipoCirugiaID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioCrea).HasMaxLength(11);
            entity.Property(e => e.UsuarioMod).HasMaxLength(11);

            entity.HasOne(d => d.Paciente).WithMany(p => p.TurnosQuirofano)
                .HasForeignKey(d => d.PacienteId)
                .HasConstraintName("FK_Turnos_Quirofano_Pacientes");

            entity.HasOne(d => d.PracticasEstado).WithMany(p => p.TurnosQuirofano)
                .HasForeignKey(d => d.PracticasEstadoId)
                .HasConstraintName("FK_Turnos_Quirofano_PracticasEstado");

            entity.HasOne(d => d.Prestador).WithMany(p => p.TurnosQuirofano)
                .HasForeignKey(d => d.PrestadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Quirofano_Prestadores");

            entity.HasOne(d => d.TipoCirugia).WithMany(p => p.TurnosQuirofano)
                .HasForeignKey(d => d.TipoCirugiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Quirofano_Tipo_Cirugia");

            entity.HasOne(d => d.Turno).WithMany(p => p.TurnosQuirofano)
                .HasForeignKey(d => d.TurnoId)
                .HasConstraintName("FK_Turnos_Quirofano_Turnos");
        });

        modelBuilder.Entity<TurnosReplanificados>(entity =>
        {
            entity.HasKey(e => e.TurnoRepId).HasName("PK_TurnosReplanificados_1");

            entity.Property(e => e.TurnoRepId).HasColumnName("TurnoRepID");
            entity.Property(e => e.AnterirorId).HasColumnName("AnterirorID");
            entity.Property(e => e.Atendido).HasColumnType("smalldatetime");
            entity.Property(e => e.ComienzaAtencion)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.ConsultorioVisorId).HasColumnName("ConsultorioVisorID");
            entity.Property(e => e.EmergenciaId).HasColumnName("EmergenciaID");
            entity.Property(e => e.FecModifica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaHora)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Hora");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaReplanificado).HasColumnType("datetime");
            entity.Property(e => e.HoraHasta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Hora_Hasta");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Llamado).HasColumnType("smalldatetime");
            entity.Property(e => e.Llegada).HasColumnType("smalldatetime");
            entity.Property(e => e.NoAtendido).HasColumnType("smalldatetime");
            entity.Property(e => e.NomExpedienteId).HasColumnName("NomExpedienteID");
            entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");
            entity.Property(e => e.OpCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.OpModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Orden)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.TerminaAtencion)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.TipoTeleSaludId).HasColumnName("TipoTeleSaludID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.TurnoIdoriginal).HasColumnName("TurnoIDOriginal");
        });

        modelBuilder.Entity<TvMonitor>(entity =>
        {
            entity.Property(e => e.TvMonitorId).HasColumnName("TvMonitorID");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TipoLlamadorId).HasColumnName("TipoLlamadorID");
        });

        modelBuilder.Entity<UltimoTurnoRecomendado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
        });

        modelBuilder.Entity<UnificacionUsHc>(entity =>
        {
            entity.HasKey(e => e.UnificacionId);

            entity.ToTable("UnificacionUsHC");

            entity.Property(e => e.UnificacionId).HasColumnName("unificacionID");
            entity.Property(e => e.Documento).HasMaxLength(12);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(300);
            entity.Property(e => e.Operador)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PacienteIdhc).HasColumnName("PacienteIDHC");
            entity.Property(e => e.PacienteInactivoIdhc).HasColumnName("PacienteInactivoIDHC");
            entity.Property(e => e.UsuarioAnula).HasMaxLength(11);
        });

        modelBuilder.Entity<UnificacionUsHcdetalle>(entity =>
        {
            entity.HasKey(e => e.DetalleId);

            entity.ToTable("UnificacionUsHCDetalle");

            entity.Property(e => e.DetalleId).HasColumnName("detalleID");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TablaId).HasColumnName("tablaID");
            entity.Property(e => e.UnificacionId).HasColumnName("unificacionID");
        });

        modelBuilder.Entity<UsuarioConsultas>(entity =>
        {
            entity.HasKey(e => e.UsuarioConsultaId);

            entity.Property(e => e.UsuarioConsultaId).HasColumnName("UsuarioConsultaID");
            entity.Property(e => e.Clave).HasMaxLength(50);
            entity.Property(e => e.Detalle).HasMaxLength(300);
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.TipoConsultaId).HasColumnName("TipoConsultaID");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<UsuarioConsultorioAdmins>(entity =>
        {
            entity.HasKey(e => e.UsuarioConsultorioAdminId);

            entity.Property(e => e.UsuarioConsultorioAdminId).HasColumnName("UsuarioConsultorioAdminID");
            entity.Property(e => e.Anulado).HasDefaultValue(false);
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(128)
                .HasColumnName("UsuarioID");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Vigencia).HasColumnType("datetime");
        });

        modelBuilder.Entity<UsuarioHistoriaClinicaWeb>(entity =>
        {
            entity.HasKey(e => e.UsuarioHistoriaClinicaId);

            entity.Property(e => e.UsuarioHistoriaClinicaId).HasColumnName("UsuarioHistoriaClinicaID");
            entity.Property(e => e.Clave).HasMaxLength(500);
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(300)
                .HasColumnName("UsuarioID");
        });

        modelBuilder.Entity<UsuarioXdeposito>(entity =>
        {
            entity.HasKey(e => e.UsuarioDepositoId);

            entity.ToTable("UsuarioXDeposito");

            entity.Property(e => e.UsuarioDepositoId).HasColumnName("UsuarioDepositoID");
            entity.Property(e => e.DepositoId).HasColumnName("DepositoID");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<Vacunas>(entity =>
        {
            entity.HasKey(e => e.VacunaId);

            entity.Property(e => e.VacunaId).HasColumnName("VacunaID");
            entity.Property(e => e.Descripción)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.EdadId).HasColumnName("EdadID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsFixedLength();

            entity.HasOne(d => d.Edad).WithMany(p => p.Vacunas)
                .HasForeignKey(d => d.EdadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vacunas_Vacunas_Edades");

            entity.HasOne(d => d.Grupo).WithMany(p => p.Vacunas)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vacunas_Vacunas_Grupos");
        });

        modelBuilder.Entity<VacunasEdades>(entity =>
        {
            entity.HasKey(e => e.EdadId);

            entity.ToTable("Vacunas_Edades");

            entity.Property(e => e.EdadId).HasColumnName("EdadID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsFixedLength();
        });

        modelBuilder.Entity<VacunasGrupos>(entity =>
        {
            entity.HasKey(e => e.GrupoId);

            entity.ToTable("Vacunas_Grupos");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<VacunasPacientes>(entity =>
        {
            entity.HasKey(e => e.VacunasId);

            entity.ToTable("Vacunas_Pacientes");

            entity.Property(e => e.VacunasId).HasColumnName("VacunasID");
            entity.Property(e => e.CentrosVacunacionId).HasColumnName("CentrosVacunacionID");
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.FechaAplica).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.Nlote)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NLote");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.VacunaId).HasColumnName("VacunaID");
            entity.Property(e => e.VacunasIdoriginal).HasColumnName("VacunasIDOriginal");

            entity.HasOne(d => d.Vacuna).WithMany(p => p.VacunasPacientes)
                .HasForeignKey(d => d.VacunaId)
                .HasConstraintName("FK_Vacunas_Pacientes_Vacunas");
        });

        modelBuilder.Entity<VigenciaTerminosCondiciones>(entity =>
        {
            entity.HasKey(e => e.VigenciaId);

            entity.Property(e => e.VigenciaId).HasColumnName("VigenciaID");
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(11)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwArticulos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Articulos");

            entity.Property(e => e.Articulo).HasMaxLength(1);
            entity.Property(e => e.Codbarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.Heladera)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(44)
                .IsFixedLength();
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(24)
                .IsFixedLength();
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwArticulos1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwArticulos");

            entity.Property(e => e.Articulo).HasMaxLength(1);
            entity.Property(e => e.Codbarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.FechaUltCompra)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_UltCompra");
            entity.Property(e => e.Heladera)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Iva).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(44)
                .IsFixedLength();
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Compra");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(24)
                .IsFixedLength();
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwGrillaTurnos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_GrillaTurnos");

            entity.Property(e => e.Expr1)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Expr2)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Expr3)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.Frecuencia)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.MDesde)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("M_Desde");
            entity.Property(e => e.MHasta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("M_Hasta");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NDesde)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("N_Desde");
            entity.Property(e => e.NHasta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("N_Hasta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TDesde)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("T_Desde");
            entity.Property(e => e.THasta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("T_Hasta");
        });

        modelBuilder.Entity<VwManualDatCobertura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ManualDatCobertura");

            entity.Property(e => e.Baja)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.CoberturaAmbulatorio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Cobertura_ambulatorio");
            entity.Property(e => e.CoberturaInternado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Cobertura_Internado");
            entity.Property(e => e.CodBarras)
                .HasMaxLength(13)
                .IsFixedLength();
            entity.Property(e => e.Fecha)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Laboratorio)
                .HasMaxLength(16)
                .IsFixedLength();
            entity.Property(e => e.Marca)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(44)
                .IsFixedLength();
            entity.Property(e => e.Precio).HasColumnType("numeric(9, 0)");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(24)
                .IsFixedLength();
            entity.Property(e => e.Registro)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("registro");
            entity.Property(e => e.Tamano)
                .HasMaxLength(32)
                .IsFixedLength();
            entity.Property(e => e.Troquel)
                .HasMaxLength(7)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwPlanillaTurnos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwPlanilla_Turnos");

            entity.Property(e => e.Consultorio)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.Prestador)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
        });

        modelBuilder.Entity<VwRolesMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwRolesMenu");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.RoleId).HasMaxLength(128);
        });

        modelBuilder.Entity<VwTurnosDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_TurnosDetalle");

            entity.Property(e => e.Atendido).HasColumnType("smalldatetime");
            entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");
            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Expr1)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Expr2)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Expr3)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.FechaHora)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha_Hora");
            entity.Property(e => e.Llamado).HasColumnType("smalldatetime");
            entity.Property(e => e.Llegada).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PacienteId).HasColumnName("PacienteID");
            entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");
            entity.Property(e => e.ServicioId).HasColumnName("ServicioID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
