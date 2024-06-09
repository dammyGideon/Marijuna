import { LogoText } from './Logo';

export default function Footer() {
  return (
    <div className="footer">
      <div className="logo-text">
        <LogoText />
      </div>
      <div className="footer-links">
        <a href="/support">Support</a>&nbsp;
        <a href="/referral">Referral</a>
      </div>
    </div>
  );
}
