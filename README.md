**Run the followings from "PatientPortal" directory**

```sh
docker image build -t mushfiq4513/patient-portal:api -f PatientPortal.API/Dockerfile .

docker container run -d --name api -p 8000:5000 -e DOTNET_URLS=http://+:5000 mushfiq4513/patient-portal:api
```

**Test a API**

> http://localhost:8000/api/patient/get-all
