using System.Net.Http;
using StaxFattMerchantApi.Api;
using StaxFattMerchantApi.Core;
using StaxFattMerchantApi.Core.Logging;
using StaxFattMerchantApi.Core.Models;

namespace StaxFattMerchantApi;

/// <summary>
/// API specification auto-generated from Laravel route definitions.
/// Base URL: https://apiprod.fattlabs.com
/// All routes require JWT authentication unless otherwise noted.
/// </summary>
public sealed class StaxFattMerchantApiClient
{
    public StaxFattMerchantApiClient(HttpClient httpClient, StaxFattMerchantApiClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "StaxFattMerchantApiClient/1.0.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.0.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "StaxFattMerchantApiClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        var auth = new AuthSchemes(options);
        Cache = new Cache(rawClient, server, auth);
        Charge = new Charge(rawClient, server, auth);
        Credit = new Credit(rawClient, server, auth);
        Customer = new Customer(rawClient, server, auth);
        DisputeFile = new DisputeFile(rawClient, server, auth);
        File = new File(rawClient, server, auth);
        HelloSign = new HelloSign(rawClient, server, auth);
        Integration = new Integration(rawClient, server, auth);
        Invoice = new Invoice(rawClient, server, auth);
        InvoiceSchedule = new InvoiceSchedule(rawClient, server, auth);
        Item = new Item(rawClient, server, auth);
        MerchantAdmin = new MerchantAdmin(rawClient, server, auth);
        PaymentMethod = new PaymentMethod(rawClient, server, auth);
        Reporting = new Reporting(rawClient, server, auth);
        Sandbox = new Sandbox(rawClient, server, auth);
        Self = new Self(rawClient, server, auth);
        Team = new Team(rawClient, server, auth);
        TeamApiKeys = new TeamApiKeys(rawClient, server, auth);
        TeamFundingAccounts = new TeamFundingAccounts(rawClient, server, auth);
        TeamOptions = new TeamOptions(rawClient, server, auth);
        TeamRegistration = new TeamRegistration(rawClient, server, auth);
        TeamUsers = new TeamUsers(rawClient, server, auth);
        Terminal = new Terminal(rawClient, server, auth);
        Transaction = new Transaction(rawClient, server, auth);
        UserAdmin = new UserAdmin(rawClient, server, auth);
        Verify = new Verify(rawClient, server, auth);
        WebPayment = new WebPayment(rawClient, server, auth);
        Webhook = new Webhook(rawClient, server, auth);
    }

    public Cache Cache { get; }

    /// <summary>
    /// One-time charge operations
    /// </summary>
    public Charge Charge { get; }

    /// <summary>
    /// Credit operations
    /// </summary>
    public Credit Credit { get; }

    /// <summary>
    /// Customer management
    /// </summary>
    public Customer Customer { get; }

    /// <summary>
    /// Dispute evidence file management
    /// </summary>
    public DisputeFile DisputeFile { get; }

    /// <summary>
    /// File management
    /// </summary>
    public File File { get; }

    /// <summary>
    /// HelloSign e-signature integration
    /// </summary>
    public HelloSign HelloSign { get; }

    /// <summary>
    /// Third-party integration management
    /// </summary>
    public Integration Integration { get; }

    /// <summary>
    /// Invoice management
    /// </summary>
    public Invoice Invoice { get; }

    /// <summary>
    /// Recurring invoice/schedule management
    /// </summary>
    public InvoiceSchedule InvoiceSchedule { get; }

    /// <summary>
    /// Item/product catalog management
    /// </summary>
    public Item Item { get; }

    /// <summary>
    /// System admin merchant operations
    /// </summary>
    public MerchantAdmin MerchantAdmin { get; }

    /// <summary>
    /// Payment method (tokenization) management
    /// </summary>
    public PaymentMethod PaymentMethod { get; }

    /// <summary>
    /// Reporting and summaries
    /// </summary>
    public Reporting Reporting { get; }

    public Sandbox Sandbox { get; }

    /// <summary>
    /// Current authenticated user operations
    /// </summary>
    public Self Self { get; }

    /// <summary>
    /// Team/merchant management
    /// </summary>
    public Team Team { get; }

    /// <summary>
    /// Team API key management
    /// </summary>
    public TeamApiKeys TeamApiKeys { get; }

    /// <summary>
    /// Team-level funding account management
    /// </summary>
    public TeamFundingAccounts TeamFundingAccounts { get; }

    /// <summary>
    /// Team option/settings management
    /// </summary>
    public TeamOptions TeamOptions { get; }

    /// <summary>
    /// Team registration/onboarding
    /// </summary>
    public TeamRegistration TeamRegistration { get; }

    /// <summary>
    /// Team user management
    /// </summary>
    public TeamUsers TeamUsers { get; }

    /// <summary>
    /// Terminal signature operations
    /// </summary>
    public Terminal Terminal { get; }

    /// <summary>
    /// Transaction processing and management
    /// </summary>
    public Transaction Transaction { get; }

    /// <summary>
    /// System admin user operations
    /// </summary>
    public UserAdmin UserAdmin { get; }

    /// <summary>
    /// Card verification
    /// </summary>
    public Verify Verify { get; }

    public WebPayment WebPayment { get; }

    /// <summary>
    /// Webhook management
    /// </summary>
    public Webhook Webhook { get; }
}
