using BrothersBlog.Services.Exceptions;
using BrothersBlog.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrothersBlog.Server.Base;

public class TControllerBase : ControllerBase
{
    private readonly IServiceProvider _serviceProvider;
    protected readonly IHomeService _homeService;
    protected readonly ILogger<TControllerBase> _logger;

    public TControllerBase(IServiceProvider serviceProvider)
    {
        this._serviceProvider = serviceProvider;

        _homeService = serviceProvider.GetService<IHomeService>() ?? throw new PropertyNullException();
        _logger = serviceProvider.GetService<ILogger<TControllerBase>>() ?? throw new PropertyNullException();
    }
}

