## Instructions extracted from here : http://stackoverflow.com/documentation/xamarin.ios/6091/binding-swift-libraries

framework='CSStickyHeaderFlowLayout.framework'
sdk='iphoneos10.3'

### -----------------------------------------
### GENERATE FAT LIBRARY
### -----------------------------------------

## Delete old output
echo 'Delete old output'
rm -rf output
mkdir output
echo '\n'

## Copy framework
echo 'Copy framework'
cp -rf input/Release-iphonesimulator/$framework.framework output/$framework.framework
echo '\n'

## Build
echo 'Build'
lipo -create input/Release-iphonesimulator/$framework.framework/$framework input/Release-iphoneos/$framework.framework/$framework -output output/$framework.framework/$framework
echo '\n'

## Copy result to output
echo 'Copy result to output'
cp -r input/Release-iphoneos/$framework.framework/Modules/$framework.swiftmodule/* output/$framework.framework/Modules/$framework.swiftmodule
echo '\n'

### -----------------------------------------
### GENERATE API DEFINITION
### -----------------------------------------

echo 'GENERATE API DEFINITION'
cp output/$framework.framework/Headers/$framework-Swift.h output/$framework-Swift.h
sharpie bind -sdk $sdk output/$framework-Swift.h -o output
echo '\n'
