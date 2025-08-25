using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ReportSchemas
{
    public int Id { get; set; }

    public bool? AirFilterMachine { get; set; }

    public string? Created { get; set; }

    public bool? DefibrillatorsAdults { get; set; }

    public bool? DefibrillatorsChildren { get; set; }

    public bool? MultiMonitorAdults { get; set; }

    public bool? MultiMonitorChildren { get; set; }

    public string? Other { get; set; }

    public bool? RespiratorsAdults { get; set; }

    public int? RespiratorsAllocatedAdult { get; set; }

    public int? RespiratorsAllocatedChildren { get; set; }

    public int? RespiratorsAvailableAdultCount { get; set; }

    public int? RespiratorsAvailableChildrenCount { get; set; }

    public bool? RespiratorsChildren { get; set; }

    public int? RespiratorsUnavailableAdultCount { get; set; }

    public int? RespiratorsUnavailableChildrenCount { get; set; }

    public bool? SuccessReportSalesforce { get; set; }

    public int? UtiAllocatedAdult { get; set; }

    public int? UtiAllocatedAdultGas { get; set; }

    public int? UtiAllocatedChildren { get; set; }

    public int? UtiAllocatedChildrenGas { get; set; }

    public int? UtiDischargedAdultCount { get; set; }

    public int? UtiDischargedChildrenCount { get; set; }

    public int? UtiDischargedDeadAdultCount { get; set; }

    public int? UtiDischargedDeadChildrenCount { get; set; }

    public int? UtiDischargedDerivativeAdultCount { get; set; }

    public int? UtiDischargedDerivativeChildrenCount { get; set; }

    public int? UtiGasAvailableAdultCount { get; set; }

    public int? UtiGasAvailableChildrenCount { get; set; }

    public int? UtiGasUnavailableAdultCount { get; set; }

    public int? UtiGasUnavailableChildrenCount { get; set; }

    public int? UtiHospitalizedAdultCount { get; set; }

    public int? UtiHospitalizedChildrenCount { get; set; }

    public bool? UtiIntensive { get; set; }

    public bool? VolInfPumps { get; set; }
}
