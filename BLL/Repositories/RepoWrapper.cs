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
        SmartContext _Context;


        private IAirportActivityRepo airportActivity { get; }
        private IAirPortRepo airPort { get; }
        private IBusinessOfferRepo businessOffer { get; }
        private ICountryRepo country { get; }
        private ICurrencyRepo currency { get; }
        private IDisabilityTypeRepo disabilityType { get; }
        private IEventsRepo events { get; }
        private IFieldEventsRepo fieldEvents { get; }
        private IFieldRepo field { get; }
        private IFieldValidationsRepo fieldValidations { get; }
        private IFlightRepo flight { get; }
        private IGarageRepo garage { get; }
        private IIntegrationConfigurationRepo integrationConfiguration { get; }
        private IIntegrationsTransactionsRepo integrationsTransactions { get; }
        private ILabPcrTypeRepo labPcrType { get; }
        private IOrganizationPackagRepo organizationPackag { get; }
        private IOrganizationRepo organization { get; }
        private IOrganizationTypeRepo organizationType { get; }
        private IPaymentTypeRepo paymentType { get; }
        private IPcrTypeRepo pcrType { get; }
        private IPermissionRepo permission { get; }
        private IPlaneRepo plane { get; }
        private IProductRepo product { get; }
        private IProductUnitsRepo productUnits { get; }
        private IReservationRepo reservation { get; }
        private IReservationTypeRepo reservationType { get; }
        private IRoleRepo role { get; }
        private IRoomRepo room { get; }
        private IRoomTypeRepo roomType { get; }
        private ISeatRepo seat { get; }
        private ISmartConfigurationsRepo smartConfigurations { get; }
        private IStatusTypeRepo statusType { get; }
        private ISuperMarketProductsRepo superMarketProducts { get; }
        private ITerminalRepo terminal { get; }
        private ITransportationDetailsRepo transportationDetails { get; }
        private ITransportationRepo transportation { get; }
        private ITransportationTypeRepo transportationType { get; }
        private ITripRepo trip { get; }
        private ITripTransportationRepo tripTransportation { get; }
        private IUnitRepo unit { get; }
        private IUserBusnessOffersRepo userBusnessOffers { get; }
        private IUserRepo user { get; }
        private IValidationRepo validation { get; }

        public RepoWrapper(SmartContext context)
        {
            _Context = context;
        }





        public IAirportActivityRepo _AirportActivity => throw new NotImplementedException();


        public IAirPortRepo _AirPort => throw new NotImplementedException();

        public IBusinessOfferRepo _BusinessOffer => throw new NotImplementedException();

        public ICountryRepo _Country => throw new NotImplementedException();

        public ICurrencyRepo _Currency => throw new NotImplementedException();

        public IDisabilityTypeRepo _DisabilityType => throw new NotImplementedException();

        public IEventsRepo _Events => throw new NotImplementedException();

        public IFieldEventsRepo _FieldEvents => throw new NotImplementedException();

        public IFieldRepo _Field => throw new NotImplementedException();

        public IFieldValidationsRepo _FieldValidations => throw new NotImplementedException();

        public IFlightRepo _Flight => throw new NotImplementedException();

        public IGarageRepo _Garage => throw new NotImplementedException();

        public IIntegrationConfigurationRepo _IntegrationConfiguration => throw new NotImplementedException();

        public IIntegrationsTransactionsRepo _IntegrationsTransactions => throw new NotImplementedException();

        public ILabPcrTypeRepo _LabPcrType => throw new NotImplementedException();

        public IOrganizationPackagRepo _OrganizationPackag => throw new NotImplementedException();

        public IOrganizationRepo _Organization => throw new NotImplementedException();

        public IOrganizationTypeRepo _OrganizationType => throw new NotImplementedException();

        public IPaymentTypeRepo _PaymentType => throw new NotImplementedException();

        public IPcrTypeRepo _PcrType => throw new NotImplementedException();

        public IPermissionRepo _Permission => throw new NotImplementedException();

        public IPlaneRepo _Plane => throw new NotImplementedException();

        public IProductRepo _Product => throw new NotImplementedException();

        public IProductUnitsRepo _ProductUnits => throw new NotImplementedException();

        public IReservationRepo _Reservation => throw new NotImplementedException();

        public IReservationTypeRepo _ReservationType => throw new NotImplementedException();

        public IRoleRepo _Role => throw new NotImplementedException();

        public IRoomRepo _Room => throw new NotImplementedException();

        public IRoomTypeRepo _RoomType => throw new NotImplementedException();

        public ISeatRepo _Seat => throw new NotImplementedException();

        public ISmartConfigurationsRepo _SmartConfigurations => throw new NotImplementedException();

        public IStatusTypeRepo _StatusType => throw new NotImplementedException();

        public ISuperMarketProductsRepo _SuperMarketProducts => throw new NotImplementedException();

        public ITerminalRepo _Terminal => throw new NotImplementedException();

        public ITransportationDetailsRepo _TransportationDetails => throw new NotImplementedException();

        public ITransportationRepo _Transportation => throw new NotImplementedException();

        public ITransportationTypeRepo _TransportationType => throw new NotImplementedException();

        public ITripRepo _Trip => throw new NotImplementedException();

        public ITripTransportationRepo _TripTransportation => throw new NotImplementedException();

        public IUnitRepo _Unit => throw new NotImplementedException();

        public IUserBusnessOffersRepo _UserBusnessOffers => throw new NotImplementedException();

        public IUserRepo _User => throw new NotImplementedException();

        public IValidationRepo _Validation => throw new NotImplementedException();

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
