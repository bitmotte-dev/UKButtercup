#firstattempt=true
#userpath=""
#
#currentdir=$(pwd)
#
#echo ""
#echo "finding bundle. . ."
#
#userpath="../ModShortNameBundle/"
#currentdir=$(pwd)
#
#cd ${userpath}Library/com.unity.addressables/aa/Windows/StandaloneWindows64/
#
#bundle=$(find . -maxdepth 1 -name "*main*")
#bundle=${bundle#./}
#
#cd ${currentdir}
#
#echo "copying bundles to project resources (Directory 1/2)"
#cp "${userpath}Library/com.unity.addressables/aa/Windows/StandaloneWindows64/${bundle}" "./resources/main.bundle"
#echo "done! ! !"
#
#cd ${userpath}BuiltBundles/
#
#bundle=$(find . -maxdepth 1 -name "*scenes*")
#bundle=${bundle#./}
#
#cd ${currentdir}
#
#echo "copying bundles to project resources (Directory 2/2)"
#cp "${userpath}BuiltBundles/${bundle}" "./resources/scenes.bundle"
#echo "done! ! !"