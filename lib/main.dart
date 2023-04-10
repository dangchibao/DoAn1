import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:instagram/responsive/mobile_screen_layout.dart';
import 'package:instagram/responsive/responsive_layout_screen.dart';
import 'package:instagram/responsive/web_screen_layout.dart';
import 'package:instagram/utils/colors.dart';
import 'package:firebase_core/firebase_core.dart';

void main() async{
  WidgetsFlutterBinding.ensureInitialized();
  if(kIsWeb){
    await Firebase.initializeApp(
          options: const FirebaseOptions( 
        apiKey:'AIzaSyAKUDCIPolbxeUvdU1_eyrpoopptLjwtfU', 
        appId:'1:651853179042:web:68bb16f282e3a0db3f4ffb', 
        messagingSenderId: '651853179042', 
        projectId: 'instagram-app-5448a',
        storageBucket: 'instagram-app-5448a.appspot.com',
     ),
    );      
  } else {
    await Firebase.initializeApp();
  }
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}):super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Instagram Clone',
      theme: ThemeData.dark().copyWith(
        scaffoldBackgroundColor: mobileBackgroundColor,
      ),
      home: const ResponsiveLayout(
        mobileScreenLayout: mobileScreenLayout(), 
        webScreenLayout: webScreenLayout(),
      ),
    );
  }
}
