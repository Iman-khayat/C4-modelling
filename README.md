# Compulsory-Assignment-1
![E-commerece platform](https://github.com/user-attachments/assets/c5b635d3-2f5c-4584-a4e8-dc8449c0729a)
![E-commerece platform (2)](https://github.com/user-attachments/assets/9226d3e4-608c-4002-89a3-4a46057196a8)

 ![image](https://github.com/user-attachments/assets/9a734c80-5760-4295-beca-d3c1726588ab)


 Code (C4):

For the Shopping Cart component in the Web Application:
Classes:
CartController: Handles user interactions
CartService: Business logic for cart operations
CartRepository: Database interactions for cart data
CartItem: Represents an item in the cart
Product: Represents a product in the catalog


Rollback Instructions

  1. Rollback Product Ratings:
  - Execute the following SQL script:
    ```sql
    DROP TABLE ProductRatings;
    ```

  2. Rollback Product Categories:
  - Execute the following SQL scripts:
    ```sql
    ALTER TABLE Products
    DROP COLUMN category_id;

    DROP TABLE Categories;
    ```

  3. Rollback Initial Schema:
  - Execute the following SQL script:
    ```sql
    DROP TABLE Products;
    ```
To use this code:

Create a new ASP.NET Core Web API project.
Replace the contents of the Program.cs, Startup.cs, and Dockerfile with the provided code.
Create a docker-compose.yml file in the project root.
Build and run the Docker Compose project using docker-compose up.
This will start two instances of the Product Service container, each connected to a RabbitMQ broker and a PostgreSQL database. You can now access the service's API endpoints and publish messages to the RabbitMQ queue for asynchronous processing.
