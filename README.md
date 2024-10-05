# Compulsory-Assignment-1
![E-commerece platform](https://github.com/user-attachments/assets/c5b635d3-2f5c-4584-a4e8-dc8449c0729a)

![image](https://github.com/user-attachments/assets/523dcb18-1216-4c3c-9882-ff478ba63162)
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
