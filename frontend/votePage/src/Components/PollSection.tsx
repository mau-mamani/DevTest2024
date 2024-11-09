import { Box, Button, Typography } from "@mui/material";
import { useEffect, useState } from "react";
import { Poll } from "../interfaces/PollInterfaces";
import { GetPolls } from "../services/PollService";

const PollSection = () => {
  const [polls, setPolls] = useState<Poll[]>([]);
  useEffect(() => {
    GetPolls().then((value: Poll[]) => {
      setPolls(value);
      console.log(value);
    });
  }, []);

  return (
    <Box sx={{ display: "flex", flexDirection: "column" }}>
      <Box sx={{ display: "flex", justifyContent: "space-between" }}>
        <Typography variant="h5" sx={{ color: "black" }}>
          Poll list
        </Typography>
        <Button>Add new</Button>
      </Box>
      {polls.map((poll, index) => {
        return <></>;
      })}
    </Box>
  );
};

export default PollSection;
