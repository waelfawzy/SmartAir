using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepositories
{
    public  interface IRepoWrapper
    {
        IAirportActivityRepo _AirportActivity { get; }
        IAirPortRepo _AirPort { get; }
        IBusinessOfferRepo _BusinessOffer { get; }
        ICountryRepo _Country { get; }
        ICurrencyRepo _Currency { get; }
        IDisabilityTypeRepo _DisabilityType { get; }
        IEventsRepo _Events { get; }
        IFieldEventsRepo _FieldEvents { get; }
        IFieldRepo _Field { get; }
        IFieldValidationsRepo _FieldValidations { get; }
        IFlightRepo _Flight { get; }
        IGarageRepo _Garage { get; }
        IIntegrationConfigurationRepo _IntegrationConfiguration { get; }
        IIntegrationsTransactionsRepo _IntegrationsTransactions { get; }
        ILabPcrTypeRepo _LabPcrType { get; }
        IOrganizationPackagRepo _OrganizationPackag { get; }
        IOrganizationRepo _Organization { get; }
        IOrganizationTypeRepo _OrganizationType { get; }
        IPaymentTypeRepo _PaymentType { get; }
        IPcrTypeRepo _PcrType { get; }
        IPermissionRepo _Permission { get; }
        IPlaneRepo _Plane { get; }
        IProductRepo _Product { get; }
        IProductUnitsRepo _ProductUnits { get; }
        IReservationRepo _Reservation { get; }
        IReservationTypeRepo _ReservationType { get; }
        IRoleRepo _Role { get; }
        IRoomRepo _Room { get; }
        IRoomTypeRepo _RoomType { get; }
        ISeatRepo _Seat { get; }
        ISmartConfigurationsRepo _SmartConfigurations { get; }
        IStatusTypeRepo _StatusType { get; }
        ISuperMarketProductsRepo _SuperMarketProducts { get; }
        ITerminalRepo _Terminal { get; }
        ITransportationDetailsRepo _TransportationDetails { get; }
        ITransportationRepo _Transportation { get; }
        ITransportationTypeRepo _TransportationType { get; }
        ITripRepo _Trip { get; }
        ITripTransportationRepo _TripTransportation { get; }
        IUnitRepo _Unit { get; }
        IUserBusnessOffersRepo _UserBusnessOffers { get; }
        IUserRepo _User { get; }
        IValidationRepo _Validation { get; }
        public   Task<List<T>> GetOracle<T>(string squery, Dictionary<string, object> para = null, int type = 0);
        public   Task<List<T>> GetSql<T>(string squery, Dictionary<string, object> para = null, int type = 0);
        void Save();
    }
}
