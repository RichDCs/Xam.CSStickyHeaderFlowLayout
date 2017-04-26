framework='CSStickyHeaderFlowLayout'
sdk='iphoneos10.3'
PROJECT_ROOT='/Users/richardlagrange/Projects/Xam.CSStickyHeaderFlowLayout/Objective_Sharpie/CSStickyHeaderFlowLayout'

### -----------------------------------------
### GENERATE FAT LIBRARY
### -----------------------------------------

## Delete old output
echo 'Delete old output'
rm -rf *.a
rm -rf output
mkdir output
echo '\n'

## Build
echo 'Make'
make
mv *.a output/
echo '\n'

### -----------------------------------------
### GENERATE API DEFINITION
### -----------------------------------------

echo 'GENERATE API DEFINITION'
sharpie bind --output=output --namespace=$framework --sdk=$sdk $PROJECT_ROOT/CSStickyHeaderFlowLayout/*.h
echo '\n'
