import { useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import nProgress from 'nprogress';
import 'nprogress/nprogress.css'; // Ensure the CSS for nProgress is imported

export function useNProgress() {
  const location = useLocation();

  useEffect(() => {
    nProgress.configure({
      showSpinner: false, // Disabling the spinner globally
      speed: 5000, // Speed of the progress bar, adjust as needed
    });
    nProgress.start();
    nProgress.done(); // Start the progress bar when the location changes
    // console.log(nProgress);

    return () => {
      nProgress.done(); // End the progress bar when the component re-renders
      nProgress.remove(); // Remove the progress bar when the route changes are completed
    };
  }, [location]); // Dependency on location object
}
