/* src/App.css */

import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import './styles/App.css'; // Keeping App.css in case it's needed for general styles
import SignIn from './views/SignIn'; // Ensure the path is correct
import Onboarding from './views/Onboarding';
import ResetPassword from './views/ResetPassword';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/signin" element={<SignIn />} />
        <Route path="/onboarding" element={<Onboarding />} />
        <Route path="/reset-password" element={<ResetPassword />} />
        <Route path="/" element={<SignIn />} /> {/* Assuming you want to render SignIn as the default route */}
      </Routes>
    </Router>
  );
}

export default App;
