dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.prod.whoop.com/developer/doc/openapi.json
autosdk generate openapi.yaml \
  --namespace Whoop \
  --clientClassName WhoopClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
