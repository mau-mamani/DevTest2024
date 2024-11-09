import { Box, Typography } from "@mui/material";
const Header = () => {
  return (
    <Box>
      <Typography
        className="header-title"
        variant="h2"
        sx={{ backgroundColor: "#f2f2f2", width: "100%",color: "black"}}
      >
        Online Polls
      </Typography>
    </Box>
  );
};

export default Header;
