#!/bin/bash
use admin
db.createUser(
  {
    user: "amradmin",
    pwd: "123sta.com",
    roles: [ 
            { role: "readWrite", db: "evodb" },
            { role: "userAdminAnyDatabase", db: "admin" },
            { role: "root", db: "admin" } 
           ]
  }
);
