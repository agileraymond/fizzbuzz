echo "--- building FizzBuzz ---"
cd src/FizzBuzz/
dotnet build

echo "--- building Runner ---"
cd ../FizzBuzzRunner/
dotnet build

echo "--- running Tests ---"
cd ../../test/FizzBuzzTests/
dotnet test

echo "-- done ---"
cd ../../
