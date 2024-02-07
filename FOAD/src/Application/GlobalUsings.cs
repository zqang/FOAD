global using Ardalis.GuardClauses;
global using AutoMapper;
global using AutoMapper.QueryableExtensions;
global using FluentValidation;
global using MediatR;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Logging;

global using System.Collections.Generic;
global using System.Linq;
global using System.Runtime.Serialization;
global using System.Threading.Tasks;

global using FOAD.EventBus.Events;

global using FOAD.Application.Common.Interfaces;
global using FOAD.Application.IntegrationEvents;
global using FOAD.Application.Models;
global using FOAD.Application.Orders.Commands.CreateOrder;
global using FOAD.Application.Extensions;
global using FOAD.Application.Orders.Commands.CancelOrder;
global using FOAD.Application.Common.Commands.Identified;

global using FOAD.Domain.AggregatesModel.OrderAggregate;
global using FOAD.Domain.Events;
global using FOAD.Domain.Interfaces;


global using FOAD.Infrastructure.Idempotency;


