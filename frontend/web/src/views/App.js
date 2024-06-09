// Package Block
import { Suspense, lazy } from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import 'nprogress/nprogress.css'; // Ensure the CSS for nProgress is imported
// Component Block
// import LoadingPage from '../components/LoadingPage.js';

// Lazy load the components
const ProDashboard = lazy(() => import('./pages/proDashboard.js'));
const Onboarding = lazy(() => import('./pages/auth/onboarding.js'));
const ResetPassword = lazy(() => import('./pages/auth/resetPassword.js'));
const SignIn = lazy(() => import('./pages/auth/SignIn.js'));
const Congratulations = lazy(() =>
  import('./pages/auth/onboardingCompleted.js')
);
const NotFound = lazy(() => import('./404.js')); // Assuming you have a NotFound component

function App() {
  return (
    <Router>
      <Suspense>
        {/* Commenting fallback screen as per Christian requiremens */}
        {/* <Suspense fallback={<LoadingPage />}> */}{' '}
        {/* Display a loading indicator while components are loading */}
        <Routes>
          <Route path="/signin" element={<SignIn />} />
          <Route
            path="/congratulations-onboarding-completed"
            element={<Congratulations />}
          />
          <Route path="/pro/dashboard" element={<ProDashboard />} />
          <Route path="/onboarding" element={<Onboarding />} />
          <Route path="/reset-password" element={<ResetPassword />} />
          <Route path="/" element={<SignIn />} /> {/* Default route */}
          <Route path="*" element={<NotFound />} />{' '}
          {/* Catch-all route for undefined paths */}
        </Routes>
      </Suspense>
    </Router>
  );
}

export default App;
