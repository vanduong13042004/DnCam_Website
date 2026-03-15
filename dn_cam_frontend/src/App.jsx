import { Routes, Route } from 'react-router-dom';
import UserLayout from './layouts/UserLayout';
import AdminLayout from './layouts/AdminLayout';
import HeroBanner from './components/HeroBanner'; // <-- Bạn quên import cái này

function App() {
  return (
    <Routes>
      {/* Khu vực cho Khách hàng */}
      <Route path="/" element={<UserLayout />}>
        <Route index element={<HeroBanner />} /> 
        <Route path="shop" element={<h1 className="text-2xl">Danh sách sản phẩm</h1>} />
        <Route path="introduce" element={<h1 className="text-2xl">Giới thiệu</h1>} />
      </Route>

      {/* Khu vực cho Admin */}
      <Route path="/admin" element={<AdminLayout />}>
        <Route index element={<h1>Dashboard Tổng quan</h1>} />
      </Route>
    </Routes>
  );
}

export default App;