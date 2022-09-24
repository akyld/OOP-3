using OOP_3;

ICreditManeger personalFinanceCreditManeger = new PersonalFinanceCreditManeger();
ICreditManeger vehicleCreditManeger = new VehicleCreditManeger();
ICreditManeger housingCreditManeger = new HousingCreditManeger();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

ApplicationManeger applicationManeger = new ApplicationManeger();

List<ICreditManeger> credits = new List<ICreditManeger>() {housingCreditManeger , vehicleCreditManeger , personalFinanceCreditManeger };
List<ILoggerService> loggerServices = new List<ILoggerService>() {databaseLoggerService,fileLoggerService };


applicationManeger.CreditInformation(credits);

applicationManeger.Application(housingCreditManeger,loggerServices);

