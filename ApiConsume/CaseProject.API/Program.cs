using CaseProject.API.Services.EmailMailKit;
using CaseProject.BusinessLayer.Abstract;
using CaseProject.BusinessLayer.Concrete;
using CaseProject.DataAccessLayer.Abstract;
using CaseProject.DataAccessLayer.Concrete;
using CaseProject.DataAccessLayer.EntityFramework;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();

builder.Services.AddScoped<IOrderDal, EfOrderDal>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<ISupplierDal, EfSupplierDal>();
builder.Services.AddScoped<ISupplierService, SupplierManager>();

builder.Services.AddScoped<IEmailSenderService, EmailSenderService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CaseApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CaseApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
