using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AdditionalTelephoneNumber
    {
        public string stdCode { get; set; }
        public string number { get; set; }
    }

    public class Address
    {
        public string organisation { get; set; }
        public string flatNo { get; set; }
        public string houseName { get; set; }
        public string houseNo { get; set; }
        public string thoroughfare { get; set; }
        public string street { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string locality { get; set; }
        public string doubleLocality { get; set; }
        public Postcode postcode { get; set; }
    }

    public class Cover
    {
        public int annualMileageId { get; set; }
        public object bestQuote { get; set; }
        public int classOfUseId { get; set; }
        public int coverTypeId { get; set; }
        public bool insuranceDeclined { get; set; }
        public int noClaimBonusId { get; set; }
        public int paymentTypeId { get; set; }
        public object radius { get; set; }
        public DateTime startDate { get; set; }
        public int voluntaryExcessId { get; set; }
        public bool wantNcbProtected { get; set; }
        public bool wantExcessProtected { get; set; }
        public int driverTypeId { get; set; }
        public object businessMileageId { get; set; }
        public object peakDrivingTimeId { get; set; }
        public bool usePeakTimes { get; set; }
        public bool useWeekendLate { get; set; }
        public object buildingsCover { get; set; }
        public object contentsCover { get; set; }
    }

    public class CrossSell
    {
        public int renewalMonth { get; set; }
        public bool receiveEmail { get; set; }
    }

    public class Customer
    {
        public string encryptedCustomerId { get; set; }
        public string email { get; set; }
        public Details details { get; set; }
        public Address address { get; set; }
        public MainTelephoneNumber mainTelephoneNumber { get; set; }
        public AdditionalTelephoneNumber additionalTelephoneNumber { get; set; }
        public UdprnDetails udprnDetails { get; set; }
        public MarketingDetails marketingDetails { get; set; }
    }

    public class Details
    {
        public int titleId { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public DateTime dob { get; set; }
        public int age { get; set; }
        public int maritalStatusId { get; set; }
        public DateTime ukResidentSince { get; set; }
        public FullTimeOccupation fullTimeOccupation { get; set; }
        public object partTimeOccupation { get; set; }
    }

    public class Driver
    {
        public bool iamCertificateHeld { get; set; }
        public object drivingLicenceNumber { get; set; }
        public Details details { get; set; }
        public DateTime licenceDate { get; set; }
        public int licenceTypeId { get; set; }
        public int medicalConditionId { get; set; }
        public int useOfOtherVehiclesId { get; set; }
        public bool mainDriver { get; set; }
        public object relationshipToProposerId { get; set; }
        public bool nonMotorConvictions { get; set; }
        public int totalConvictionsExcPending { get; set; }
        public List<object> claims { get; set; }
        public List<object> convictions { get; set; }
    }

    public class FullTimeOccupation
    {
        public int employmentStatusId { get; set; }
        public int occupationId { get; set; }
        public int businessId { get; set; }
    }

    public class MainTelephoneNumber
    {
        public string stdCode { get; set; }
        public string number { get; set; }
    }

    public class MarketingDetails
    {
        public int brandId { get; set; }
        public object referredById { get; set; }
        public bool optedIn { get; set; }
    }

    public class Postcode
    {
        public string postCode1 { get; set; }
        public string postCode2 { get; set; }
    }

    public class Proposer
    {
        public object businessTradingName { get; set; }
        public object businessYearEst { get; set; }
        public object companyTypeId { get; set; }
        public int noOfVehiclesInHousehold { get; set; }
        public bool homeOwner { get; set; }
        public bool childrenUnder16 { get; set; }
        public object otherVehicleNcbId { get; set; }
        public bool passPlus { get; set; }
        public int drivingExperienceId { get; set; }
        public int noOfChildrenUnder16Id { get; set; }
        public int yearsExperienceId { get; set; }
    }

    public class QuoteRequest
    {
        public string id { get; set; }
        public bool bestPriceOptIn { get; set; }
        public bool requote { get; set; }
        public bool multiQuote { get; set; }
        public object amendedFromQuoteRequestId { get; set; }
        public object mediaCode { get; set; }
        public string creationSource { get; set; }
        public DateTime creationDate { get; set; }
        public List<object> customerPreferences { get; set; }
        public bool expired { get; set; }
        public int quoteTypeId { get; set; }
        public string sessionId { get; set; }
    }

    public class Quote
    {
        public Customer customer { get; set; }
        public Driver driver { get; set; }
        public Proposer proposer { get; set; }
        public List<object> additionalDrivers { get; set; }
        public Vehicle vehicle { get; set; }
        public object property { get; set; }
        public Cover cover { get; set; }
        public QuoteRequest quoteRequest { get; set; }
        public CrossSell crossSell { get; set; }
        public object applicant { get; set; }
        public object jointApplicant { get; set; }
        public string journeyVersion { get; set; }
    }

    public class UdprnDetails
    {
        public string udprn { get; set; }
        public string uprn { get; set; }
        public string easting { get; set; }
        public string northing { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class Vehicle
    {
        public string abiCode { get; set; }
        public bool boughtVehicle { get; set; }
        public int parkedOvernightId { get; set; }
        public int parkedDaytimeId { get; set; }
        public int vehicleValue { get; set; }
        public DateTime purchaseDate { get; set; }
        public int yearOfManufacture { get; set; }
        public bool rhd { get; set; }
        public int noOfSeats { get; set; }
        public int securityId { get; set; }
        public int trackerId { get; set; }
        public string registrationNumber { get; set; }
        public int registeredKeeperId { get; set; }
        public int legalOwnerId { get; set; }
        public int importedId { get; set; }
        public int carrySignageId { get; set; }
        public bool internalRacking { get; set; }
        public bool hazardousGoods { get; set; }
        public bool visitHazardousSites { get; set; }
        public bool trailerCoverRequired { get; set; }
        public bool badDriverHotline { get; set; }
        public int transmissionId { get; set; }
        public double grossWeight { get; set; }
        public bool hasTipper { get; set; }
        public bool isRefrigerated { get; set; }
        public Postcode postcode { get; set; }
        public List<object> modifications { get; set; }
        public string makeDescription { get; set; }
        public string modelDescription { get; set; }
        public object manufacturedFrom { get; set; }
        public object manufacturedTo { get; set; }
        public object bodyTypeId { get; set; }
        public object fuelTypeId { get; set; }
        public object engineCc { get; set; }
        public object payload { get; set; }
    }


}
