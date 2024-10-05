# Compulsory-Assignment-1
![E-commerece platform](https://github.com/user-attachments/assets/c5b635d3-2f5c-4584-a4e8-dc8449c0729a)

![E-commerece platform (1)](https://github.com/user-attachments/assets/0ee442f7-f8be-402c-89cf-81a9e75ffe66)
![image](https://github.com/user-attachments/assets/9a734c80-5760-4295-beca-d3c1726588ab)


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
