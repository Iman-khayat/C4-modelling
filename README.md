# Compulsory-Assignment-1
![image](https://github.com/user-attachments/assets/6854732b-97cc-4a1b-a5b2-e2920c1a1dd8)
![image](https://github.com/user-attachments/assets/7f84c5f1-9776-4da0-8a5f-927c9c62d5e9)
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
