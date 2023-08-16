import { Routes, Route } from "react-router-dom";
import HelpPage from "../pages/HelpPage";
import HomePage from "../pages/HomePage";
import SuppliersListPage from "../pages/SuppliersListPage";

export default function AppRoutes() {
  return (
    <Routes>
      <Route path="/" element={<HomePage />} />
      <Route path="/Help" element={<HelpPage />} />
      <Route path="/SuppliersList" element={<SuppliersListPage />} />
      
    </Routes>
  );
}
