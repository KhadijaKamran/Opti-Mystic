# Opti-Mystic

## Problem Statement:
We see that if someone has issues with his/her vision, first gets it checked by an ophthalmologist and then the ophthalmologist refers the use of some spectacles. Then the person visits an optician and gets the required spectacles. The process is quite hectic for people who wear spectacles regularly. We observe that usually databases are designed either for the hospital or for the Optical Centre’s. The problem which we target here is the creation of such a database which manages a complete eye care Centre. This includes the record of customers buying the spectacles as well as that of the patients having several eye diseases.

## Requirements:
There are some doctors hired by our centre. There is a stock of products. These products include the Frames and glasses, contact lenses and medicines which may include eye drops. There are several people who visit the eye centre. They can either be a patient or a customer or both. A patient is treated by a doctor. And a doctor recommends the medicine to the patient. A customer can buy a list of products.
### Functional Requirements:
*	An interface which allows the user to enter either as an admin or as a receptionist.
*	Admin is given more rights as compared to the receptionist.

### How it is done in the software:

![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/889ef507-0e8d-49d2-ac1d-831665557184)

*	The receptionist can add details of customer and generate his/her total bill.
*	Can add a new patient.
*	Can update an already registered patient.
*	Can add a new doctor.

The software view is:

![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/23ef43ae-2d32-4629-891e-698f1e6fe7e4)

*	The admin can have access to some other details as well.
*	Admin can view the patient and doctors record.
*	Admin also has the rights to add another receptionist.

As done in our software:
![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/71bfc87f-4516-4639-b226-294cd9a2addb)

 
### Non-Functional Requirements:
*	Security:
  *	There is a proper login ID for the receptionist.
  * And the data is secured from the receptionist by creating a login separate for admin to provide sensitive details.
*	Maintainability:
  *	The system can be upgraded easily. However, there will be a need of database professional in order to add extra tables in the schema and upgrade the software functionality.

## Step by step ERD:
Several changes were made on the ERD’s when we started to practically work on our software.
There were several mistakes which were then corrected after consultation with the instructor.
Some of these mistakes were the creation of entity eye centre for no reason. And then creation of entities shop and clinic. We also removed the category entity. Since there was no need to create a separate entity, for the purpose of subcategory we added the category name as an attribute in the glasses table.

### The final ERD is displayed below:
![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/8ac69b8e-b09c-4beb-aaff-70285ef85389)

## SCHEMA:
```
Product (Sr, price) 
Glasses (GSr, quality, color, categoryName)
Medicine (MedSr,MedPrice,MedName,MedType)  
Frames (FSr, size,type,colour,gender) 
Contact lens (CLSr,price,type,color) 
ProductOrders (OrderNo,Sr) 
LoginUser (ID,Password,Username) 
Patients (PatientId, name, address, phone, DocCNIC, left CYL, right CYL, Addition, left sph, rigt sph) 
Orders (OrderNo, name, address, phone, payed,change, OrderDateOrderType) 
Orderpayment ( orderNo, TotalPrice)
Doctor (DocCnic, Name, sex,address,phone#, checkupfee)  
```

## SUB-Queries:
 ![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/9fe38e6c-1fae-45cf-9b58-20db9a2b872a)

## Triggers:
![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/13770774-cb24-4b8c-b0e9-d1fdf6fa25d4)

 
## Linking of MySQL and C#:
The schema was created in MySQL.
![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/314d42ad-8296-4a5e-a9ea-bac6b46933b0)

The interface is made in C#  

![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/7f3dd273-c6f5-4e63-be8e-8a7e0f7162d5)


The database is linked to C# using MySQLClient.

![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/cc59cebe-9143-43bd-88f7-5984417a8abd)

 

## Limitations:
* Extensive product dealing capabilities could be added.
*	Generating a receipt was quite difficult hence instead of that we added a button “Generate SUM” to display the total bill for the customer.
 ![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/fc7998da-eab3-4db3-a4c4-17a3e70f7fa0)

*	Change of admin to be done manually.
*	There is supposed to be only one admin of the management system.
![image](https://github.com/KhadijaKamran/Opti-Mystic/assets/46638501/834e002e-e8dd-4a9f-89a0-685e440ee5bf)

 
## Conclusion:
In the end we were able to implement a complete database that enables the person using database to maintain a complete record of products, buyers, patients, doctors and the order details.
We were able to link our database with an interactive interface that enables its users to effectively use the software and actually implement it in daily life.
