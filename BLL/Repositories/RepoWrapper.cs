using BLL.IRepositories;
using BLL.Repo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class RepoWrapper : IRepoWrapper
    {
        private SmartContext _Context;
        private IAirportActivityRepo airportActivity ;
        private IAirPortRepo airPort ;
        private IBusinessOfferRepo businessOffer ;
        private ICountryRepo country ;
        private ICurrencyRepo currency ;
        private IDisabilityTypeRepo disabilityType ;
        private IEventsRepo events ;
        private IFieldEventsRepo fieldEvents ;
        private IFieldRepo field ;
        private IFieldValidationsRepo fieldValidations ;
        private IFlightRepo flight ;
        private IGarageRepo garage ;
        private IIntegrationConfigurationRepo integrationConfiguration ;
        private IIntegrationsTransactionsRepo integrationsTransactions ;
        private ILabPcrTypeRepo labPcrType ;
        private IOrganizationPackagRepo organizationPackag ;
        private IOrganizationRepo organization ;
        private IOrganizationTypeRepo organizationType ;
        private IPaymentTypeRepo paymentType ;
        private IPcrTypeRepo pcrType ;
        private IPermissionRepo permission ;
        private IPlaneRepo plane ;
        private IProductRepo product ;
        private IProductUnitsRepo productUnits ;
        private IReservationRepo reservation ;
        private IReservationTypeRepo reservationType ;
        private IRoleRepo role ;
        private IRoomRepo room ;
        private IRoomTypeRepo roomType ;
        private ISeatRepo seat ;
        private ISmartConfigurationsRepo smartConfigurations ;
        private IStatusTypeRepo statusType ;
        private ISuperMarketProductsRepo superMarketProducts ;
        private ITerminalRepo terminal ;
        private ITransportationDetailsRepo transportationDetails ;
        private ITransportationRepo transportation ;
        private ITransportationTypeRepo transportationType ;
        private ITripRepo trip ;
        private ITripTransportationRepo tripTransportation ;
        private IUnitRepo unit ;
        private IUserBusnessOffersRepo userBusnessOffers ;
        private IUserRepo user ;
        private IValidationRepo validation ;

        public RepoWrapper(SmartContext context)
        {
            _Context = context;
        }
        public IAirportActivityRepo _AirportActivity { get { if (airportActivity == null) airportActivity = new AirportActivityRepo(_Context); return airportActivity; } }

        public ICountryRepo _Country { get { if (country == null) country = new CountryRepo(_Context); return country; } }


        public IAirPortRepo _AirPort { get { if (airPort == null) airPort = new AirPortRepo(_Context); return airPort; } }

        public IBusinessOfferRepo _BusinessOffer { get { if (businessOffer == null) businessOffer = new BusinessOfferRepo(_Context); return businessOffer; } }

        public ICurrencyRepo _Currency { get { if (currency == null) currency = new CurrencyRepo(_Context); return currency; } }

        public IDisabilityTypeRepo _DisabilityType { get { if (disabilityType == null) disabilityType = new DisabilityTypeRepo(_Context); return disabilityType; } }

        public IEventsRepo _Events { get { if (events == null) events = new EventsRepo(_Context); return events; } }

        public IFieldEventsRepo _FieldEvents { get { if (fieldEvents == null) fieldEvents = new FieldEventsRepo(_Context); return fieldEvents; } }

        public IFieldRepo _Field { get { if (field == null) field = new FieldRepo(_Context); return field; } }

        public IFieldValidationsRepo _FieldValidations { get { if (fieldValidations == null) fieldValidations = new FieldValidationsRepo(_Context); return fieldValidations; } }

        public IFlightRepo _Flight { get { if (flight == null) flight = new FlightRepo(_Context); return flight; } }
                                   
        public IGarageRepo _Garage { get { if (garage == null) garage = new GarageRepo(_Context); return garage; } } 

        public IIntegrationConfigurationRepo _IntegrationConfiguration { get { if (integrationConfiguration == null) integrationConfiguration = new IntegrationConfigurationRepo(_Context); return integrationConfiguration; } }
        public IIntegrationsTransactionsRepo _IntegrationsTransactions { get { if (integrationsTransactions == null) integrationsTransactions = new IntegrationsTransactionsRepo(_Context); return integrationsTransactions; } }

        public ILabPcrTypeRepo _LabPcrType { get { if (labPcrType == null) labPcrType = new LabPcrTypeRepo(_Context); return labPcrType; } }

        public IOrganizationPackagRepo _OrganizationPackag { get { if (organizationPackag == null) organizationPackag = new OrganizationPackagRepo(_Context); return organizationPackag; } }
        public IOrganizationRepo _Organization { get { if (organization == null) organization = new OrganizationRepo(_Context); return organization; } }

        public IOrganizationTypeRepo _OrganizationType { get { if (organizationType == null) organizationType = new OrganizationTypeRepo(_Context); return organizationType; } }
        public IPaymentTypeRepo _PaymentType { get { if (paymentType == null) paymentType = new PaymentTypeRepo(_Context); return paymentType; } }
        public IPcrTypeRepo _PcrType { get { if (pcrType == null) pcrType = new PcrTypeRepo(_Context); return pcrType; } }

        public IPermissionRepo _Permission { get { if (permission == null) permission = new PermissionRepo(_Context); return permission; } }

        public IPlaneRepo _Plane { get { if (plane == null) plane = new PlaneRepo(_Context); return plane; } }

        public IProductRepo _Product { get { if (product == null) product = new ProductRepo(_Context); return product; } }

        public IProductUnitsRepo _ProductUnits { get { if (productUnits == null) productUnits = new ProductUnitsRepo(_Context); return productUnits; } }
        public IReservationRepo _Reservation { get { if (reservation == null) reservation = new ReservationRepo(_Context); return reservation; } }

        public IReservationTypeRepo _ReservationType { get { if (reservationType == null) reservationType = new ReservationTypeRepo(_Context); return reservationType; } }

        public IRoleRepo _Role { get { if (role == null) role = new RoleRepo(_Context); return role; } }

        public IRoomRepo _Room { get { if (room == null) room = new RoomRepo(_Context); return room; } }

        public IRoomTypeRepo _RoomType { get { if (roomType == null) roomType = new RoomTypeRepo(_Context); return roomType; } }

        public ISeatRepo _Seat { get { if (seat == null) seat = new SeatRepo(_Context); return seat; } }

        public ISmartConfigurationsRepo _SmartConfigurations { get { if (smartConfigurations == null) smartConfigurations = new SmartConfigurationsRepo(_Context); return smartConfigurations; } }

        public IStatusTypeRepo _StatusType { get { if (statusType == null) statusType = new StatusTypeRepo(_Context); return statusType; } }

        public ISuperMarketProductsRepo _SuperMarketProducts { get { if (superMarketProducts == null) superMarketProducts = new SuperMarketProductsRepo(_Context); return superMarketProducts; } }
        public ITerminalRepo _Terminal { get { if (terminal == null) terminal = new TerminalRepo(_Context); return terminal; } }

        public ITransportationDetailsRepo _TransportationDetails { get { if (transportationDetails == null) transportationDetails = new TransportationDetailsRepo(_Context); return transportationDetails; } }

        public ITransportationRepo _Transportation { get { if (transportation == null) transportation = new TransportationRepo(_Context); return transportation; } }
        public ITransportationTypeRepo _TransportationType { get { if (transportationType == null) transportationType = new TransportationTypeRepo(_Context); return transportationType; } }

        public ITripRepo _Trip { get { if (trip == null) trip = new TripRepo(_Context); return trip; } }

        public ITripTransportationRepo _TripTransportation { get { if (tripTransportation == null) tripTransportation = new TripTransportationRepo(_Context); return tripTransportation; } }

        public IUnitRepo _Unit { get { if (unit == null) unit = new UnitRepo(_Context); return unit; } }
        public IUserBusnessOffersRepo _UserBusnessOffers { get { if (userBusnessOffers == null) userBusnessOffers = new UserBusnessOffersRepo(_Context); return userBusnessOffers; } }

        public IUserRepo _User { get { if (user == null) user = new UserRepo(_Context); return user; } }
        public IValidationRepo _Validation { get { if (validation == null) validation = new ValidationRepo(_Context); return validation; } }

        public async Task<List<T>> GetOracle<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            return await TestQuery.GetOracle<T>(squery, para, type);
        }

        public async  Task<List<T>> GetSql<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            return await TestQuery.GetSql<T>(squery, para, type);
        }

        public void Save()
        {
            try 
            {
                _Context.SaveChangesAsync();
            }
            catch(Exception ex) 
            {
                _Context.SaveChanges();
            }
        }
    }
}
