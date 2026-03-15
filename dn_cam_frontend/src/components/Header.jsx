import { Link } from 'react-router-dom';
import { Search, ShoppingCart, User, Camera } from 'lucide-react';

const Header = () => {
  return (
    <header className="bg-white shadow-sm border-b sticky top-0 z-50">
      <div className="container mx-auto px-4 py-4 flex items-center justify-between">
        
        <Link to="/" className="flex items-center gap-2 text-2xl font-extrabold text-gray-900 tracking-tighter">
          <Camera className="w-8 h-8 text-blue-600" />
          <span>Dn_Cam</span>
        </Link>

        <nav className="hidden md:flex items-center gap-8 font-medium text-gray-600">
          <Link to="/" className="hover:text-blue-600 transition-colors">Trang chủ</Link>
          <Link to="/shop" className="hover:text-blue-600 transition-colors">Sản Phẩm</Link>
          <Link to="/introduce" className="hover:text-blue-600 transition-colors">Giới thiệu</Link>
        </nav>

        {/* Khu vực Tìm kiếm & Icon */}
        <div className="flex items-center gap-6">
          {/* Ô tìm kiếm */}
          <div className="relative hidden lg:block">
            <input 
              type="text" 
              placeholder="Tìm kiếm dòng máy..." 
              className="pl-10 pr-4 py-2 bg-gray-100 border-transparent rounded-full text-sm focus:outline-none focus:bg-white focus:border-blue-500 focus:ring-2 focus:ring-blue-200 w-64 transition-all"
            />
            <Search className="w-4 h-4 text-gray-400 absolute left-4 top-1/2 -translate-y-1/2" />
          </div>

          {/* Giỏ hàng có số lượng */}
          <Link to="/cart" className="relative text-gray-600 hover:text-blue-600 transition-colors">
            <ShoppingCart className="w-6 h-6" />
            <span className="absolute -top-2 -right-2 bg-red-500 text-white text-xs font-bold w-5 h-5 flex items-center justify-center rounded-full">
              3
            </span>
          </Link>
          
          {/* Nút Đăng nhập / User */}
          <Link to="/login" className="text-gray-600 hover:text-blue-600 transition-colors">
            <User className="w-6 h-6" />
          </Link>
        </div>

      </div>
    </header>
  );
};

export default Header;