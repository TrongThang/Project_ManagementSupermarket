Ở các GUI có liên quan đến đường dẫn ảnh và đường dẫn Font chữ khi in File PDF. 
Tôi đã comment các pathImage và path của Font:
- Path Image mà có "..", "..","Image" thì dùng cho việc test khi chạy chương trình.
- Path Image mà có bắt đầu từ "Resource", "Image" / "Fonts" thì dùng cho việc Load ảnh khi cài đặt chương trình thành một ứng dụng để sử dụng.
=> Nếu bạn muốn để cả hai cho tiện thì có thể dùng lệnh if để kiểm tra xem đường dẫn nào có tồn tại thì dùng đường dẫn đấy.

