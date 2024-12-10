#!/bin/bash

SAPassword=$1

echo "SELECT * FROM SYS.DATABASES" | dd of=testsqlconnection.sql
for i in {1..60};
do
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SAPassword -d master -i testsqlconnection.sql > /dev/null
    if [ $? -eq 0 ]
    then
        echo "SQL server ready"
        break
    else
        echo "Not ready yet..."
        sleep 1
    fi
done
rm testsqlconnection.sql

# Run the setup script to create the DB and the schema in the DB
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SAPassword -d master -i .devcontainer/mssql/setup.sql

echo "Restore complete"