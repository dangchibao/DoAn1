import 'package:flutter/material.dart';
import 'package:open_loyalty/constant.dart';
import 'package:open_loyalty/view/account_info/components/replace_user.dart';

class ActionButton extends StatefulWidget {
  @override
  _ActionButtonState createState() => _ActionButtonState();
}

class _ActionButtonState extends State<ActionButton> {
  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.symmetric(vertical: 10.0),
      color: mSecondaryColor,
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceAround,
        children: [
          ElevatedButton(
            style: ElevatedButton.styleFrom(
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(15.0),
                side: BorderSide(color: mPrimaryColor),
              ),
              primary: mPrimaryColor,
              onPrimary: Colors.white,
            ),
            onPressed: () {
              Navigator.of(context).pushReplacement(
                MaterialPageRoute(builder: (context) => Repair_user()),
              );
            },
            child: Text(
              'Sửa thông tin',
              style: TextStyle(
                fontSize: mFontSize,
                fontWeight: FontWeight.w400,
              ),
            ),
          ),
          ElevatedButton(
            style: ElevatedButton.styleFrom(
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(15.0),
                side: BorderSide(color: Colors.deepOrange),
              ),
              primary: Colors.deepOrange,
              onPrimary: Colors.white,
            ),
            onPressed: () {
              // Xử lý sự kiện khi nút "Đổi mật khẩu" được nhấn
              // Thêm mã xử lý tại đây
            },
            child: Text(
              'Đổi mật khẩu',
              style: TextStyle(
                fontSize: mFontSize,
                fontWeight: FontWeight.w400,
              ),
            ),
          ),
        ],
      ),
    );
  }
}
