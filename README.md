# Dependency Injection and Hexagonal Architecture
On this session we are going to tackle Dependency Injection and Hexagonal architecture based on the premise of [Clean code solid principles repo](https://github.com/bilelmsekni/CleanCode-Katas/tree/master/dotNet/SolidPrinciples)

## Overview

1. Create project with dotnet command line
2. Use API as an entry point to solve to the supermarket discount application
3. Dependency injection

### Create a project with dotnet command line

We are going to create a custom solution structure to fit in the principles of [Hexagonal architecture](https://netflixtechblog.com/ready-for-changes-with-hexagonal-architecture-b315ec967749) for further information check [this blog post](https://afreixasblog.wordpress.com/2021/05/04/creating-custom-solution-structures/)


We will create: 
* solution at the root folder
* src folder and presentation inside
* webapi project in src/presentation

## Challenge

1. Check product existence
2. Implement discounts

### Check product existence

On ProductServiceShould file, make Mock IProductRepository and unit test the following
* All products found
* Some missing
* None found

### Implement discounts

On UnitTests folder Create a DiscountServiceShould and unit test the following
* 12 units of the same product should get 50% discount
* 3 units of the same product should get one free
* 3 different single unit products should get one free
* 12 different products would get you 4 free products
