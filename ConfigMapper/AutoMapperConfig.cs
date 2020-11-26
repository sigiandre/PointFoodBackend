using AutoMapper;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.ConfigMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Order
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            CreateMap<OrderDetailDto, OrderDetail>();
            CreateMap<OrderDetail, OrderDetailDto>();
            CreateMap<ProductDetailDto, ProductDetail>();
            CreateMap<ProductDetail, ProductDetailDto>();
            CreateMap<DataCollection<Order>,DataCollection<OrderDto>>();

            //OrderCreate
            CreateMap<OrderCreateDto, Order>();
            CreateMap<OrderDetailCreateDto, OrderDetail>();
            CreateMap<ProductDetailCreateDto, ProductDetail>();

            //Extra
            CreateMap<Extra, ExtraMenuDto>();
            CreateMap<Extra, ExtraOrderDto>();
            CreateMap<DataCollection<Extra>, DataCollection<ExtraMenuDto>>();
            CreateMap<DataCollection<Extra>, DataCollection<ExtraOrderDto>>();

            //Card
            CreateMap<Card, CardDto>();
            CreateMap<CardCreateDto, Card>();

            //Client
            CreateMap<Client, ClientDto>();
            CreateMap<ClientDto, Client>();
            CreateMap<ClientLoginDto, Client>();
            CreateMap<ClientLoginDto, ClientDto>();
            CreateMap<DataCollection<Client>, DataCollection<ClientDto>>();
            CreateMap<ClientCreateDto, Client>();

            //Product
            CreateMap<Product, ProductMenuDto>();
            CreateMap<Product, ProductOrderDto>();
            CreateMap<DataCollection<ProductMenuDto>, DataCollection<Product>>();
            CreateMap<DataCollection<ProductOrderDto>, DataCollection<Product>>();
            CreateMap<DataCollection<Product>, DataCollection<ProductMenuDto>>();
            CreateMap<DataCollection<Product>, DataCollection<ProductOrderDto>>();

            //Restaurant
            CreateMap<Restaurant, RestaurantDto>();
            CreateMap<RestaurantDto, Restaurant>();
            CreateMap<DataCollection<Restaurant>, DataCollection<RestaurantDto>>();

            //Restaurant Owner
            CreateMap<RestaurantOwner, RestaurantOwnerDto>();
            CreateMap<DataCollection<RestaurantOwner>, DataCollection<RestaurantOwnerDto>>();
            CreateMap<RestaurantOwnerDto, RestaurantOwner>();

            //Category
            CreateMap<Category, CategoryDto>();
            CreateMap<DataCollection<CategoryDto>, DataCollection<Category>>();
            CreateMap<DataCollection<Category>, DataCollection<CategoryDto>>();

            //State
            CreateMap<State, StateDto>();
            CreateMap<DataCollection<StateDto>, DataCollection<State>>();
            CreateMap<DataCollection<State>, DataCollection<StateDto>>();

            //Menu
            CreateMap<Menu, MenuDto>();
            CreateMap<MenuDto, Menu>();
            CreateMap<MenuProduct, MenuProductDto>();
            CreateMap<MenuProductDto, MenuProduct>();
            CreateMap<ProductExtra, ProductExtraDto>();
            CreateMap<ProductExtraDto, ProductExtra>();
            CreateMap<DataCollection<MenuDto>, DataCollection<Menu>>();
            CreateMap<DataCollection<Menu>, DataCollection<MenuDto>>();
        }
    }
}
