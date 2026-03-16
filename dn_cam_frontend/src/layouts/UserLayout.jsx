import { Outlet } from 'react-router-dom';
import Header from '../components/Header'; 

const UserLayout = () => {
  return (
    <div className="min-h-screen bg-gray-50 font-sans">
      
      <Header /> 

      <main className="container mx-auto py-8 px-4 min-h-[70vh]">
        <Outlet /> 
      </main>

      <footer className="bg-gray-900 text-gray-300 p-8 text-center text-sm">
        <p>&copy; 2026 Dn_Cam. Đồ án tốt nghiệp hệ thống bán máy ảnh.</p>
      </footer>
    </div>
  );
};

export default UserLayout;