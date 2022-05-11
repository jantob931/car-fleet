Create Table Car(
id varchar(200) constraint pk_id primary key,
registration_number varchar(200) ,
brand varchar(200),
model varchar(200)
);

Create Table technical_examination(
id_car varchar(200),
id varchar(200),
affected_date date,
next_examination_date date,
is_checked bit
constraint fk_id_car foreign key (id_car)
references Car(id)
);
 
Insert into Car (id,registration_number,brand,model)
values ('1','SGL61571','Porshe','Panamera');
 
 Insert into technical_examination (id_car,id,affected_date,next_examination_date,is_checked)
 values ('1','1','2022-05-01','2023-05-01',1);
